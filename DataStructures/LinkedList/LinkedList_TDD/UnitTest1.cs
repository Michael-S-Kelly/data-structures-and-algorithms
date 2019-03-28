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

        //[Fact]
        public void MergeTwoLinkedLists()
        {
            //Arrange
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            Node node8 = new Node(8);
            Node node9 = new Node(9);
            Node node10 = new Node(10);

            SLinkedList list2 = new SLinkedList(node10);
            SLinkedList list1 = new SLinkedList(node9);

            list1.Insert(node7);
            list1.Insert(node5);
            list1.Insert(node3);
            list1.Insert(node1);

            list2.Insert(node8);
            list2.Insert(node6);
            list2.Insert(node4);
            list2.Insert(node2);

            //Act
            int[] check = MergeTwoLL(list1, list2);
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Assert
            Assert.Equal(test, check);
        }
    }
}
