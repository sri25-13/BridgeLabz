using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class OrderedListMethods<T>
    {
        Node head;
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
        public int Size()
        {
            Node node = head;
            int ind = 1;
            while (node.next != null)
            {
                node = node.next;
                ind++;
            }
            return ind;
        }
        public void Print()
        {
            Node node = head;

            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            node = null;
        }
        public int Remove(T data)
        {
            Node node = head;
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
                    
                    prev = node;
                    node = node.next;
                }
                int ret = (int)node.data;
                node = node.next;
                prev.next = node;

                return ret;
            }
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
        public bool IsEmpty()
        {
            Node n = head;
            if (n != null)
            {
                return true;
            }
            return false;
        }
        public bool Search(T data)
        {
            Node node = head;
            if (head.data.Equals(data))
            {
                return true;
            }
            else
            {
                while (!node.next.data.Equals(data))
                {
                    node = node.next;
                    return true;
                }
                return false ;
            }
        }


    }
}
