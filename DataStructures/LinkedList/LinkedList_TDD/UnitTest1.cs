using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedList_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddTwo()
        {
            //Arrange
            SLinkedList list = new SLinkedList();
            //Act
            int check = list.Insert(2);
            //Assert
            Assert.Equal(2, check);
        }

        [Fact]
        public void TestAddFour()
        {
            //Arrange
            SLinkedList list = new SLinkedList();
            //Act
            int check = list.Insert(4);
            //Assert
            Assert.Equal(4, check);
        }
    }
}
