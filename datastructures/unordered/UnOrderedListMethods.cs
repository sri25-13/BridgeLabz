// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnOrderedListMethods.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for unorderedlist methods
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public class UnOrderedListMethods<T>
    {
        Node head;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Add(T data)
        {
            Node n = head;
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (n.next != null)
                {
                    n = n.next;
                }

                n.next = node;
            }
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
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node n = head;
            int count = 1;
            while (n.next != null)
            {
                count++;
                n = n.next;
            }

            return count;
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

                n = n.next;
            }

            return false;
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
        /// Appends the specified information.
        /// </summary>
        /// <param name="info">The information.</param>
        public void Append(T info)
        {
            Node n = head;
            Node node = new Node(info);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (n.next != null)
                {
                    n = n.next;
                }

                n.next = node;
            }
        }

        /// <summary>
        /// Removes the specified remove.
        /// </summary>
        /// <param name="remove">The remove.</param>
        public void Remove(T remove)
        {
            Node n = head;
            Node prev = null;
            if (n.data.Equals(remove))
            {
                head = head.next;
            }
            else
            {
                while (!n.data.Equals(remove))
                {
                    prev = n;
                    n = n.next;
                }

                prev.next = n.next;
                n = n.next;
            }
        }

        /// <summary>
        /// Inserts the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="info">The information.</param>
        public void Insert(int position, T info)
        {
            int pos = 1;
            Node n = head;
            Node node = new Node(info);
            if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                while (pos != position)
                {
                    n = n.next;
                    pos++;
                }

                node.next = n.next;
                n.next = node;
            }
        }

        /// <summary>
        /// Pops the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public T Pop(int position)
        {
            int pos = 1;
            Node n = head;
            Node prev = null;
            while (n != null && pos < position)
            {
                prev = n;
                n = n.next;
                pos++;
            }

            prev.next = n.next;
            return (T)n.data;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            Node n = head;
            Node prev = null;
            while (n.next != null)
            {
                prev = n;
                n = n.next;
            }

            T data = (T)n.data;
            prev.next = null;
            return (T)data;
        }
    }
}