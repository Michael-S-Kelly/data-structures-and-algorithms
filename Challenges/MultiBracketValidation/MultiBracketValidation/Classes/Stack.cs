using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        public void Push(char value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        public Node Pop()
        {
            Node temperary = Top;
            Top = Top.Next;
            temperary.Next = null;
            return temperary;
        }

        public Node Peek()
        {
            return Top;
        }
    }
}
