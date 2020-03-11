using System;
using ABCkata;
using Xunit;

namespace ABCkataTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange test data
            string incomingWord = "BEAR";

            //action (do some work
            var testInstance = new PuzzleSolver();
            bool isItSpellable = testInstance.canWordBeSpelled(incomingWord);
            //PuzzleSolver testInstance = null;
            //string numberOfStudents = null;


            //assert - check that the result of your action is that what you expected
            Assert.True(isItSpellable);


        }
    }
}
