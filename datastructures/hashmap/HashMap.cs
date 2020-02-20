//--------------------------------------------------------------------------------------------------------------------
// <copyright file="HashMap.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for methods of HashMap
    /// </summary>
    public class HashMap
    {
        Node[] array = new Node[11];
        int rem = 0;

        /// <summary>
        /// hashing the data
        /// </summary>
        /// <param name="data"></param>
        public void HashingFunction(int data)
        {
            Node node = new Node(data);
            rem = data % 11;
            Console.WriteLine("remainder is :" + rem);
            Node n = array[rem];
            if (array[rem] == null)
            {
                array[rem] = node;
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
        /// prints the data
        /// </summary>
        public void Print()
        {
            Node n = array[rem];
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
    }
}
