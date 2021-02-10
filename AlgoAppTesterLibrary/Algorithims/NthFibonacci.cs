using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppTesterLibrary
{
    public class NthFibonacci
    {
        public static int GetNthFib(int n)
        {
            int[] lastTwo = { 0, 1 };
            int counter = 2;

            while (counter <= n)
            {
                int nextFib = lastTwo[0] + lastTwo[1];
                lastTwo[0] = lastTwo[1];
                lastTwo[1] = nextFib;
                counter++;
            }
            return n > 0 ? lastTwo[1] : lastTwo[0];
        }
    }
}
