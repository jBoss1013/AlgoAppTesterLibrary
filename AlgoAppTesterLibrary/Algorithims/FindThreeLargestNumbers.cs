using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppTesterLibrary
{
    public class FindThreeLargestNumbers
    {
        public static int[] FIndTheThreeLargestNum(int[] array)
        {
            FindThreeLargestNumbers threeLgstNum = new FindThreeLargestNumbers();
            int[] threeLargest = { Int32.MinValue, Int32.MinValue, Int32.MinValue };

            foreach (int num in array)
            {
                threeLgstNum.UpdateLargestNum(threeLargest, num);
            }
            return threeLargest;
        }

        private void UpdateLargestNum(int[] threeLargest, int num)
        {
            if (num > threeLargest[2])
            {
                ShiftAndUdate(threeLargest, num, 2);
            }
            else if (num > threeLargest[1])
            {
                ShiftAndUdate(threeLargest, num, 1);
            }
            else if (num > threeLargest[0])
            {
                ShiftAndUdate(threeLargest, num, 0);
            }
        }

        private void ShiftAndUdate(int[] array, int num, int idx)
        {
            for (int i = 0; i <= idx; i++)
            {
                if (i == idx)
                {
                    array[i] = num;
                }
                else
                {
                    array[i] = array[i + 1];
                }
            }
        }

    }
}
