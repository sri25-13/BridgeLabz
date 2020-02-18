// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Nodes.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// 
    /// </summary>
   public class Node
    {
        public Object data;
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="i">The i.</param>
        public Node(Object i)
        {
            this.data = i;
            this.next = null;
        }
    }
}