// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NodeForDequeue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures.DoubleEndedQueue
{
    using System;

    /// <summary>
    /// class for Dequeue Node
    /// </summary>
    public class NodeForDequeue
    {
        public Object data;
        public NodeForDequeue previous;
        public NodeForDequeue next;

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeForDequeue"/> class.
        /// </summary>
        /// <param name="i">The i.</param>
        public NodeForDequeue(Object i)
        {
            this.data = i;
            this.next = null;
        }
    }
}
