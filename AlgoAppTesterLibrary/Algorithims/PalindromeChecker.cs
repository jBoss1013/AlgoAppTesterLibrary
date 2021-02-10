using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppTesterLibrary
{   /// <summary>
    /// Take 
    /// </summary>
    public class PalindromeChecker
    {
        public static bool IsPalindrome(string str)
        {
            int leftSide = 0;
            int rightSide = str.Length - 1;

            while (leftSide < rightSide)
            {
                if (str[leftSide] != str[rightSide])
                {
                    return false;
                }
                leftSide += 1;
                rightSide -= 1;
            }
            return true;
        }
    }
}
