using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAppTesterLibrary.Test
{
    public class SubsetCheckerTest
    {
        [Fact]
        public void SubsetChecktest()
        {
            //boolean to set test conditions
            //dedault is set to false to create fail condition for test. 
            //once fail condition is set, change boolean to true to test
            bool PassCondition = false;

            if (PassCondition == true)
            {//Passing test
                List<int> array = new List<int> { -3,-2,-1,0,1,2,3,};

                List<int> subset = new List<int> { -2, 0, 2, 3 };

                bool expected = true;

                Assert.Equal(expected, SubsetChecker.IsValidSubsequence(array,subset));

            }
            else
            {//inital fail test to set test to fail condition
                List<int> array = new List<int> { -3, -2, -1, 0, 1, 2, 3, };

                List<int> subset = new List<int> { -2,-3,1,0,2 };

                bool expected = true;

                Assert.Equal(expected, SubsetChecker.IsValidSubsequence(array, subset));
            }
        }

    }
}
