using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    class Sequence : Instruction
    {
        public List<Instruction> TheInstructions = new List<Instruction>();
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
            foreach (Instruction Current in TheInstructions)
            {
                Current.Execute();
            }
        }
        public void Undo()
        {
            for (int i = TheInstructions.Count - 1; i > 0; i--)
            {
                TheInstructions[i].Undo();
            }
        }
    }
}
