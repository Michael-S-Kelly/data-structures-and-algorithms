using System;
using System.Collections.Generic;
using System.Text;
using Tree.Classes;

namespace Tree.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        public Queue(Node node)
        {
            Back = node;
            Front = node;
        }

        public void Enqueue(Node node)
        {
            node.Next = Back;
            Back = node;
        }

        public Node Dequeue()
        {
            Node temperary = Front;
            Front = Front.Next;
            temperary.Next = null;
            return temperary;
        }

        public int Peek()
        {
            return Front.Data;
        }
    }
}
