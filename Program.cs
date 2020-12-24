using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] exampleArray = new int[] { 65, 23, 1, 0, 34, 26, 223, 92 };

            Console.Write("Before sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            BubbleSort.Sort(exampleArray);

            Console.Write("After sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
