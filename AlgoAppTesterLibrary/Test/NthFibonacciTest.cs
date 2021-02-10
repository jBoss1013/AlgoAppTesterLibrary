using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgoAppTesterLibrary.Test
{
    public class NthFibonacciTest
    {
        [Fact]
        public void NthFibonacciTests()
        {
            //boolean to set test conditions
            //dedault is set to false to create fail condition for test. 
            //once fail condition is set, change boolean to true to test
            bool PassCondition = false;
            //TODO check all test comments to ensure they are accurate
            if (PassCondition == true)
            {//Proper test for nth Fibonacci


                Assert.Equal(3,NthFibonacci.GetNthFib(4));

            }
            else
            { //to set inital test to false
                
                Assert.Equal(1,2);
            }
        }
    }
}
