using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Creates a new Binary Search Tree with new Node Root instatiation
        /// </summary>
        /// <param name="node">New node</param>
        public BinaryTree(Node node)
        {
            Root = node;
            Current = node;
            Current.LChild = null;
            Current.RChild = null;
        }

        /// <summary>
        /// Creates a new Binary Search Tree without Root Node
        /// </summary>
        public BinaryTree()
        {
            
        }

        /// <summary>
        /// Adds a new node to an existing Binary Search Tree
        /// </summary>
        /// <param name="data">Number that will go in the newly created node</param>
        public void Add(int data)
        {
            Node node = new Node(data);
            Current = Root;
            if (Current.Data > node.Data && Current.LChild == null)
            {
                Current.LChild = node;
                return;
            }
            if (Current.Data < node.Data && Current.RChild == null)
            {
                Current.RChild = node;
                return;
            }
            while (Current.LChild == null && Current.RChild == null)
            {
                if (Current.Data > node.Data && Current.LChild == null)
                {
                    Current.LChild = node;
                    return;
                }
                else if (Current.Data < node.Data && Current.RChild == null)
                {
                    Current.RChild = node;
                    return;
                }
                else if (Current.Data > node.Data && Current.LChild != null)
                {
                    Current = Current.LChild;
                }
                else if (Current.Data < node.Data && Current.RChild != null)
                {
                    Current = Current.LChild;
                }
            }
            if (Current.Data > node.Data && Current.LChild == null)
            {
                Current.LChild = node;
                return;
            }
            if (Current.Data < node.Data && Current.RChild == null)
            {
                Current.RChild = node;
                return;
            }
        }

        /// <summary>
        /// Adds a new node to an existing Binary Tree
        /// </summary>
        /// <param name="data">Number that will go in the newly created node</param>
        public void Insert(int data)
        {
            Node node = new Node(data);
            Current = Root;
            bool check = false;
            while (!check)
            {
                if (Current.LChild == null)
                {
                    Current.LChild = node;
                    check = true;
                    return;
                }
                if (Current.RChild == null)
                {
                    Current.RChild = node;
                    check = true;
                    return;
                }
                if (Current.LChild.LChild == null || Current.LChild.RChild == null)
                {
                    Current = Current.LChild;
                    check = false;
                }
                else if (Current.RChild.LChild == null || Current.RChild.RChild == null)
                {
                    Current = Current.RChild;
                    check = false;
                }
                else if (Current.LChild.RChild.RChild == null)
                {
                    Current = Current.LChild;
                    check = false;
                }
                else if (Current.RChild.RChild.RChild == null)
                {
                    Current = Current.RChild;
                    check = false;
                }
                else
                {
                    Current = Current.LChild;
                    check = false;
                }
            }
            
        }

        /// <summary>
        /// Transverses through a Binary Search Tree to see if it contains a praticular value
        /// </summary>
        /// <param name="value">The target value that is being searched for</param>
        /// <returns></returns>
        public bool Contains(int value)
        {
            if (Root.Data == value)
            {
                return true;
            }

            Current = Root;

            while (Current.LChild != null && Current.RChild != null)
            {
                if (Current.Data == value)
                {
                    return true;
                }
                else if (Current.Data > value && Current.LChild != null)
                {
                    Current = Current.LChild;
                }
                else if (Current.Data < value && Current.RChild != null)
                {
                    Current = Current.LChild;
                }
                else if (Current.Data > value && Current.LChild == null)
                {
                    return false;
                }
                else if (Current.Data < value && Current.RChild == null)
                {
                    return false;
                }
            }

            if (Current.Data == value)
            {
                return true;
            }

            return false;
        }



        public int[] BreadthFirst(BinaryTree binaryTree)
        {
            Current = Root;
            int[] results = new int[20];
            Queue queue = new Queue(binaryTree.Current);
            queue.Enqueue(binaryTree.Current);
            int i = 0;
            while (queue.Front != null)
            {
                binaryTree.Current = queue.Front;
                results[i] = queue.Front.Data;
                if (binaryTree.Current.LChild != null)
                {
                    queue.Enqueue(binaryTree.Current.LChild);
                }
                if (binaryTree.Current.RChild != null)
                {
                    queue.Enqueue(binaryTree.Current.RChild);
                }
                i++;
            }
            return results;
        }

        #region Code Challenge 18 Maximum Value in a Binary Tree
        /// <summary>
        /// Looks through the entire Binary Tree to find the Maximum Data Value.
        /// </summary>
        /// <param name="tree">Binary Tree to be searched</param>
        /// <returns>Maximum Data Value in the Binary Tree</returns>
        public int FindMaximumValue(BinaryTree tree)
        {
            Current = Root;
            int maxValue = Root.Data;

            maxValue = UpdateMaxValue(tree, maxValue);

            return maxValue;
        }

        /// <summary>
        /// Using a recursive Method cycles through all the nodes in the Binary Tree and updates the maxValue.
        /// </summary>
        /// <param name="tree">Binary Tree to be searched</param>
        /// <param name="maxValue">Last updated Maximum Data Value</param>
        /// <returns>Newly updated Maximum Data Value</returns>
        public int UpdateMaxValue(BinaryTree tree, int maxValue)
        {
            if (Current.Data > maxValue)
            {
                maxValue = Current.Data;
            }
            if (Current.LChild != null)
            {
                Current = Current.LChild;
                maxValue = UpdateMaxValue(tree, maxValue);

            }
            if (Current.RChild != null)
            {
                Current = Current.RChild;
                maxValue = UpdateMaxValue(tree, maxValue);
            }

            return maxValue;
        }
        #endregion
    }
}
