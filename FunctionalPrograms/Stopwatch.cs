// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stopwatch.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// class for Stopwatch 
    /// </summary>
   public class Stopwatch
    {
        /// <summary>
        /// Stopwatches this instance.
        /// </summary>
        public static void StopwatchM()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(10);
            }

            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}