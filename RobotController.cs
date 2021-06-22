using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    public class RobotController
    {
        private int Position = 0;
        bool rRaised = false;

        public void Forward()
        {
            Position++;
            Console.WriteLine("Robot moved to position " + this.Position.ToString());
        }
        public void Backward()
        {
            if (Position > 0)
            {
                Position--;
                Console.WriteLine("Robot moved to position " + this.Position.ToString());
            }
            else
                Console.WriteLine("Robot cannot move anymore backwards :(");
        }
        public void Upward()
        {
            if (rRaised == false)
            {
                Console.WriteLine("Robot Was Raised.");
                rRaised = true;
            }
            else
                Console.WriteLine("Robot cannot be raised again :(");
        }
        public void Downward()
        {
            if (rRaised == true)
            {
                Console.WriteLine("Robot was Lowered.");
                rRaised = false;
            }
            else
                Console.WriteLine("Robot cannot be lowered again :(");
        }
    }
}
