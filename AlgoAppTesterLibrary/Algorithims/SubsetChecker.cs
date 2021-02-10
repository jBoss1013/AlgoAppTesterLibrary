using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppTesterLibrary
{
    public class SubsetChecker
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int arrayPointer = 0;
            int seqPointer = 0;

            while (seqPointer < sequence.Count && arrayPointer < array.Count)
            {
                if (sequence[seqPointer] == array[arrayPointer])
                {
                    seqPointer++;
                }
                arrayPointer++;
            }
            return seqPointer == sequence.Count;
        }
    }
}
