using System;
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
}
