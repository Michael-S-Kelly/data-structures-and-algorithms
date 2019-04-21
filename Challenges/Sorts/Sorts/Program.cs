using System;
using Sorts.Classes;

namespace Sorts
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] unsortedArray = { 10, 5, 8, 3, 6, 2, 9, 7, 4, 1 };
            Console.WriteLine("Unsorted Array");
            printArray(unsortedArray);
            int[] sortedArray = InsertionSorts.InsertionSort(unsortedArray);
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            printArray(sortedArray);
            Console.ReadKey();
        }

        public static void printArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
