using System;

namespace CodeChallenge03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binarySearchArray = { 2, 6, 8, 10, 15, 22, 64 };
            int keyNum = 8;
            int result = BinarySearch(binarySearchArray, keyNum);
            Console.WriteLine($"The numbers that we are searching in: [{string.Join(", ", binarySearchArray)}]");
            Console.WriteLine($"The number we are searching for: {keyNum}");
            if (result == -1)
            {
                Console.WriteLine($"Sorry, the key value was not found in the array: returned {result}");
            }
            else if (result > -1)
            {
                Console.WriteLine($"The key value was found in the array at index number: {result}.");
            }
            else
            {
                Console.WriteLine($"Sorry, something went wrong, please try again.");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] binarySearchArray, int keyNum)
        {
            decimal start = 0, end = binarySearchArray.Length - 1;
            decimal floatingNum = Math.Ceiling((decimal)binarySearchArray.Length / 2) - 1;
            while (true)
            {
                if (binarySearchArray[(int)floatingNum] == keyNum)
                {
                    return (int)floatingNum;
                }
                else if (floatingNum == start && floatingNum == end)
                {
                    return -1;
                }
                else if (keyNum < binarySearchArray[(int)floatingNum])
                {
                    end = (int)floatingNum;
                    floatingNum = Math.Floor(floatingNum / 2);
                }
                else if (keyNum > binarySearchArray[(int)floatingNum])
                {
                    start = (int)floatingNum;
                    floatingNum = Math.Ceiling((start + end) / 2);
                }
                else
                {
                    return -10;
                }
            }

        }

    }
}
