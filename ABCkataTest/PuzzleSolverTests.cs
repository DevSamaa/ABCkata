using System;
using ABCkata;
using Xunit;

namespace ABCkataTest
{
    public class PuzzleSolverTests
    {
        [Fact]
        public void CanWordBeSpelled_GivenBear_ShouldReturnTrue()
        {
            //arrange (test data)
            string incomingWord = "BEAR";

            var firstBlockCreator = new BlockCreator();
            var firstPile = firstBlockCreator.CreateBlocks();

            var testInstance = new PuzzleSolver();

            //action (do some work)
            bool isItSpellable = testInstance.CanWordBeSpelled(incomingWord, firstPile);

            //assert - check that the result of your action is that what you expected
            Assert.True(isItSpellable);
        }

        [Fact]
        public void CanWordBeSpelled_GivenSAMAA_ShouldReturnFalse()
        {
            //arrange (test data)
            string incomingWord = "SAMAA";

            //action (do some work)

            var firstBlockCreator = new BlockCreator();
            var firstPile = firstBlockCreator.CreateBlocks();

            var testInstance = new PuzzleSolver();
            bool isItSpellable = testInstance.CanWordBeSpelled(incomingWord, firstPile);

            //assert - check that the result of your action is that what you expected
            Assert.False(isItSpellable);
        }


    }
}
