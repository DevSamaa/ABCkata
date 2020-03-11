using System;
using System.Collections.Generic;

namespace ABCkata
{
    public class Block
    {
        public string letter1 { get; set; }
        public string letter2 { get; set; }

        // this is the default constructor
        public Block()
        {

        }

        //this overrides the default constructor
        public Block(string tempLetter1, string tempLetter2)
        {
            letter1 = tempLetter1;
            letter2 = tempLetter2;
        }
      
    }



    public class PuzzleSolver
    {
        //This is the pile made up of the blocks above.
        List<Block> Pile = new List<Block>{
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

        public void pilePrinter()
        {
            foreach (var item in Pile)
            {
                Console.WriteLine($"{item.letter1}, {item.letter2}");
            }
        } 


        public string getUserInput()
        {
            Console.WriteLine("Please type the word that you want to check");
            string word = Console.ReadLine().ToUpper();
            return word;
        }

       

        public bool canWordBeSpelled(string incomingWord)
        {
            foreach (var letter in incomingWord)
            {
                //Console.WriteLine(letter);

                bool foundLetter = false;
                foreach (var block in Pile)
                {
                    if (block.letter1 == letter.ToString() || block.letter2 == letter.ToString())
                    {
                        Pile.Remove(block);
                        foundLetter = true;
                        //Console.WriteLine("yes");
                        break;
                    }
                }

                if (foundLetter == false)
                {
                    return false;
                }
 
            }
            //this runs if all letters were found!
            return true;
        }


    }






}
