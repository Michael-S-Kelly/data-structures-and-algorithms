using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class SLinkedList
    {
        private Node head;

        /// <summary>
        /// This method inserts an integer into the Linked List
        /// </summary>
        /// <param name="data">integer to be inserted</param>
        /// <returns>integer inserted</returns>
        public int Insert(int data)
        {
            Node insertNewItem = new Node();

            insertNewItem.Data = data;
            insertNewItem.Next = head;

            head = insertNewItem;

            return data;
        }
        /// <summary>
        /// This method checks to see if a praticular integer is in the Linked list
        /// </summary>
        /// <param name="data">Takes in an integer to see if it is in the Linked List</param>
        /// <returns>Returns true if it is in the linked list; returns false if it isn't</returns>
        public bool Includes(int data)
        {
            Node address = head;
            while (address != null)
            {
                if (data == address.Data)
                {
                    return true;
                }  
            }
            return false;
        }
        /// <summary>
        /// This method prints out a list of integers that are in the Linked List
        /// </summary>
        public void Print()
        {
            Node address = head;
            while (address != null)
            {
                Console.WriteLine(address.Data);
                address = address.Next;
            }
        }
    }
}
