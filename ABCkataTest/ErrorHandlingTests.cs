using System;
using ABCkata;
using Xunit;

namespace ABCkataTest
{
    public class ErrorHandlingShould
    {
        [Fact]
        public void CheckIfOnlyLetters_GivenMonkey_ShouldReturnTrue()
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
        public void CheckIfOnlyLetters_Given_AMonkey_ShouldReturnFalse()
        {
            //arrange
            string incomingWord = "_A Monkey";

            //action
            var firstErrorHandler = new Errorhandling();
            bool checkingIfOnlyLetters = firstErrorHandler.CheckIfOnlyLetters(incomingWord);

            //assert
            Assert.False(checkingIfOnlyLetters);

        }


        //MemberData example -----------------------------------------------
        public static TheoryData<TestingData> CheckLetterData = new TheoryData<TestingData>
        {
            new TestingData(){incomingWord = "Monkey", expected = true},
            new TestingData(){incomingWord = "_A Monkey", expected = false},
            new TestingData(){incomingWord = "23423", expected = false},

        };

        [Theory]
        [MemberData(nameof(CheckLetterData))]

        public void CheckIfOnlyLetters_MemberData(TestingData data)
        {
            var InlineErrorHandler = new Errorhandling();
            var result = InlineErrorHandler.CheckIfOnlyLetters(data.incomingWord);

            Assert.Equal(data.expected, result);
        }

        //InlineData example -----------------------------------------------
        [Theory]
        [InlineData("Money", true)]
        [InlineData("_A Monkey", false)]
        [InlineData("23423", false)]
        public void CheckIfOnlyLetters_InlineData(string incomingWord, bool expected)
        {
            var InlineErrorHandler = new Errorhandling();
            var result = InlineErrorHandler.CheckIfOnlyLetters(incomingWord);

            Assert.Equal(expected, result);
        }
    }
}
