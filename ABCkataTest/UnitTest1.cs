using System;
using ABCkata;
using Xunit;

namespace ABCkataTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanWordBeSpelled_GivenValidInput_ShouldReturnTrue()
        {
            //arrange (test data)
            string incomingWord = "BEAR";

            //action (do some work)

            var firstBlockCreator = new BlockCreator();
            var firstPile = firstBlockCreator.CreateBlocks();

            var testInstance = new PuzzleSolver();
            bool isItSpellable = testInstance.CanWordBeSpelled(incomingWord, firstPile);
         
            //assert - check that the result of your action is that what you expected
            Assert.True(isItSpellable);
        }

        [Fact]
        public void CanWordBeSpelled_GivenInvalidInput_ShouldReturnFalse()
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

        [Fact]
        public void CheckIfOnlyLetters_GivenCorrectInput_ShouldReturnTrue()
        {
            //arrange
            string incomingWord = "Monkey";

            //action
            var firstErrorHandler = new Errorhandling();
            bool checkingIfOnlyLetters = firstErrorHandler.CheckIfOnlyLetters(incomingWord);

            //assert
            Assert.True(checkingIfOnlyLetters);
        }

        [Fact]
        public void CheckIfOnlyLetters_GivenIncorrectInput_ShouldReturnFalse()
        {
            //arrange
            string incomingWord = "_A Monkey";

            //action
            var firstErrorHandler = new Errorhandling();
            bool checkingIfOnlyLetters = firstErrorHandler.CheckIfOnlyLetters(incomingWord);

            //assert
            Assert.False(checkingIfOnlyLetters);
        }

        [Theory]
        [InlineData("Money" , true)]
        [InlineData("_A Monkey", false)]
        [InlineData ("23423", false)]
        public void CheckIfOnlyLetters_InlineData(string incomingWord, bool expected)
        {
            var InlineErrorHandler = new Errorhandling();
            var result = InlineErrorHandler.CheckIfOnlyLetters(incomingWord);

            Assert.Equal(expected, result);
        }
    }
}
