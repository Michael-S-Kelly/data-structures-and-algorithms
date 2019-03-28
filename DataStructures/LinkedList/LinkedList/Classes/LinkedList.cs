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

            if (Current.Data == data)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Find a value at a praticular index number
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
        /// Given an index number
        /// </summary>
        /// <param name="indexNum"></param>
        /// <returns></returns>
        public int ValueAtIndex(int indexNum)
        {
            int[] lLArray = LLToArray();
            if (indexNum < lLArray.Length)
            {
                int indexValue = lLArray[lLArray.Length - indexNum];
                return indexValue;
            }
            return -1;
        }
        #endregion

        #region Merge Two Linked Lists
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


    }
}
