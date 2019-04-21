using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts.Classes
{
    public class InsertionSorts
    {
        public static int[] InsertionSort(int[] numberArray)
        {
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numberArray[j - 1] > numberArray[j])
                    {
                        int greaterNumber = numberArray[j - 1];
                        numberArray[j - 1] = numberArray[j];
                        numberArray[j] = greaterNumber;
                    }
                }
            }

            return numberArray;
        }
    }
}
