using System;
using System.Collections.Generic;


namespace ABCkata
{

    public class PuzzleSolver
    {

        public bool CanWordBeSpelled(string incomingWord, List<Block> firstPile)
        {
            foreach (var letter in incomingWord)
            {
                //Console.WriteLine(letter);

                bool foundLetter = false;
                foreach (var block in firstPile)
                {
                    if (block.letter1 == letter.ToString() || block.letter2 == letter.ToString())
                    {
                        firstPile.Remove(block);
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
