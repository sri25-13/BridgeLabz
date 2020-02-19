// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// class for Calender
    /// </summary>
    public class Calender
    {
        /// <summary>
        /// Days the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        /// <returns></returns>
        public static int Day(int month, int day, int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0))
            {
                return true;
            }

            if (year % 400 == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Methods the calling.
        /// </summary>
        public static void MethodCalling()
        {
            Console.WriteLine("enter month number ");
            int month = Utility.ReadInt();
            Console.WriteLine("enter year number");
            int year = Utility.ReadInt();
            string[] months = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month == 2 && IsLeapYear(year))
            {
                days[month] = 29;
            }

            Console.WriteLine("   " + months[month] + " " + year);
            Console.WriteLine(" S  M Tu  W Th  F  S");
            Console.WriteLine("------------------------------------");
            int d = Day(month, 01, year);

            for (int i = 0; i < d; i++)
            {
                Console.Write("   ");
            }

            for (int i = 1; i <= days[month]; i++)
            {
                Console.Write(i + " ");
                if (((i + d) % 7 == 0) || (i == days[month]))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}