using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ABCkata
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string returnedWord= String.Empty;
                bool checkingIfOnlyLetters = false;
                while (checkingIfOnlyLetters == false)
                {
                    returnedWord = UserInput.GetWordFromUser();
                    var ErrorhandlingInstance = new Errorhandling();
                    checkingIfOnlyLetters = ErrorhandlingInstance.CheckIfOnlyLetters(returnedWord);
                }
               

                if (returnedWord == "X")
                {
                    break;
                }
                var firstBlockCreator = new BlockCreator();
                var firstPile = firstBlockCreator.CreateBlocks();

                var firstPuzzleSolver = new PuzzleSolver();
                bool isItSpellable = firstPuzzleSolver.CanWordBeSpelled(returnedWord, firstPile);
                Console.WriteLine(isItSpellable);
            }
        }

       

       
    }
}
