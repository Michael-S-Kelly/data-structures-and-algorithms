using System;
using Xunit;
using static BinarySearch.Program;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath()
        {
            int[] searchArray = { 4, 8, 15, 16, 23, 42 };
            int searchNum = 15;

            Assert.Equal(2, SearchArray(searchArray, searchNum));
        }

        [Fact]
        public void ExpectedFailure()
        {
            int[] searchArray = { 11, 22, 33, 44, 55, 66, 77 };
            int searchNum = 90;

            Assert.Equal(-1, SearchArray(searchArray, searchNum));
        }
    }
}
