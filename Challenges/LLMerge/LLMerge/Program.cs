using System;
using System.Collections.Generic;
using System.Collections;
using LLMerge.Classes;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Merges two Linked Lists into one Linked List
        /// </summary>
        /// <param name="list1">First Linked List to be merged</param>
        /// <param name="list2">Second Linked List to be merged</param>
        /// <returns>Merged Linked List</returns>
        public static SLinkedList MergeTwoLL(SLinkedList list1, SLinkedList list2)
        {
            int length1 = list1.LLLength();
            int length2 = list2.LLLength();

            if (length2 > length1)
            {
                list2.Head = list2.Current;
                list1.Head = list1.Current;

                SLinkedList list = new SLinkedList(list2.Current);
                list.Insert(list1.Current.Data);

                list2.Current = list2.Current.Next;
                list1.Current = list1.Current.Next;


                while (list2.Current.Next != null && list1.Current.Next != null)
                {
                    list.Insert(list2.Current.Data);
                    list.Insert(list1.Current.Data);
                    list2.Current = list2.Current.Next;
                    list1.Current = list1.Current.Next;
                }
                if (list2.Current.Next != null)
                {
                    while (list2.Current.Next != null)
                    {
                        list.Insert(list2.Current.Data);
                        list2.Current = list2.Current.Next;
                    }
                }
                list.Insert(list2.Current.Data);
                list.Insert(list1.Current.Data);

                return list;
            }
            else
            {
                list1.Head = list1.Current;
                list2.Head = list2.Current;

                SLinkedList list = new SLinkedList(list1.Current);
                list.Insert(list1.Current.Data);

                list1.Current = list1.Current.Next;
                list2.Current = list2.Current.Next;


                while (list1.Current.Next != null && list2.Current.Next != null)
                {
                    list.Insert(list1.Current.Data);
                    list.Insert(list2.Current.Data);
                    list1.Current = list1.Current.Next;
                    list2.Current = list2.Current.Next;
                }
                if (list1.Current.Next != null)
                {
                    while (list1.Current.Next != null)
                    {
                        list.Insert(list1.Current.Data);
                        list1.Current = list1.Current.Next;
                    }
                }
                list.Insert(list1.Current.Data);
                list.Insert(list2.Current.Data);
                return list;
            }

        }

    }
}
