using System;
using Xunit;
using Sorts.Classes;

namespace Sorts_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void MixedupArrayReturnsSortedArray()
        {
            //Arrange
            int[] unsortedArray = { 10, 5, 8, 3, 6, 2, 9, 7, 4, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act
            int[] results = InsertionSorts.InsertionSort(unsortedArray);
            //Assert
            Assert.Equal(results, sortedArray);
        }

        [Fact]
        public void SortedArrayReturnsSortedArray()
        {
            //Arrange
            int[] unsortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act
            int[] results = InsertionSorts.InsertionSort(unsortedArray);
            //Assert
            Assert.Equal(results, sortedArray);
        }

        [Fact]
        public void BackwardsSortedArrayReturnsSortedArray()
        {
            //Arrange
            int[] unsortedArray = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act
            int[] results = InsertionSorts.InsertionSort(unsortedArray);
            //Assert
            Assert.Equal(results, sortedArray);
        }

        [Fact]
        public void EmptyArrayReturnsEmptyArray()
        {
            //Arrange
            int[] unsortedArray = { };
            int[] sortedArray = { };
            //Act
            int[] results = InsertionSorts.InsertionSort(unsortedArray);
            //Assert
            Assert.Equal(results, sortedArray);
        }

        [Fact]
        public void SingleElementArrayReturnsSingleElementArray()
        {
            //Arrange
            int[] unsortedArray = { 9 };
            int[] sortedArray = { 9 };
            //Act
            int[] results = InsertionSorts.InsertionSort(unsortedArray);
            //Assert
            Assert.Equal(results, sortedArray);
        }
    }
}
