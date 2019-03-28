﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LLMerge.Classes
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

        public Node(int data)
        {
            Data = data;
        }
    }
}
