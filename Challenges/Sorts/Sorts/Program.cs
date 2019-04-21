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
            int[] sortedArray = InsertionSorts.InsertionSort(unsortedArray);
            Console.WriteLine("Inserted Array");
            foreach (int number in unsortedArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            foreach (int number in sortedArray)
            {
                Console.Write($"{number} ");
            }
            Console.ReadKey();
        }
    }
}
