using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    public class Forward1CM : Instruction
    {
        RobotController theController = null;

        public Forward1CM(RobotController theController)
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
            theController.Forward();
        }
        public void Undo()
        {
            theController.Backward();
        }
    }
}
