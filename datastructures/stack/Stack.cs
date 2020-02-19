// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for stack methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class Stack<T>
    {
        /// <summary>
        /// The top
        /// </summary>
        private Node top;
        private int length;

        /// <summary>
        /// Pushes the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Push(T info)
        {
            Node node = new Node(info);
            node.next = top;
            top = node;
            length++;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            T result = (T)top.data;
            top = top.next;
            length--;
            return result;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return length;
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            return (T)top.data;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        public void PrintStack()
        {
            Node n = top;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}