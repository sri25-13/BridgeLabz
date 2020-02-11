using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;

        }
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int[] ReadArray()
        {
            Console.WriteLine("enter the array size");
            int n = ReadInt();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt();
            }
            return arr;

        }
        public static int[,] Read2dArray(int m,int n)
        {
           
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = ReadInt();
                }
            }
            return arr;
        }
    }
}