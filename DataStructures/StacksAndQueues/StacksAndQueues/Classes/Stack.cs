using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack<T>
    {
        public Node<T> Top { get; set; }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        public Node<T> Pop()
        {
            Node<T> temperary = Top;
            Top = Top.Next;
            temperary.Next = null;
            return temperary;
        }

        public Node<T> Peek()
        {
            return Top;
        }
    }
}
