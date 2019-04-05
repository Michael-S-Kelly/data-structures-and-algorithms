using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        /// <summary>
        /// This method creates a new node with inputted data
        /// </summary>
        /// <param name="data">data input to give the value for the node</param>
        public Node(int data)
        {
            Data = data;
        }
    }
}
