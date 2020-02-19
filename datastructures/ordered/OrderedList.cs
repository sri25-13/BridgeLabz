// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.IO;

    /// <summary>
    /// class for unorderedlist 
    /// </summary>
    public class OrderedList
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        public static void ReadFile()
        {
            OrderedListMethods<int> ol = new OrderedListMethods<int>();
            string[] lines = File.ReadAllLines(@"C:\Users\Bridgelabz\source\repos\orderedinput.txt");
            Console.WriteLine("data in input file");
            int[] num = new int[lines.Length];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(lines[i]);
                Console.WriteLine(num[i]);
                ol.Add(num[i]);
            }

            Console.WriteLine("size:" + ol.Size());
            Console.WriteLine("enter the number to add or remove");
            int number = Utility.ReadInt();
            AddOrRemoveFromOrdered(number, ol);
            ol.Print();
        }

        /// <summary>
        /// Adds the or remove from ordered.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="ol">The ol.</param>
        /// <returns></returns>
       public static int AddOrRemoveFromOrdered(int data, OrderedListMethods<int> ol)
        {
            bool presence = ol.Search(data);
            Console.WriteLine(presence);
            if (presence == true)
            {
                ol.Remove(data);
                Console.WriteLine("removed");
                return data;
            }
            else
            {
                ol.Add(data);
                Console.WriteLine("added");
            }

            return data;
        }
    }
}