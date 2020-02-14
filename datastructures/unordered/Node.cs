using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Node
    {

        public Object data;
        public Node next;
        public Node(Object i)
        {
            this.data = i;
            this.next = null;
        }
    }
}

