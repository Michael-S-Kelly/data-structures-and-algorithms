using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedList_TDD
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestSeven()
        {
            //Arrange
            Node node1 = new Node(7);
            SLinkedList list = new SLinkedList(node1);
            //list.Insert();
            //Act
            bool check = list.Includes(7);
            //Assert
            Assert.True(check);
        }
        
        
        [Fact]
        public void TestTwo()
        {
            //Arrange
            Node node1 = new Node(7);
            Node node2 = new Node(2);
            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2);
            //Act
            bool check = list.Includes(2);
            //Assert
            Assert.True(check);
        }
        /*
        [Fact]
        public void TestFour()
        {
            //Arrange
            Node node1 = new Node(7);
            Node node2 = new Node(2);
            Node node3 = new Node(4);
            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2);
            list.Append(node3);
            //Act
            bool check = list.Includes(4);
            //Assert
            Assert.True(check);
        }
        */
        /*

        [Fact]
        public void Can InsertAfterInMiddle()
        {
            int value = 0;
            SLinkedList<int> list = new SLinkedList<int>();
            list.Insert
        }
        */
    }
}
