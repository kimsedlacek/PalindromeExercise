using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string palinWord)
        {
            string revChars = "";
            
            for (int i = palinWord.Length - 1; i>= 0; i--)
            {
                revChars += palinWord[i];
            }
            
            if (palinWord == revChars)
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
