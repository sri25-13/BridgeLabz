using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleEndedQueue
{
    class Dequeue<T>
    {

        NodeForDequeue front;
        NodeForDequeue rear;
        int length = 0;
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
        public bool IsEmpty()
        {
            return length == 0;
        }
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
        public int Size()
        {
            return length;
        }
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

