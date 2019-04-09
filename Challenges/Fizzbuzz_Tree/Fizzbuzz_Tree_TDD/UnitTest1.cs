using System;
using Xunit;
using Fizzbuzz_Tree.Classes;
using System.Collections.Generic;

namespace Fizzbuzz_Tree_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPath1()
        {
            //arrange
            Node<object> node1 = new Node<object>(3);
            Tree tree = new Tree(node1);
            tree.Current = tree.Root;
            tree.Current.LChild = new Node<object>(2);
            tree.Current.RChild = new Node<object>(1);
            

            List<string> result = new List<string>();
            //act
            List<string> check = Fizzbuzz_Tree.Program.FizzBuzzTree(node1, result);
            //assert

            Assert.Equal("Fizz", check[0]);
            
        }

        [Fact]
        public void HappyPath2()
        {
            //arrange
            Node<object> node1 = new Node<object>(5);
            Tree tree = new Tree(node1);
            tree.Current = tree.Root;
            tree.Current.LChild = new Node<object>(7);
            tree.Current.RChild = new Node<object>(11);
            

            List<string> result = new List<string>();
            //act
            List<string> check = Fizzbuzz_Tree.Program.FizzBuzzTree(node1, result);
            //assert

            Assert.Equal("Buzz", check[0]);
        }

        [Fact]
        public void HappyPath3()
        {
            //arrange
            Node<object> node1 = new Node<object>(15);
            Tree tree = new Tree(node1);
            tree.Current = tree.Root;
            tree.Current.LChild = new Node<object>(37);
            tree.Current.RChild = new Node<object>(13);


            List<string> result = new List<string>();
            //act
            List<string> check = Fizzbuzz_Tree.Program.FizzBuzzTree(node1, result);
            //assert

            Assert.Equal("Fizzbuzz", check[0]);
        }
    }
}
