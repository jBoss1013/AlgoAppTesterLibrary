using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace AlgoAppTesterLibrary.Test
{
    public class ElementsToEndTest
    {
        [Fact]
        public void ElementsToEndTests()
        {
            //boolean to set test conditions
            //dedault is set to false to create fail condition for test. 
            //once fail condition is set, change boolean to true to test
            bool PassCondition = true;

            if (PassCondition == true)
            {//Passing Test 
                List<int> array = new List<int>{1,7,2,7,3,7,4,7,5,7,6,7,7,7,8,7};

                int numToMove = 7;

                List<int> expectedStart = new List<int> { 1, 2, 3, 4, 5, 6, 8 };
                List<int> expectedEnd = new List<int> { 7, 7, 7, 7, 7, 7, 7, 7, 7 };

                List<int> testingOutput = ElementsToEnd.MoveElementToEnd(array, numToMove);
                
                

                //test to see if the start of the list array is the same 
                List<int> actualStart = testingOutput.GetRange(0, 7);
                actualStart.Sort();
                Assert.Equal(expectedStart, actualStart);

                //Test to see if the number meant to move has infact moved to the end
                List<int> actualEnd = testingOutput.GetRange(7, testingOutput.Count - 7);
                Assert.Equal(expectedEnd, actualEnd);
            }
            else
            {//to set inital test to false
                bool expected = true;
                bool actual = false;

                Assert.Equal(expected, actual);
                
            }
        }
    }
}

