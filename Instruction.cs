using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    public interface Instruction
    {
        void Execute();
        void Undo();
        string Parameter { get; set; }
    }
}
