using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LLMerge.Classes
{
    public class SLinkedList
    {
        /// <summary>
        /// Assigns Head to the first node
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Is a reference to allow transversing the Linked List
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Required at the creation of a Linked List.  Adds a node assigned to Head.
        /// </summary>
        /// <param name="node">This node will become the head</param>
        public SLinkedList(Node node)
        {
            Head = node;
            Current = node;
            Current.Next = null;
        }

        /// <summary>
        /// This method inserts a node into the Linked List
        /// </summary>
        /// <param name="node"></param>
        public void Insert(int data)
        {
            Node node = new Node(data);
            node.Next = Head;
            Head = node;
        }

        /// <summary>
        /// Determins the length of the Linked List in order to create the array in the LLToArray method
        /// </summary>
        /// <returns>length of the Linked List</returns>
        public int LLLength()
        {
            Current = Head;
            int indexLength = 0;

            while (Current.Next != null)
            {
                Current = Current.Next;
                indexLength++;
            }
            indexLength++;
            return indexLength;

        }

        /// <summary>
        /// This method prints out a list of integers that are in the Linked List
        /// </summary>
        public void Print(SLinkedList list)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Data} =>");
                Current = Current.Next;
            }
            Console.Write($"{Current.Data} => Null");
        }

        /// <summary>
        /// Given an index number, returns the value at the Node at that index number
        /// </summary>
        /// <param name="k">Target index number to get a value from</param>
        /// <returns>Get a value at a praticular index</returns>
        public int ValueAtIndex(int k)
        {
            int count = LLLength();
            Current = Head;

            if (k > count || k < 0)
            {
                Console.WriteLine("Sorry, The value that you specified is outside the limits");
                return -1;
            }

            while (Current.Next != null && k > 0)
            {
                Current = Current.Next;
                k--;
            }
            var current2 = Head;
            while (Current.Next != null)
            {

                Current = Current.Next;
                current2 = current2.Next;
            }
            return current2.Data;
        }
    }
}
