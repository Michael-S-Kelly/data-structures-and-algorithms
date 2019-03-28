using System;
using System.Collections.Generic;
using LLMerge.Classes;

namespace LLMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

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
    }
}
