using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Fizzbuzz_Tree.Classes;

namespace Fizzbuzz_Tree.Classes
{
    public class Node<T>
    {
        public Node<T> LChild { get; set; }
        public Node<T> RChild { get; set; }
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
