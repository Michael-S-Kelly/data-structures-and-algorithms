using System;
using Xunit;
using static Tree.Program;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void InstantiatesANewTree()
        {
            //Arrange
            
            BinaryTree oneTree = new BinaryTree();

            //Act

            //Assert
            Assert.Null(oneTree.Root);
        }

        [Fact]
        public void InstantiatesANewTreeWithRoot()
        {
            //Arrange
            Node node1 = new Node(1);
            BinaryTree twoTree = new BinaryTree(node1);

            //Act

            //Assert
            Assert.Equal(1, twoTree.Root.Data);
        }

        [Fact]
        public void NewNodeInLeftChild()
        {
            //Arrange
            Node node1 = new Node(10);
            Node node2 = new Node(2);
            Node node3 = new Node(13);
            BinaryTree twoTree = new BinaryTree(node1);
            twoTree.Add(node2.Data);
            twoTree.Add(node3.Data);

            //Act
            var check1 = twoTree.Root.LChild.Data;
            var check2 = twoTree.Root.RChild.Data;
            //Assert
            Assert.Equal(2, check1);
            Assert.Equal(13, check2);
        }

        //[Fact]
        public void CheckBredthTransf()
        {
            //Arrange
            Node node1 = new Node(10);
            Node node2 = new Node(2);
            Node node3 = new Node(13);
            BinaryTree threeTree = new BinaryTree(node1);
            threeTree.Add(node2.Data);
            threeTree.Add(node3.Data);
            int[] check = new int[4];
            int[] test = new int[10];
            //Act
            check[0] = 10;
            check[1] = 2;
            check[2] = 13;
            test = threeTree.BreadthFirst(threeTree);
            //Assert
            Assert.Equal(check, test);
        }

        [Fact]
        public void CheckforMaxValue()
        {
            //Arrange
            Node node1 = new Node(10);
            Node node2 = new Node(13);
            Node node3 = new Node(2);
            BinaryTree fourTree = new BinaryTree(node1);
            fourTree.Insert(node2.Data);
            fourTree.Insert(node3.Data);

            //Act
            var maxValue = fourTree.FindMaximumValue(fourTree);
            //Assert
            Assert.Equal(13, maxValue);
        }
    }
}
