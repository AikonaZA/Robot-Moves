using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    class Up : Instruction
    {
        RobotController theController = null;

        public Up(RobotController theController)
        {
            this.theController = theController;
        }
        public string Parameter
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public void Execute()
        {
            theController.Upward();
        }
        public void Undo()
        {
            theController.Downward();
        }
    }
}
