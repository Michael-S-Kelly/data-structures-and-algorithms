using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class Node
    {
        public Node LChild { get; set; }
        public Node RChild { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
