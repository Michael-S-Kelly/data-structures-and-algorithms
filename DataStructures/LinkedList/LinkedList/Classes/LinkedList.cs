using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
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
        }
        
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

            if (Current.Data == data)
            {
                return true;
            }

            return false;
        }
        /*
        /// <summary>
        /// Converts Linked List into an Array
        /// </summary>
        /// <returns>Array with data from Linked List</returns>
        public int[] LLToArray()
        {
            int indexLength = LLLength();
            int[] lLArray = new int[indexLength];
            int i = 0;
            Current = Head;

            while (Current.Next != null)
            {
                lLArray[i] = Current.Data;
                Current = Current.Next;
                i++;
            }
            lLArray[i] = Current.Data;
            return lLArray;
        }
        */
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
        
        /*
        public int[] MergeTwoLL(SLinkedList list1, SLinkedList list2)
        {
            int length1 = list1.LLLength();
            int length2 = list2.LLLength();

            if (length2 > length1)
            {
                list2.Head = list2.Current;
                list1.Head = list1.Current;

                SLinkedList list = new SLinkedList(list2.Current);
                list.Insert(list1.Current);

                list2.Current = list2.Current.Next;
                list1.Current = list1.Current.Next;


                while (list2.Current.Next != null && list1.Current.Next != null)
                {
                    list.Insert(list2.Current);
                    list.Insert(list1.Current);
                    list2.Current = list2.Current.Next;
                    list1.Current = list1.Current.Next;
                }

                list.Insert(list2.Current);
                list.Insert(list1.Current);
                int[] lLArray = new int[10];
                lLArray = ReturnLinkedListArray(list);
                return lLArray;
            }
            else
            {
                list1.Head = list1.Current;
                list2.Head = list2.Current;

                SLinkedList list = new SLinkedList(list1.Current);
                list.Insert(list1.Current);

                list1.Current = list1.Current.Next;
                list2.Current = list2.Current.Next;


                while (list1.Current.Next != null && list2.Current.Next != null)
                {
                    list.Insert(list1.Current);
                    list.Insert(list2.Current);
                    list1.Current = list1.Current.Next;
                    list2.Current = list2.Current.Next;
                }

                list.Insert(list1.Current);
                list.Insert(list2.Current);

                list.Insert(list2.Current);
                list.Insert(list1.Current);
                int[] lLArray = new int[10];
                lLArray = ReturnLinkedListArray(list);
                return lLArray;
            }
            
        }

        public int[] ReturnLinkedListArray(SLinkedList list)
        {
            int indexLength = LLLength();
            int[] lLArray = new int[indexLength];
            int i = 0;
            Current = Head;

            while (Current.Next != null)
            {
                lLArray[i] = Current.Data;
                Current = Current.Next;
                i++;
            }
            lLArray[i] = Current.Data;
            return lLArray;
        }
        */

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
        /// Appends a new node to the end of the Linked List
        /// </summary>
        /// <param name="newNode">the node to be added</param>
        public void Append(int data)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node node = new Node(data);
            Current.Next = node;
        }
        
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

                Insert(newNode.Data);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Data == targetNode.Data)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
        
        /// <summary>
        /// Inserts a new node into the list after a given node
        /// </summary>
        /// <param name="newNode">The node to be added</param>
        /// <param name="targetNode">The node before the newly added node</param>
        public void InsertAfter(Node newNode, Node targetNode)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Data == targetNode.Data)
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }

        }
        
    }
}
