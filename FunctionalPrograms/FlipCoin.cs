// --------------------------------------------------------------------------------------------------------------------
// <copyright file=FlipCoin.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for finding heads and tails percentage of FlipCoin
    /// </summary>
    public class FlipCoin
    {
        /// <summary>
        /// FlipCoin this instance.
        /// </summary>
        public static void Flip()
        {
            Console.WriteLine("enter the number of time to flip:");
            int n = Utility.ReadInt();
            double headco = 0;

            Random rnd = new Random();

            for (int i = 0; i <= n; i++)
            {
                if (rnd.NextDouble() < 0.5)
                {
                    headco++;
                }

                double a = (headco / n) * 100.0;
                Console.WriteLine("percentage of heads:" + a);
                Console.WriteLine("percentage of tails:" + (((n - headco) / n) * 100.0));
            }
        }
    }
}