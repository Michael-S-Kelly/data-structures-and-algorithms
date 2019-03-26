using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class SLinkedList
    {
        #region Getters and Setters
        /// <summary>
        /// Assigns Head to the first node
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Is a reference to allow transversing the Linked List
        /// </summary>
        public Node Current { get; set; }
        #endregion
        
        #region Single Linked List
        /// <summary>
        /// Required at the creation of a Linked List.  Adds a node assigned to Head.
        /// </summary>
        /// <param name="node">This node will become the head</param>
        public SLinkedList(Node node)
        {
            Head = node;
            Current = node;
        }
        #endregion
        
        #region Insert a Node at Begining (new Head)
        /// <summary>
        /// This method inserts a node into the Linked List
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void Insert(Node node)
        {
            //Node node = new Node(data);
            Current = Head;
            node.Next = Head;
            Head = node;
            Current = Head;
        }
        #endregion

        #region List the Data in Linked List
        /// <summary>
        /// This method prints out a list of integers that are in the Linked List
        /// </summary>
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Data} =>");
                Current = Current.Next;
            }
            Console.Write($"{Current.Data} => Null");
        }
        #endregion

        #region Insert a Node at the End
        /// <summary>
        /// Appends a new node to the end of the Linked List
        /// </summary>
        /// <param name="newNode">the node to be added</param>
        public void Append(Node node)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = node;
        }
        #endregion

        #region Insert before Target Node
        /// <summary>
        /// Inserts a new node int thte list before a given node
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        /// <param name="targetNode">The node that will follow the newly added node</param>
        public void InsertBefore(Node newNode, Node targetNode)
        {
            Current = Head;
            if (Head.Data == targetNode.Data)
            {
                Insert(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Data == targetNode.Data)
                {
                    newNode.Next = targetNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
        #endregion

        #region Insert after Target Node
        /// <summary>
        /// Inserts a new node into the list after a given node
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        /// <param name="targetNode">The node before the newly added node</param>
        public void InsertAfter(Node newNode, Node targetNode)
        {
            while (Current.Next != null)
            {
                if (Current.Data == targetNode.Data)
                {
                    newNode.Next = targetNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
        #endregion

        #region Checks Linked List for Data
        /// <summary>
        /// This method checks to see if a praticular integer is in the Linked list
        /// </summary>
        /// <param name="data">Takes in an integer to see if it is in the Linked List</param>
        /// <returns>Returns true if it is in the linked list; returns false if it isn't</returns>
        public bool Includes(int data)
        {
            Current = Head;

            if (Current.Data == data)
            {
                return true;
            }

            while (Current.Next != null)
            {
                if (Current.Data == data)
                {
                    return true;
                }

                Current = Current.Next;
            }
            return false;
        }
        #endregion
    }
}
