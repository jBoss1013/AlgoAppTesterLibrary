using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAppTesterLibrary
{
    public class ElementsToEnd
    {   

        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            ElementsToEnd move = new ElementsToEnd();
            int i = 0;
            int j = array.Count - 1;

            while (i < j)
            {
                while (i < j && array[j] == toMove) j--;
                if (array[i] == toMove) move.Swap(i, j, array);
                i++;
            }
            return array;
        }

        private void Swap(int i, int j, List<int> array)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}
