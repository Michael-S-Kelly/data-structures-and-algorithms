using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedList_TDD
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestCreateLLSeven()
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
        public void TestInsertTwo()
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
        
        [Fact]
        public void TestAppendFour()
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
        
        [Fact]
        public void CanInsertThreeBeforeSeven()
        {
            //Arrange
            Node node1 = new Node(7);
            Node node2 = new Node(2);
            Node node3 = new Node(4);
            Node node4 = new Node(3);
            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2);
            list.Append(node3);
            list.InsertBefore(node4, node1);
            //Act
            bool check = list.Includes(3);
            //Assert
            Assert.True(check);
        }

        [Fact]
        public void CanInsertNineAfterSeven()
        {
            //Arrange
            Node node1 = new Node(7);
            Node node2 = new Node(2);
            Node node3 = new Node(4);
            Node node4 = new Node(9);
            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2);
            list.Append(node3);
            list.InsertBefore(node4, node1);
            //Act
            bool check = list.Includes(9);
            //Assert
            Assert.True(check);
        }

        [Fact]
        public void ValueAtIndexTwoIsSeven()
        {
            //Arrange
            Node node2 = new Node(2);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node3 = new Node(4);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2);
            list.Append(node3);
            list.InsertBefore(node4, node1);
            list.InsertBefore(node5, node1);
            //Act
            int check = list.ValueAtIndex(2);
            //Assert
            Assert.Equal(7, check);
        }


    }
}
