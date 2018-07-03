using System;
using SortingAlgorithms.Sorts;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * http://vnoi.info/wiki/algo/basic/sorting
             */

            var arr = new[] { 5, 2, 4, 6, 7, 3};

            /*
             * O(N^2)
             */
            //BubbleSort.Sort(arr);
            //SelectionSort.Sort(arr);
            //InsertionSort.Sort(arr);

            /*
             * O(NlogN)
             */
            //arr = MergeSort.Sort(arr, 0, arr.Length);
            QuickSort.Sort(arr, 0, arr.Length - 1);

            Console.WriteLine("Result:");

            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
