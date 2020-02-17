// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for PowerOfTwo
    /// </summary>
    public class PowerOfTwo
    {
        /// <summary>
        /// Power this instance.
        /// </summary>
        public static void Power()
        {
            Console.WriteLine("enter the number:");
            int n = Utility.ReadInt();
            int power = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^" + i + "=" + power);

                power = power * 2;
            }
        }
    }
}