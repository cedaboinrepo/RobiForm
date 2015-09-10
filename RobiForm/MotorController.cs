using Phidgets;
using Phidgets.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobiForm
{
    internal class MotorController
    {
        private static MotorControl _motorControl;
        private static Motor _leftmotor;
        private static Motor _rightmotor;

        public MotorController()
        {
            _motorControl = new MotorControl();
            _motorControl.open();

            _leftmotor = new Motor();
            _leftmotor.index = 0;
            _leftmotor.MotorSide = Side.Left;
            _leftmotor.Location = MotorControllerLocation.Front;

            _rightmotor = new Motor();
            _rightmotor.index = 1;
            _rightmotor.MotorSide = Side.Right;
            _rightmotor.Location = MotorControllerLocation.Front;
        }

        public void CloseController()
        {
            _motorControl.close();
            _motorControl = null;
        }

        public MotorControl Controller
        {
            get { return _motorControl; }
        }

        public Motor LeftMotor
        {
            get { return _leftmotor; }
            set { _leftmotor = value; }
        }

        public Motor RightMotor
        {
            get { return _rightmotor; }
            set { _leftmotor = value; }
        }

        public bool IsAttached
        {
            get { return _motorControl.Attached; }
        }

        public async Task SetControllerMotorsSpeed(Side motorSide, double speed)
        {
            var motorOperations = new List<Task>();

            switch (motorSide)
            {
                case Side.Left:
                    motorOperations.Add(ControlMotorSpeed(0, -1 * speed));
                    break;
                case Side.Right:
                    motorOperations.Add(ControlMotorSpeed(1, 1 * speed));
                    break;
                case Side.Both:
                    motorOperations.Add(ControlMotorSpeed(0, -1 * speed));
                    motorOperations.Add(ControlMotorSpeed(1, 1 * speed));
                    break;
            }

            await Task.WhenAll(motorOperations);
        }

        public async Task SetControllerMotorsAceleration(Side motorSide, double acceleration)
        {
            var motorOperations = new List<Task>();

            switch (motorSide)
            {
                case Side.Left:
                    motorOperations.Add(ControlMotorAcceleration(0, acceleration));
                    break;
                case Side.Right:
                    motorOperations.Add(ControlMotorAcceleration(1, acceleration));
                    break;
                case Side.Both:
                    motorOperations.Add(ControlMotorAcceleration(0, acceleration));
                    motorOperations.Add(ControlMotorAcceleration(1, acceleration));
                    break;
            }

            await Task.WhenAll(motorOperations);
        }

        private Task ControlMotorSpeed(int index, double speed)
        {
            return Task.Run(() =>
            {
                _motorControl.motors[index].Velocity = speed;
            });
        }

        private Task ControlMotorAcceleration(int index, double acceleration)
        {
            return Task.Run(() =>
            {
                _motorControl.motors[index].Acceleration = acceleration;
            });
        }
    }
}
