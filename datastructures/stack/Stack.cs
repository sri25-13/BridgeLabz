using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack<T>
    {
        private Node top;
        private int length;
        public void Push(T info)
        {
            Node node = new Node(info);
            node.next = top;
            top = node;
            length++;
        }
        public T Pop()
        {
            T result = (T)top.data;
            top = top.next;
            length--;
            return result;
        }
        public int Size()
        {
            return length;
        }
        public T Peek()
        {
            return (T)top.data;
        }
        public Boolean IsEmpty()
        {
            if (length == 0)
            {
                //Console.WriteLine("stack is empty");
                return true;
            }
            else
                return false;
        }
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
    

