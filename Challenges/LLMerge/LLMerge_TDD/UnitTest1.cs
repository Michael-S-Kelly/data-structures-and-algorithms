using System;
using Xunit;
using static LLMerge.Program;
using LLMerge.Classes;
using System.Collections.Generic;

namespace LLMerge_TDD
{
    public class UnitTest1
    {
        [Fact]
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

            SLinkedList list3 = new SLinkedList(node10);

            list1.Insert(node7.Data);
            list1.Insert(node5.Data);
            list1.Insert(node3.Data);
            list1.Insert(node1.Data);

            list2.Insert(node8.Data);
            list2.Insert(node6.Data);
            list2.Insert(node4.Data);
            list2.Insert(node2.Data);

            list3.Insert(node9.Data);
            list3.Insert(node8.Data);
            list3.Insert(node7.Data);
            list3.Insert(node6.Data);
            list3.Insert(node5.Data);
            list3.Insert(node4.Data);
            list3.Insert(node3.Data);
            list3.Insert(node2.Data);
            list3.Insert(node1.Data);

            //Act
            SLinkedList check = MergeTwoLL(list1, list2);
            int check2 = check.ValueAtIndex(1);
            int check3 = list3.ValueAtIndex(1);
            //Assert
            Assert.Equal(check2, check3);
        }
    }
}
