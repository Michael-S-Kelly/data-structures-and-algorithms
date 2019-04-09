using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Fizzbuzz_Tree.Classes;

namespace Fizzbuzz_Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node<object> node1 = new Node<object>(1);
            Tree tree = new Tree(node1);
            tree.Current = tree.Root;
            tree.Current.LChild = new Node<object>(2);
            tree.Current.RChild = new Node<object>(3);
            tree.Current.LChild.LChild = new Node<object>(4);
            tree.Current.LChild.RChild = new Node<object>(5);
            tree.Current.RChild.LChild = new Node<object>(6);
            tree.Current.RChild.RChild = new Node<object>(7);
            tree.Current.LChild.LChild.LChild = new Node<object>(8);
            tree.Current.LChild.LChild.RChild = new Node<object>(9);
            tree.Current.LChild.RChild.LChild = new Node<object>(10);
            tree.Current.LChild.RChild.RChild = new Node<object>(11);
            tree.Current.RChild.LChild.LChild = new Node<object>(12);
            tree.Current.RChild.LChild.RChild = new Node<object>(13);
            tree.Current.RChild.RChild.LChild = new Node<object>(14);
            tree.Current.RChild.RChild.RChild = new Node<object>(15);

            List<string> result = new List<string>();
            FizzBuzzTree(node1, result);
        }

        /// <summary>
        /// This method changes all numbers divisiable by 15 to "Fizzbuzz", 5 to "Buzz", and 3 to "Fizz".  Then returns all numbers to a list
        /// </summary>
        /// <param name="current">Root Node</param>
        /// <param name="result">List for Node data</param>
        /// <returns>Populated List</returns>
        public static List<string> FizzBuzzTree(Node<object> current, List<string> result)
        {
            
            if (Convert.ToInt32(current.Data) % 15 == 0)
            {
                current.Data = "Fizzbuzz";
                result.Add(current.Data.ToString());
            }
            else if (Convert.ToInt32(current.Data) % 5 == 0)
            {
                current.Data = "Buzz";
                result.Add(current.Data.ToString());
            }
            else if (Convert.ToInt32(current.Data) % 3 == 0)
            {
                current.Data = "Fizz";
                result.Add(current.Data.ToString());
            }
            else
            {
                result.Add(current.Data.ToString());
            }
            if (current.LChild != null)
            {
                FizzBuzzTree(current.LChild, result);
            }
            else if (current.RChild != null)
            {
                FizzBuzzTree(current.RChild, result);
            }
            return result;
        }
    }
}
