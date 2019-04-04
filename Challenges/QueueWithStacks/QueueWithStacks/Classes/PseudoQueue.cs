using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
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

        public void Enqueue(Stack<T> node, T value)
        {
            node.Push(value);
        }

        public void Dequeue(Stack<T> stack1)
        {
            Stack<T> stack2 = new Stack<T>();
            foreach (Node<T> node in stack1)
            {

            }


        }
    }
}
