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
            list.Insert(node2.Data);
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
            list.Insert(node2.Data);
            list.Append(node3.Data);
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
            list.Insert(node2.Data);
            list.Append(node3.Data);
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
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            //Act
            bool check = list.Includes(9);
            //Assert
            Assert.True(check);
        }

        [Fact]
        public void ValueAtIndexTwoIsFour()
        {
            //Arrange
            Node node1 = new Node(7);
            Node node2 = new Node(2);
            Node node3 = new Node(4);
            Node node4 = new Node(9);
            Node node5 = new Node(3);
            
            SLinkedList list7 = new SLinkedList(node1);
            list7.Insert(node2.Data);
            list7.Insert(node3.Data);
            list7.Insert(node4.Data);
            list7.Insert(node5.Data);
            //Act
            int check = list7.ValueAtIndex(2);
            //Assert
            Assert.Equal(4, check);
        }

        [Fact]
        public void InsertNode4BeforeNode1()
        {
            //Arrange
            Node node3 = new Node(4);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node2 = new Node(2);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            list.InsertAfter(node5, node1);
            //Act
            int check = list.ValueAtIndex(3);
            //Assert
            Assert.Equal(9, check);
        }

        [Fact]
        public void InsertNode5AfterNode1()
        {
            //Arrange
            Node node3 = new Node(4);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node2 = new Node(2);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            list.InsertAfter(node5, node1);
            //Act
            int check = list.ValueAtIndex(1);
            //Assert
            Assert.Equal(3, check);
        }

        [Fact]
        public void RequestedIndexOutsideLimit()
        {
            //Arrange
            Node node3 = new Node(4);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node2 = new Node(2);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            list.InsertAfter(node5, node1);
            //Act
            int check = list.ValueAtIndex(6);
            //Assert
            Assert.Equal(-1, check);
        }

        [Fact]
        public void IndexEqualToK()
        {
            //Arrange
            Node node3 = new Node(4);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node2 = new Node(2);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            list.InsertAfter(node5, node1);
            //Act
            int check = list.ValueAtIndex(4);
            //Assert
            Assert.Equal(2, check);
        }

        [Fact]
        public void WhereKIsNegative()
        {
            //Arrange
            Node node3 = new Node(4);
            Node node5 = new Node(3);
            Node node1 = new Node(7);
            Node node4 = new Node(9);
            Node node2 = new Node(2);

            SLinkedList list = new SLinkedList(node1);
            list.Insert(node2.Data);
            list.Append(node3.Data);
            list.InsertBefore(node4, node1);
            list.InsertAfter(node5, node1);
            //Act
            int check = list.ValueAtIndex(-1);
            //Assert
            Assert.Equal(-1, check);
        }

        [Fact]
        public void WhereLLIsSizeOf1()
        {
            //Arrange
            Node node1 = new Node(7);

            SLinkedList list = new SLinkedList(node1);

            //Act
            int check = list.ValueAtIndex(0);
            //Assert
            Assert.Equal(7, check);
        }
    }
}
