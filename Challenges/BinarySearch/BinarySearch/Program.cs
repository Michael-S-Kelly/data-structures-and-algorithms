using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] searchArray = { 4, 8, 15, 16, 23, 42 };
            //int[] searchArray = {11, 22, 33, 44, 55, 66, 77};
            int searchNum = 15;
            //int searchNum = 90;
            int result = SearchArray(searchArray, searchNum);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        /// <summary>
        /// Runs a binary search through an Array
        /// </summary>
        /// <param name="searchArray">Target Array to search through</param>
        /// <param name="searchNum">Target value to find in the Array</param>
        /// <returns>Index number</returns>
        public static int SearchArray(int[] searchArray, int searchNum)
        {
            int start = 0;
            int end = searchArray.Length;

            int searchIndex = (start + end) / 2;

            if (searchArray[searchIndex] == searchNum)
            {
                return searchIndex;
            }

            if (searchArray[searchIndex] > searchNum)
            {
                end = searchIndex;
            }

            if (searchArray[searchIndex] < searchNum)
            {
                start = searchIndex;
            }

            while (start != end)
            {
                searchIndex = (start + end) / 2;

                if (searchArray[searchIndex] == searchNum)
                {
                    return searchIndex;
                }

                if (searchArray[searchIndex] > searchNum)
                {
                    end = searchIndex -1;
                    //end--;
                }

                if (searchArray[searchIndex] < searchNum)
                {
                    start = searchIndex + 1;
                    //start++;
                }
            }



            return -1;
        }
    }
}
