// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeNumbers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for finding PrimeNumbers
    /// </summary>
    public class PrimeNumbers
    {
        /// <summary>
        /// Primes this instance.
        /// </summary>
        public static void Prime()
        {
            Console.Write("Enter The Start Number: ");
            int startNumber = Utility.ReadInt();
            Console.Write("Enter the End Number : ");
            int endNumber = Utility.ReadInt();
            for (int i = startNumber; i <= endNumber; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}