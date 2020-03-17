using System;
namespace ABCkata
{
    public class UserInput
    {

        public static string GetWordFromUser()
        {
            Console.WriteLine("Please type the word that you want to check or hit 'x' to exit");
            return Console.ReadLine().ToUpper();
        }
        
    }
}
