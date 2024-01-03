using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("kayak", true)]
        [InlineData("goofy", false)]
        [InlineData("home", false)]

        public void WordTest(string palinWord, bool expected)
        { //Arrange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(palinWord);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
