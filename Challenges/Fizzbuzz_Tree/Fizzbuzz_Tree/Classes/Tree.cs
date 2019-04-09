using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Fizzbuzz_Tree.Classes;

namespace Fizzbuzz_Tree.Classes
{
    public class Tree
    {
        public Node<object> Root { get; set; }
        public Node<object> Current { get; set; }

        /// <summary>
        /// Creates a new Binary Search Tree with new Node Root instatiation
        /// </summary>
        /// <param name="node">New node</param>
        public Tree(Node<object> node)
        {
            Root = node;
            Current = node;
            Current.LChild = null;
            Current.RChild = null;
        }

        /// <summary>
        /// Creates a new Binary Search Tree without Root Node
        /// </summary>
        public Tree()
        {

        }
    }
}
