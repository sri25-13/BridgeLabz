// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MonthlyPay.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for MonthlyPay
    /// </summary>
    public class MonthlyPay
    {
        /// <summary>
        /// MonthlyPay this instance.
        /// </summary>
        public static void Month()
        {
            Console.WriteLine("enter loan amount");
            double loan = Utility.ReadDouble();
            Console.WriteLine("enter years");
            double years = Utility.ReadDouble();
            Console.WriteLine("enter interest");
            double interest = Utility.ReadDouble();
            double r = interest / (12 * 100);
            double n = 12 * years;
            Console.WriteLine(loan * r / (1 - Math.Pow(1 + r, -n)));
        }
    }
}