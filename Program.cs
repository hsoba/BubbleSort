using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BubbleSort
{
    class Program
    {
       static void Main(string[] args)
        {
            Stopwatch myTimer = new Stopwatch();

            int[] exampleArray = new int[] { 65, 23, 1, 0, 34, 26, 223, 92 };

            Console.Write("Before sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            myTimer.Start();
            BubbleSort.Sort(exampleArray);
            myTimer.Stop();

            Console.Write("After sorting: ");
            foreach (int element in exampleArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\nTime taken: " + myTimer.ElapsedTicks);
        }
    }
}
