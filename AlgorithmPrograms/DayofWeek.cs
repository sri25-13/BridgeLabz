// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DayofWeek.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for printing day of the week
    /// </summary>
    public class DayofWeek
    {
        /// <summary>
        /// Days the week method.
        /// </summary>
        public static void DayWeekMethod()
        {
            Console.WriteLine("enter the date");
            int d = Utility.ReadInt();
            Console.WriteLine("enter the month");
            int m = Utility.ReadInt();
            Console.WriteLine("enter the year");
            int y = Utility.ReadInt();
            int y0 = (y - (14 - m)) / 12;
            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
            int m0 = m + (12 * ((14 - m) / 12)) - 2;
            int d0 = (d + x + ((31 * m0) / 12)) % 7;
            Console.WriteLine("day is" + d0);
        }
    }
}