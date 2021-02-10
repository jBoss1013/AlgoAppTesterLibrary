using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAppTesterLibrary.Test
{
    public class PalindromeCheckerTest
    {
        [Fact]
        public void PalindromeTest()
        {
            //boolean to set test conditions
            //dedault is set to false to create fail condition for test. 
            //once fail condition is set, change boolean to true to test
            bool PassCondition = false;

            if (PassCondition == true)
            {//passing test
                string palindrome = "racecar";

                bool expected = true;

                Assert.Equal(expected, PalindromeChecker.IsPalindrome(palindrome));
               
            }
            else
            {   //set inital test to false
                string notPalindrome = "reoferfoer";

                bool expected = true;

                Assert.Equal(expected, PalindromeChecker.IsPalindrome(notPalindrome));
            }
        }
    }
}
