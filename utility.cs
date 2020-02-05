using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public static String readString()
        {
            String s = Console.ReadLine();
            return s;

        }
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int[] readArray()
        {
            Console.WriteLine("enter the array size");
            int n = readInt();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = readInt();
            }
            return arr;

        }
        public static int[,] read2dArray(int m,int n)
        {
           
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = readInt();
                }
            }
            return arr;
        }
    }
}