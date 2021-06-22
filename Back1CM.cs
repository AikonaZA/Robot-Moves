using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    public class Back1CM : Instruction
    {
        RobotController theController = null;

        public Back1CM(RobotController theController)
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
            theController.Backward();
        }
        public void Undo()
        {
            theController.Forward();
        }
    }
}
