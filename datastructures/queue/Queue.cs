// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// Queue is a generic
    /// </summary>
    /// <typeparam name="T">T is for generic</typeparam>
    public class Queue<T>
    {
        private Node front;
        private Node rear;
        private int length;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue{T}"/> class.
        /// </summary>
        public Queue()
        {
            this.front = null;
            this.rear = null;
            this.length = 0;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Console.WriteLine(length);
            return length;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            return length == 0;
        }

        /// <summary>
        /// Prints the queue.
        /// </summary>
        public void PrintQueue()
        {
            Node n = front;
            if (IsEmpty())
            {
                return;
            }
            else
            {
                while (n != null)
                {
                    Console.WriteLine(n.data);
                    n = n.next;
                }
            }
        }

        /// <summary>
        /// Firsts this instance.
        /// </summary>
        /// <returns></returns>
        public T First()
        {
            if (IsEmpty())
            {
                return (T)default;
            }
            else
            {
                return (T)front.data;
            }
        }

        /// <summary>
        /// Lasts this instance.
        /// </summary>
        /// <returns></returns>
        public T Last()
        {
            if (IsEmpty())
            {
                return (T)default;
            }
            else
            {
                return (T)rear.data;
            }
        }

        /// <summary>
        /// Enqueues the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Enqueue(T info)
        {
            Node node = new Node(info);
            if (IsEmpty())
            {
                front = node;
            }
            else
            {
                rear.next = node;
            }

            rear = node;
            length++;
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (IsEmpty())
            {
                return (T)default;
            }

            T result = (T)front.data;
            front = front.next;
            if (front == null)
            {
                rear = null;
            }

            length--;
            return result;
        }
    }
}