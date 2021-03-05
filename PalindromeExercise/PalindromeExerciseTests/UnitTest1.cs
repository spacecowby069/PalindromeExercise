using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("rotator", true)]
        [InlineData("Abba", true)]
        [InlineData("Madam", true)]

        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var test = new WordSmith();

            //Act
            var actual = test.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
