// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HarmonicNum.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for finding nth HarmonicNum
    /// </summary>
    public class HarmonicNum
    {
        /// <summary>
        /// Harmonic this instance.
        /// </summary>
        public static void Harmonic()
        {
            Console.WriteLine("enter the number:");
            int n = Utility.ReadInt();

            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine(n + "harmonic value is:" + sum);
        }
    }
}