using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("wow", true)]
        [InlineData("rotator", true)]
        [InlineData("deed", true)]
        [InlineData("dog", false)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            var ws = new WordSmith();

            var actual = ws.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }






        
    }
}
