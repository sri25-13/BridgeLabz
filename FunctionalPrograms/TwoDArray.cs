// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for printing TwoDArray
    /// </summary>
   public class TwoDArray
    {
        /// <summary>
        /// Array2ds this instance.
        /// </summary>
        public static void Array2d()
        {
            Console.WriteLine("enter the no of rows");
            int m = Utility.ReadInt();
            Console.WriteLine("enter no of columns");
            int n = Utility.ReadInt();
            Console.WriteLine("enter the array elements");
            int[,] arr = Utility.Read2dArray(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
