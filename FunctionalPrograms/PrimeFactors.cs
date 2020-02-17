// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for PrimeFactors
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// Primes this instance.
        /// </summary>
        public static void Prime()
        {
            Console.WriteLine("enter a number:");
            int n = Utility.ReadInt();
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }
        }
    }
}
