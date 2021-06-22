using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Exit = false;
            string Instruction1 = null;
            string Instruction2 = null;
            string RollBack = null;
            Robot theRobot = new Robot();
            RobotController theController = new RobotController();
            Forward1CM forward1CM;
            Back1CM back1CM;
            theRobot.MoveForward = new Forward1CM(theController);
            theRobot.MoveBackWards = new Back1CM(theController);
            theRobot.Raise = new Up(theController);
            theRobot.Lower = new Down(theController);

            theRobot.Down();

            Sequence theSequence = new Sequence();
            theSequence.TheInstructions.Add(new Forward1CM(theController));
            theSequence.TheInstructions.Add(new Forward1CM(theController));
            theSequence.TheInstructions.Add(new Up(theController));
            theSequence.TheInstructions.Add(new Up(theController));
            theSequence.TheInstructions.Add(new Back1CM(theController));
            theRobot.Sequence = theSequence;

            while (Exit == false)
            {
                Console.WriteLine("Please choose an Instruction with the associated number:\n1 - Instruction 1\n2 - Instruction 2\n3 - Roll back last instruction");
                Console.ReadLine();

            }

            Console.ReadLine();
        }
    }
}

