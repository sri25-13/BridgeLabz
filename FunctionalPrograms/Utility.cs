// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class Utility for reading all DataTypes
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
            string s = Console.ReadLine();
            return s;
        }

        /// <summary>
        /// Reads the Int.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Reads the double.
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Reads the array.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Read2ds the array.
        /// </summary>
        /// <param name="m">The m.</param>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static int[,] Read2dArray(int m, int n)
        {
            int[,] arr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = ReadInt();
                }
            }

            return arr;
        }
    }
}