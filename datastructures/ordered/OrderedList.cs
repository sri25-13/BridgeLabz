using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructures
{
    class OrderedList
    {
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




            /* public static void Test()
             {
                 OrderedListMethods<int> ol = new OrderedListMethods<int>();
            Console.WriteLine("enter how numbers you want to add to the list :");
            int n = Utility.ReadInt();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the  number");
                ol.Add(Utility.ReadInt());
            }

            ol.Print();*/
            Console.WriteLine("enter the number to add or remove");
            int number = Utility.ReadInt();
            AddOrRemoveFromOrdered(number, ol);
            

        }
        static int AddOrRemoveFromOrdered(int data, OrderedListMethods<int> ol)
        {
            bool presence = ol.Search(data);
            Console.WriteLine(presence);
            if (presence==true)
            {
                ol.Remove(data);
                Console.WriteLine("removed");
                ol.Print();
            }
            else
            {
                ol.Add(data);
                Console.WriteLine("added");
                ol.Print();
            }
            return data;
        }
    }
}
    

