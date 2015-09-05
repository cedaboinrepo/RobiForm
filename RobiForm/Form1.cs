using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Needed for the MotorControl class, Phidget base classes, and the PhidgetException class
using Phidgets;
//Needed for the Phidget event handling classes
using Phidgets.Events;

namespace RobiForm
{
    public partial class Form1 : Form
    {
        static MotorControl motorControl;
        static List<RobotMotor> motors;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawIt(bool active)
        {
            SolidBrush brush = (active) ? new SolidBrush(Color.Green) : new SolidBrush(Color.Red);
            Graphics graphics = this.CreateGraphics();

            graphics.FillRectangle(brush, 220, 285, 10, 35);

            brush.Dispose();
            graphics.Dispose();
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            SetControllerMotorsSpeed(motorControl, Side.Both, 35.00);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SetControllerMotorsSpeed(motorControl, Side.Both, (0.00));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMotor1Speed.Text = string.Empty;
            txtMotor2Speed.Text = string.Empty;
            txtMotor1Acc.Text = string.Empty;
            txtMotor2Acc.Text = string.Empty;

            if (IsMotorControllerActive())
                SetControllerMotorsSpeed(motorControl, Side.Both, 0.00);

            tbSpeed.Value = 0;

            lbEvents.Items.Clear();

            if (motorControl != null)
            {
                //User input was read so we can terminate, close the MotorControl object
                motorControl.close();

                //Set the MotorControl object to null to get it out of memory
                motorControl = null;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            InitializeMotorController();
            // DrawIt();

            if (IsMotorControllerActive())
            {
                btnSpeed.Enabled = true;
                btnStop.Enabled = true;
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            SetControllerMotorsSpeed(motorControl, Side.Both, tbSpeed.Value);
        }

        #region motor

        private void SetControllerMotorsSpeed(MotorControl motorController, Side motorSide, double speed)
        {
            if (!IsMotorControllerActive())
            {
                lbEvents.Items.Add("Motor controller not attached to the system.");
                return;
            }

            var motorOperations = new List<Task>();

            switch (motorSide)
            {
                case Side.Left:
                    motorOperations.Add(ControlMotorSpeed(motorController, 0, speed));
                    break;
                case Side.Right:
                    motorOperations.Add(ControlMotorSpeed(motorController, 1, speed));
                    break;
                case Side.Both:
                    // for (var i = 0; i < motors.Count; i++)
                    // {
                    motorOperations.Add(ControlMotorSpeed(motorController, 0, -1 * speed));
                    motorOperations.Add(ControlMotorSpeed(motorController, 1, 1 * speed));
                    //  }
                    break;
            }

            Task.WhenAll(motorOperations).Wait();
        }

        private void SetControllerMotorsAceleration(MotorControl motorController, Side motorSide, double acceleration)
        {
            if (!IsMotorControllerActive())
            {
                lbEvents.Items.Add("Motor controller not attached to the system.");
                return;
            }

            var motorOperations = new List<Task>();

            switch (motorSide)
            {
                case Side.Left:
                    motorOperations.Add(ControlMotorAcceleration(motorController, 0, acceleration));
                    break;
                case Side.Right:
                    motorOperations.Add(ControlMotorAcceleration(motorController, 1, acceleration));
                    break;
                case Side.Both:
                    for (var i = 0; i < motors.Count; i++)
                    {
                        motorOperations.Add(ControlMotorAcceleration(motorController, i, acceleration));
                    }
                    break;
            }

            Task.WhenAll(motorOperations).Wait();
        }

        private Task ControlMotorSpeed(MotorControl motorController, int index, double speed)
        {
            return Task.Run(() =>
            {
                motorController.motors[index].Velocity = speed;
            });
        }

        private Task ControlMotorAcceleration(MotorControl motorController, int index, double acceleration)
        {
            return Task.Run(() =>
            {
                motorController.motors[index].Acceleration = acceleration;
            });
        }

        #endregion

        #region helpers

        private void InitializeMotorController()
        {
            motorControl = new MotorControl();


            // if (motorControl.Attached)
            // {

            //Hook the basic event handlers
            motorControl.Attach += new AttachEventHandler(motoControl_Attach);
            motorControl.Detach += new DetachEventHandler(motoControl_Detach);
            motorControl.Error += new ErrorEventHandler(motoControl_Error);

            //Hook the phidget specific event handlers
            motorControl.CurrentChange += new CurrentChangeEventHandler
                                                (motoControl_CurrentChange);
            motorControl.InputChange += new InputChangeEventHandler
                                                (motoControl_InputChange);
            motorControl.VelocityChange += new VelocityChangeEventHandler
                                                (motoControl_VelocityChange);

            motorControl.open();

            //Wait for a MotorControl device to be attached
            lbEvents.Items.Add("Waiting for MotorControl to be attached....");
            motorControl.waitForAttachment();
            lbEvents.Items.Add("MotorControl attached....");

            motors = new List<RobotMotor>();
            motors.Add(new RobotMotor
            {
                Id = 0,
                MotorControllerId = motorControl.SerialNumber,
                MotorSide = Side.Left,
                Location = MotorControllerLocation.Front,
            });
            motors.Add(new RobotMotor
            {
                Id = 1,
                MotorControllerId = motorControl.SerialNumber,
                MotorSide = Side.Right,
                Location = MotorControllerLocation.Front,
            });

            SetControllerMotorsSpeed(motorControl, Side.Both, 0.00);
            SetControllerMotorsAceleration(motorControl, Side.Both, 100.00);

            txtMotor1Acc.Text = "100.00";
            txtMotor2Acc.Text = "100.00";

            motor1.BackColor = Color.Green;
            motor2.BackColor = Color.Green;

            DrawIt(true);
            /* }
             else
             {
                 DrawIt(false);
                 motor1.BackColor = Color.Red;
                 motor2.BackColor = Color.Red;
                 lbEvents.Items.Add("Motor contoller is not attached");
             }*/
        }

        private bool IsMotorControllerActive()
        {
            return motorControl != null && motorControl.Attached;
        }

        #endregion

        #region events

        //Attach event hanlder. Display serial number of attached MotorControl phidget
        void motoControl_Attach(object sender, AttachEventArgs e)
        {
            lbEvents.Items.Add(string.Format("MotorControl {0} attached!",
                                    e.Device.SerialNumber.ToString()));
        }

        //Detach event handler. Display serial number of detached MotorControl phidget
        void motoControl_Detach(object sender, DetachEventArgs e)
        {
            lbEvents.Items.Add(string.Format("MotorControl {0} detached!",
                                    e.Device.SerialNumber.ToString()));
        }

        //Error event handler...Display the error description to the console
        void motoControl_Error(object sender, ErrorEventArgs e)
        {
            lbEvents.Items.Add(e.Description);
        }

        //Current change event handler. Display the index and the new current value to 
        //the console
        void motoControl_CurrentChange(object sender, CurrentChangeEventArgs e)
        {
            lbEvents.Items.Add(string.Format("Current Index {0} Current {1}", e.Index, e.Current));
        }

        //Input change event handler. Dislay the index and new input value to console
        void motoControl_InputChange(object sender, InputChangeEventArgs e)
        {
            lbEvents.Items.Add(string.Format("Input Index {0} Value {1}", e.Index, e.Value));
        }

        //Velocity change event handler. Display the motor index and the current 
        //velocity value to the console.
        void motoControl_VelocityChange(object sender, VelocityChangeEventArgs e)
        {
            lbEvents.Items.Add(string.Format("Index {0} Velocity {1}", e.Index, e.Velocity));
            txtMotor1Speed.Text = e.Velocity.ToString();
        }

        #endregion

        private void btnLeft_Click(object sender, EventArgs e)
        {
            // TODO determine which motor is on the right
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            // TODO determine which motor is on the left
        }
    }
}
