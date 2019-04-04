using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue<T>
    {
        public Node<T> Front { get; set; }
        public Node<T> Rear { get; set; }

        public Queue(Node<T> node)
        {
            Front = node;
            Rear = node;
        }

        public void Enqueu(T value)
        {
            Node<T> node = new Node<T>(value);
            Rear.Next = node;
            Rear = node;
        }

        public Node<T> Dequeue()
        {
            Node<T> temperary = Front;
            Front = Front.Next;
            temperary.Next = null;

            return temperary;
        }

        public Node<T> Peek()
        {
            return Front;
        }

    }
}
