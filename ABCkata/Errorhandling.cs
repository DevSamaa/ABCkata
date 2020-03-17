using System;
using System.Text.RegularExpressions;

namespace ABCkata
{
    public class Errorhandling
    {
        public bool CheckIfOnlyLetters(string returnedWord)
        {
          
            if (Regex.IsMatch(returnedWord, @"^[a-zA-Z]+$"))
            {
                return true;
            }

            Console.WriteLine("You cannot use numbers or special characters");
            return false;
        }
    }
}
