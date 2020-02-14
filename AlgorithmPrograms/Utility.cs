using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;

        }
        public static bool IsPalindrome(int n)
        {
            int temp = n;
            int sum = 0;
            while(temp!=0)
            {
                int r = temp % 10;
                sum = sum * 10 + r;
                temp = temp / 10;
            }
            if (sum == n)
            {
                return true;
            }
            else
                return false;

        }
       /* public static Boolean IsAnagram()
        {

        }*/
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public static int[] ReadArray()
        {
            Console.WriteLine("enter the array size");
            int num = ReadInt();
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = ReadInt();
            }
            return arr;

        }
    }
}