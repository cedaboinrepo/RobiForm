using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobiForm
{
    internal class RobotMotor
    {
        public int Id { get; set; }

        public int MotorControllerId { get; set; }

        public MotorControllerLocation Location { get; set; }

        public Side MotorSide { get; set; }
    }
}
