using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using AlgoAppTesterLibrary


namespace AlgoAppTesterLibrary.Test
{
    public class FindThreeLargstNumTests
    {
        [Fact]
        public void FindThreeNumsTest()
        {
            //boolean to set test conditions
            //dedault is set to false to create fail condition for test. 
            //once fail condition is set, change boolean to true to test
            bool PassCondition = false;

            if (PassCondition == true)
            {//Proper test for FindThreeLargestNumbers

                int[] array = { -5, 0, 2, 203, -6, -100, 62, 45, 12, 7, 55 };

                int[] expectedPass = { 55, 62, 203 };

                int[] actual = FindThreeLargestNumbers.FIndTheThreeLargestNum(array);

                Assert.Equal(expectedPass, actual);

            }
            else
            { //to set inital test to false
                int[] array = { -5, 0, 2, 203, -6, -100, 62, 45, 12, 7, 55 };

                int[] expectedFail = { -5, -6, 0 };

                int[] actual = FindThreeLargestNumbers.FIndTheThreeLargestNum(array);

                Assert.Equal(expectedFail, actual);
            }

        }
    }
}
