// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Prime2D.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for declaring primenumbers in 2d array
    /// </summary>
    public class Prime2D
    {
        /// <summary>
        /// Primes this instance.
        /// </summary>
        public static void Prime()
        {
            Console.WriteLine("enter the range to find prime numbers");
            int n = Utility.ReadInt();
            TwoDArray(n);
        }

        /// <summary>
        /// Twoes the d array.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <returns></returns>
        public static int[,] TwoDArray(int range)
        {
            int row = range / 100;
            int incr = 100;
            int prev = 0;
            int[,] array = new int[row, 25];
            for (int i = 0; i < row; i++)
            {
                string[] s =Utility.PrimeNumbers(prev, incr).Split(',');
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
                        array[i, j] = arr[j];
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            return array;
        }

        /// <summary>
        /// Finds the number.
        /// </summary>
        /// <param name="min">The minimum.</param>
        /// <param name="num">The number.</param>
        /// <returns></returns>
        /*public static string FindNumber(int min, int num)
        {
            string s = "";
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
        }*/
    }
}