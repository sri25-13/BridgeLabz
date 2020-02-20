// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dequeue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures.DoubleEndedQueue
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Dequeue<T>
    {
        NodeForDequeue front;
        NodeForDequeue rear;
        int length = 0;

        /// <summary>
        /// Adds the front.
        /// </summary>
        /// <param name="info">The information.</param>
        public void AddFront(T info)
        {
            NodeForDequeue newNode = new NodeForDequeue(info);
            if (IsEmpty())
            {
                rear = newNode;
                length++;
            }
            else
            {
                front.previous = newNode;
                length++;
            }

            newNode.next = front;
            front = newNode;
        }

        /// <summary>
        /// Deletes the front.
        /// </summary>
        /// <returns></returns>
        public T DeleteFront()
        {
            T res = (T)front.data;
            if (front.next == null)
            {
                rear = null;
            }
            else
            {
                front.next.previous = null;
                length--;
            }

            front = front.next;
            return res;
        }

        /// <summary>
        /// Adds the rear.
        /// </summary>
        /// <param name="info">The information.</param>
        public void AddRear(T info)
        {
            NodeForDequeue newNode = new NodeForDequeue(info);
            if (IsEmpty())
            {
                front = newNode;
                length++;
            }
            else
            {
                rear.next = newNode;
                newNode.previous = rear;
                length++;
            }

            rear = newNode;
        }

        /// <summary>
        /// Deletes the rear.
        /// </summary>
        /// <returns></returns>
        public T DeleteRear()
        {
            T element = (T)rear.data;
            if (front.next == null)
            {
                front = null;
                length--;
            }
            else
            {
                rear.previous.next = null;
            }

            rear = rear.previous;
            length--;
            return element;
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
        /// Prints the de queue.
        /// </summary>
        public void PrintDeQueue()
        {
            NodeForDequeue n = front;
            if (front == null)
            {
                Console.WriteLine("Dequeue is empty");
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
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return length;
        }

        /// <summary>
        /// Dequeues the ttest.
        /// </summary>
        public static void DequeueTtest()
        {
            Dequeue<string> deQueue = new Dequeue<string>();
            Console.WriteLine("enter number of elements");
            int num = Utility.ReadInt();
            for (int i = 0; i < num; i++)
            {
                deQueue.AddFront(Utility.ReadString());
            }

            Console.WriteLine("enter number of elements");
            int na = Utility.ReadInt();
            for (int i = 0; i < na; i++)
            {
                deQueue.AddRear(Utility.ReadString());
            }

            Console.WriteLine(deQueue.DeleteFront());
            Console.WriteLine(deQueue.DeleteRear());
            Console.WriteLine(deQueue.Size());
            deQueue.PrintDeQueue();
        }
    }
}