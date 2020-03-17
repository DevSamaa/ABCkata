using System;
using System.Collections.Generic;

namespace ABCkata
{
    public class BlockCreator
    {
        //This is the pile made up of the blocks above.
        public List<Block> CreateBlocks()
        {
            return new List<Block>{
                new Block("B", "O"),
                new Block("X", "K"),
                new Block("D", "Q"),
                new Block("C", "P"),
                new Block("N", "A"),
                new Block("G", "T"),
                new Block("R", "E"),
                new Block("T", "G"),
                new Block("F", "S"),
                new Block("Q", "D"),
                new Block("J", "W"),
                new Block("H", "U"),
                new Block("V", "I"),
                new Block("A", "N"),
                new Block("O", "B"),
                new Block("E", "R"),
                new Block("F", "S"),
                new Block("L", "Y"),
                new Block("P", "C"),
                new Block("Z", "M")
            };
           
        }

        

        //public void pilePrinter()
        //{
        //    foreach (var item in Pile)
        //    {
        //        Console.WriteLine($"{item.letter1}, {item.letter2}");
        //    }
        //} 
    }
}
