using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] searchArray = { 4, 8, 15, 16, 23, 42 };
            int searchNum = 15;
            int result = SearchArray(searchArray, searchNum);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int SearchArray(int[] searchArray, int searchNum)
        {
            int start = 0;
            int end = searchArray.Length;
            int searchIndex = (start + end) / 2;

            while (start <= end)
            {
                if (searchArray[searchIndex] == searchNum)
                {
                    return searchArray[searchIndex];
                }

                if (searchArray[searchIndex] > searchNum)
                {
                    end = searchNum;
                }

                if (searchArray[searchIndex] < searchNum)
                {
                    start = searchNum;
                }
            }



            return -1;
        }
    }
}
