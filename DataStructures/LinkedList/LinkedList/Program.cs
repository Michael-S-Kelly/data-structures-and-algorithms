using System;
using System.Collections.Generic;
using LinkedList.Classes;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            instantiateList();
        }

        /// <summary>
        /// This method creates a new Linked list with 2 nodes.
        /// </summary>
        static void instantiateList()
        {
            Node node1 = new Node(7);
            Node node2 = new Node(9);

            SLinkedList numList = new SLinkedList(node1);
            numList.Append(node2);

            numList.Print();

            

        }
    }
}
