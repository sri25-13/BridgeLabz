using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class HashMap
    {
        Node[] array = new Node[11];
        int rem = 0;
        public void HashingFunction(int data)
        {
            Node node = new Node(data);
            rem = data % 11;
            Console.WriteLine("remainder is :" + rem);
            Node n = array[rem];
            if(array[rem]==null)
            {
                array[rem] = node;
            }
            else
            {
                while(n.next!=null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        public void Print()
        {
            Node n = array[rem];
            while(n!=null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
