using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class Node
    {
        public Node(int node)
        {
            head = node;
        }
        public Node head { get; set; }

        public Node Next { get; set; }
    }
}
