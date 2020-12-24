using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        /* This is the More function that compares the 2 input integers
        * and will sort the integer array in ascending order */
        private static bool More(int value1, int value2)
        {
            return value1 > value2;
        }

        /* This is the Sort algorithm that uses the More function to sort
         * the array input that this function receives */
        public static void Sort(int[] arrayArg)
        {
            int size = arrayArg.Length;

            int i, j, temp;
            /* This double nested loop will handle the input array and bubble sort
             * through until all elements are sorted.
             * Pseudocode...
             * 1. Loop through the full size of the array until the 2nd to last element
             * 2. For each loop through, take the first element and compare it to adjacent
             * element. Swap if more, else do nothing */
            for (i = 0; i < size - 1; i++)      // loops through the whole size of the array
            {
                for (j = 0; j < size - i - 1; j++)  // loops through the remaining unsorted part of the array
                {
                    if (More(arrayArg[j], arrayArg[j + 1]))
                    {
                        temp = arrayArg[j];
                        arrayArg[j] = arrayArg[j + 1];
                        arrayArg[j + 1] = temp;
                    }
                }
            }
        }
    }
}
