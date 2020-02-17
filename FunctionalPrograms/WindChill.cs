// --------------------------------------------------------------------------------------------------------------------
// <copyright file=WindChill.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for WindChill
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Winds this instance.
        /// </summary>
        public static void Wind()
        {
            Console.WriteLine("enter t value");
            double t = Utility.ReadInt();
            Console.WriteLine("enter v value");
            double v = Utility.ReadInt();
            if (t < 50 || (v > 3 && v < 120))
            {
                double w = 35.74 + (0.6215 * t) + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
                Console.WriteLine(w);
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
            }
        }
    }
}
