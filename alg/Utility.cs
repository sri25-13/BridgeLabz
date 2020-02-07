using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static String readString()
        {
            String s = Console.ReadLine();
            return s;

        }
        public static double readDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int readInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int[] readArray()
        {
            Console.WriteLine("enter the array size");
            int num = readInt();
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = readInt();
            }
            return arr;

        }
    }
}