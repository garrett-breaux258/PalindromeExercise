using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hey", false)]
        [InlineData("nun", true)]
        [InlineData("kayak", true)]
        [InlineData("hair", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            var test = new WordSmith();
            bool actual = test.IsAPalindrome(word);
            Assert.Equal(expected, actual);

        }
    }
}
