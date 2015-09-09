using Phidgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobiForm
{
    internal class Motor
    {
        public int index;

        public int MotorControllerId { get; set; }

        public MotorControllerLocation Location { get; set; }

        public Side MotorSide { get; set; }

        public MotorControlMotor MotorControl { get; set; }
    }
}
