// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedListMethods.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for orderedlist methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OrderedListMethods<T>
    {
        Node head;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(int data)
        {
            Node n = head;
            Node node = new Node(data);
            if (head == null || (int)n.data > (int)node.data)
            {
                node.next = head;
                head = node;
            }
            else
            {
                while (n.next != null && (int)n.next.data < (int)node.data)
                {
                    n = n.next;
                }

                node.next = n.next;
                n.next = node;
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node n = head;
            int count = 1;
            while (n.next != null)
            {
                n = n.next;
                count++;
            }

            return count;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }

        /// <summary>
        /// Removes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int Remove(T data)
        {
            Node node = head.next;
            Node prev = null;
            if (head.data.Equals(data))
            {
                head = head.next;
                return (int)head.data;
            }
            else
            {
                while (!node.data.Equals(data))
                {
                    node = node.next;
                }

                int ret = (int)node.data;
                node = node.next;
                prev.next = node;
                return ret;
            }
        }

        /// <summary>
        /// Indexes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public int Index(T index)
        {
            int position = 1;
            Node n = head;
            if (n != null && n.data.Equals(index))
            {
                return position;
            }
            else
            {
                while (!n.data.Equals(index) && n.next != null)
                {
                    n = n.next;
                    position++;
                }
            }

            return position;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            Node n = head;
            if (n != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public bool Search(T data)
        {
            Node n = head;
            while (n != null)
            {
                if (n.data.Equals(data))
                {
                    return true;
                }
                else
                {
                    n = n.next;
                }
            }

            return false;
        }
    }
}