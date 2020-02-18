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
        public static bool IsAnagram(int num1, int num2)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int count1 = 0;
            int count2 = 0;
            int c = 0;
            while (num1 != 0)
            {
                int n = num1 % 10;
                a[n]++;
                count1++;
                num1 /= 10;
            }

            while (num2 != 0)
            {
                int m = num2 % 10;
                b[m]++;
                count2++;
                num2 /= 10;
            }

            if (count1 != count2)
            {
                return false;
            }
            else
            {
                for (int k = 0; k < 10; k++)
                {
                    if (a[k] == b[k])
                    {
                        c++;
                    }
                }

                if (c == 10)
                {
                    return true;
                }
            }

            return false;
        }
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