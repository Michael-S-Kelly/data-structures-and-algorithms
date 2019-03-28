using System;
using Xunit;

namespace LLMerge_TDD
{
    public class UnitTest1
    {
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
