using System;
using Xunit;
using CodeChallenge03;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                    [Fact]
        public void KeyAtStartEven()
        {
            int[] binarySearchArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Assert.Equal(0, (int)Program.BinarySearch(binarySearchArray, 1));
        }
        [Fact]
        public void KeyAtEndOdd()
        {
            int[] binarySearchArray = { 16, 24, 36, 48, 52, 67, 82, 91, 98, 105, 111 };
            Assert.Equal(10, (int)Program.BinarySearch(binarySearchArray, 111));
        }
        [Fact]
        public void KeyInBetween()
        {
            int[] binarySearchArray = { 10, 30, 35, 40, 50, 55, 70, 75, 90, 110 };
            Assert.Equal(3, (int)Program.BinarySearch(binarySearchArray, 40));
        }
        [Fact]
        public void KeyNotInArray()
        {
            int[] binarySearchArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Assert.Equal(-1, (int)Program.BinarySearch(binarySearchArray, 21));
        }
    }
    }
}
