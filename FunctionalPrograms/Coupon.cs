// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coupon.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for generating distinct coupon numbers
    /// </summary>
    public class Coupon
    {
        /// <summary>
        /// Coupons the number.
        /// </summary>
        public static void CouponNumber()
        {
            Console.WriteLine("enter the coupon no length u need:");
            int n = Utility.ReadInt();
            Console.WriteLine("enter how many values u need:");
            int n1 = Utility.ReadInt();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[n];

            Random rnd = new Random();
            for (int j = 0; j < n1; j++)
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[rnd.Next(chars.Length)];
                }

                Console.WriteLine(stringChars);
            }
        }
    }
}