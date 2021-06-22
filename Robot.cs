using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Moves
{
    class Robot
    {
        public Instruction MoveForward { get; set; }
        public Instruction MoveBackWards { get; set; }
        public Instruction Raise { get; set; }
        public Instruction Lower { get; set; }
        public Instruction Sequence { get; set; }
        //Calling the functions
        public void Forward() { MoveForward.Execute(); }
        public void Backwards() { MoveBackWards.Execute(); }
        public void Up() { Raise.Execute(); }
        public void Down() { Lower.Execute(); }
        public void Sequences() { Sequence.Execute(); }
        //The Undo Functions
        public void UndoForward() { MoveForward.Undo(); }
        public void UndoBackward() { MoveBackWards.Undo(); }
        public void UndoUp() { Raise.Undo(); }
        public void UndoDown() { Lower.Undo(); }
        public void UndoSequences() { Sequence.Undo(); }
    }
}
