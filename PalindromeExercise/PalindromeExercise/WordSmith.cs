using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {
        }
        public bool IsAPalindrome(string word)
        {

            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];

            }
            if (word == reversed)
            {
                return true;
            }
            else
            {
                return false;

            }
            
        }
    }
}
