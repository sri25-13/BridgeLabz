// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for finding a BinaryNumber
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// Binaries the m.
        /// </summary>
        public static void BinaryM()
        {
            Console.WriteLine("enter a number");
            int n = Utility.ReadInt();
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