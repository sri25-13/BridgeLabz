using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{

    class UnOrderedListMethods<T>
    {
        Node head;

        public void Add(T data)
        {
            Node nextNode = head;

            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (nextNode.next != null)
                {
                    nextNode = nextNode.next;
                }

                nextNode.next = node;

            }
        }
        public void Print()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }

        }
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
        public int Index(T index)
        {
            int position = 1;
            Node n = head;
            if (n != null && n.data.Equals(index))
            {
                n = n.next;
                return position;
            }
            else
            {
                while (!n.data.Equals(index) && n.next != null)
                {
                    n = n.next;
                    position++;
                }
                n = n.next;
            }
            return position;
        }
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
        public bool IsEmpty()
        {
            Node n = head;
            if (n != null)
            {
                return true;
            }
            return false;
        }
        public void Append(T info)
        {
            Node nextNode = head;
            Node node = new Node(info);
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (nextNode.next != null)
                {

                    nextNode = nextNode.next;
                }

                nextNode.next = node;

            }
        }
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
                    pos = pos + 1;
                }
                node.next = n.next;
                n.next = node;
            }
        }
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
            prev.data = null;
            return (T)data;
        }

    }
}