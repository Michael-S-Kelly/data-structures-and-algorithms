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
    }
}
