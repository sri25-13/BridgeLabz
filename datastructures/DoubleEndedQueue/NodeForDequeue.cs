using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleEndedQueue
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class NodeForDequeue
    {
        public Object data;
        public NodeForDequeue previous;
        public NodeForDequeue next;
        public NodeForDequeue(Object i)
        {
            this.data = i;
            this.next = null;
        }
    }
}
