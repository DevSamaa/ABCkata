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


            //while (true)
            //{
            //    bool checkingIfOnlyLetters = false;
            //    string returnedWord = "";
            //    while (checkingIfOnlyLetters == false)
            //    {
            //        returnedWord = UserInput.GetWordFromUser();
            //        var ErrorhandlingInstance = new Errorhandling();
            //        checkingIfOnlyLetters = ErrorhandlingInstance.CheckIfOnlyLetters(returnedWord);
            //        if (checkingIfOnlyLetters == false)
            //        {
            //            Console.WriteLine("You cannot use numbers or special characters");
            //        }
            //    }

            //    if (returnedWord == "X" )
            //    {
            //        break;
            //    }
            //    var firstBlockCreator = new BlockCreator();
            //    var firstPile = firstBlockCreator.CreateBlocks();

            //    var firstPuzzleSolver = new PuzzleSolver();
            //    bool isItSpellable = firstPuzzleSolver.CanWordBeSpelled(returnedWord, firstPile);
            //    Console.WriteLine(isItSpellable);
            //}

            while (true)
            {
                string returnedWord= String.Empty;
                bool checkingIfOnlyLetters = false;
                //should this be its own class/function !??
                if (checkingIfOnlyLetters == false)
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
