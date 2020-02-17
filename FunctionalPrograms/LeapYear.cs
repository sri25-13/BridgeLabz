// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for LeapYear
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Leaps this instance.
        /// </summary>
        public static void Leap()
        {
            Console.WriteLine("enter a year:");
            int n = Utility.ReadInt();
            if (n % 400 == 0)
            {
                Console.WriteLine(n + "is as leapyear");
            }
            else if (n % 4 == 0)
            {
                if (n % 100 != 0)
                {
                    Console.WriteLine(n + "is a leapyear");
                }
                else
                {
                    Console.WriteLine(n + "is not a aleapyear");
                }
            }
            else
            {
                Console.WriteLine(n + "is not a aleapyear");
            }
        }
    }
}