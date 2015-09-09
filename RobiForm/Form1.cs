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
        static MotorController motorControl;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnSpeed_Click(object sender, EventArgs e)
        {
            await motorControl.SetControllerMotorsSpeed(Side.Both, 35.00);
        }

        private async void btnStop_Click(object sender, EventArgs e)
        {
            await motorControl.SetControllerMotorsSpeed(Side.Both, (0.00));
        }

        private async void btnReset_Click(object sender, EventArgs e)
        {
            txtMotor1Speed.Text = string.Empty;
            txtMotor2Speed.Text = string.Empty;
            txtMotor1Acc.Text = string.Empty;
            txtMotor2Acc.Text = string.Empty;

            if (motorControl.IsAttached)
            {
                await motorControl.SetControllerMotorsSpeed(Side.Both, 0.00);

                motorControl.CloseController();
            }

            tbSpeed.Value = 0;
            lbEvents.Items.Clear();

            btnSpeed.Enabled = false;
            btnStop.Enabled = false;
            btnLeft.Enabled = false;
            btnRight.Enabled = false;
            tbSpeed.Enabled = false;
        }

        private async void btnActivate_Click(object sender, EventArgs e)
        {
            await InitializeMotorController();

            if (motorControl.IsAttached)
            {
                btnSpeed.Enabled = true;
                btnStop.Enabled = true;
                btnLeft.Enabled = true;
                btnRight.Enabled = true;
                tbSpeed.Enabled = true;
            }
        }

        private async void tbSpeed_Scroll(object sender, EventArgs e)
        {
            await motorControl.SetControllerMotorsSpeed(Side.Both, tbSpeed.Value);
        }

        private async void btnLeft_Click(object sender, EventArgs e)
        {
            var motorOperations = new List<Task>();
            motorOperations.Add(motorControl.SetControllerMotorsSpeed(Side.Right, 1 * 30));
            motorOperations.Add(motorControl.SetControllerMotorsSpeed(Side.Left, 1 * 30));
            await Task.WhenAll(motorOperations);
        }

        private async void btnRight_Click(object sender, EventArgs e)
        {
            var motorOperations = new List<Task>();
            motorOperations.Add(motorControl.SetControllerMotorsSpeed(Side.Right, -1 * 30));
            motorOperations.Add(motorControl.SetControllerMotorsSpeed(Side.Left, -1 * 30));
            await Task.WhenAll(motorOperations);
        }

        #region helpers

        private async Task InitializeMotorController()
        {
            motorControl = new MotorController();

            //Hook the basic event handlers
            motorControl.Controller.Attach += new AttachEventHandler(motoControl_Attach);
            motorControl.Controller.Detach += new DetachEventHandler(motoControl_Detach);
            motorControl.Controller.Error += new ErrorEventHandler(motoControl_Error);

            //Hook the phidget specific event handlers
            motorControl.Controller.CurrentChange += new CurrentChangeEventHandler
                                                (motoControl_CurrentChange);
            motorControl.Controller.InputChange += new InputChangeEventHandler
                                                (motoControl_InputChange);
            motorControl.Controller.VelocityChange += new VelocityChangeEventHandler
                                                (motoControl_VelocityChange);

            //Wait for a MotorControl device to be attached
            lbEvents.Items.Add("Waiting for MotorControl to be attached....");
            motorControl.Controller.waitForAttachment();
            lbEvents.Items.Add("MotorControl attached....");

            await motorControl.SetControllerMotorsSpeed(Side.Both, 0.00);
            await motorControl.SetControllerMotorsAceleration(Side.Both, 100.00);

            txtMotor1Acc.Text = "100.00";
            txtMotor2Acc.Text = "100.00";
            if (motorControl.IsAttached)
            {
                SetMotorEnable(true);
            }
            else
            {
                SetMotorEnable(false);

                lbEvents.Items.Add("Motor contoller is not attached");
            }
        }

        private void SetMotorEnable(bool active)
        {
            SolidBrush brush = (active) ? new SolidBrush(Color.Green) : new SolidBrush(Color.Red);
            Graphics graphics = this.CreateGraphics();

            graphics.FillRectangle(brush, 220, 285, 10, 35);

            brush.Dispose();
            graphics.Dispose();
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
            switch (e.Index)
            {
                case 0:
                    motor1.BackColor = (e.Current > 0) ? Color.Green : Color.Red;
                    break;
                case 1:
                    motor2.BackColor = (e.Current > 0) ? Color.Green : Color.Red;
                    break;
            }
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
            if (e.Index == 0)
                txtMotor1Speed.Text = e.Velocity.ToString();
            if (e.Index == 1)
                txtMotor2Speed.Text = e.Velocity.ToString();
        }

        #endregion
    }
}
