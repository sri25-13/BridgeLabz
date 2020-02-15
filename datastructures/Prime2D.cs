using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Prime2D
    {
        public static void Prime()
        {
            Console.WriteLine("enter the range to find prime numbers");
            int n = Utility.ReadInt();
            TwoDArray(n);
        }

        public static int[,] TwoDArray(int range)
        {
            int row = range / 100;
            int incr = 100;
            int prev = 0;
            int[,] Array = new int[row, 25];
            for (int i = 0; i < row; i++)
            {
                string[] s = FindNumber(prev, incr).Split(',');
                prev = incr;
                incr += 100;
                int[] arr = new int[s.Length - 1];
                for (int k = 0; k < s.Length - 1; k++)
                {
                    arr[k] = Convert.ToInt32(s[k]);
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j <= arr.Length)
                    {
                        Array[i, j] = arr[j];
                    }
                    else
                    {
                        Array[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return Array;
        }
      
        public static string FindNumber(int min, int num)
        {
            String s = "";
            for (int i = min; i < num; i++)
            {
                int count = 0;
                for (int j = i; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    s = s + i + ",";
                }
            }
            return s;

        }
    }
}

    

