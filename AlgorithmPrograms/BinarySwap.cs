// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BinarySwap.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for swapping nibbles of a Binary
    /// </summary>
    public class BinarySwap
    {
        /// <summary>
        /// Swapping this instance.
        /// </summary>
        public static void Swapping()
        {
            Console.WriteLine("enter number for swapping");
            int x = Utility.ReadInt();
            BinaryConversion(x);
            int y = (x & 0x0F) << 4 | (x & 0xF0) >> 4;
            Console.WriteLine(y);
            BinaryConversion(y);
        }

        /// <summary>
        /// Binaries the conversion.
        /// </summary>
        /// <param name="n">The n.</param>
        public static void BinaryConversion(int n)
        {
            string s = "";
            while (n > 0)
            {
                int num = n % 2;
                n /= 2;
                s = num + s;
            }

            Console.WriteLine(s);
        }
    }
}