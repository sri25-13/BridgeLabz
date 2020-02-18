// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindingNumber.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for finding a number
    /// </summary>
   public class FindingNumber
    {
        /// <summary>
        /// Findings the number.
        /// </summary>
        public static void FindingNum()
        {
            Console.WriteLine("enter the number");
            int n = Utility.ReadInt();
            int n1 = (int)Math.Pow(2, n);
            Console.WriteLine("Think of a number between 0 and" + (n1 - 1));
           Console.WriteLine("your number is" + Number(0, n1));
        }

        /// <summary>
        /// Numbers the specified low.
        /// </summary>
        /// <param name="low">The low.</param>
        /// <param name="high">The high.</param>
        /// <returns></returns>
        public static int Number(int low, int high)
        {
            string str1 = "yes";
            string str2 = "no";
            if ((high - low) == 1)
            {
                return low;
            }

            while (low <= high)
            {
                int mid = (low + high) / 2;
                Console.WriteLine("type yes or no if it is less than" + mid);
                string s = Utility.ReadString();
                if (s.Equals(str1))
                {
                    high = mid;
                    return Number(low, high);
                }
                else if (s.Equals(str2))
                {
                    low = mid;
                    return Number(low, high);
                }
                else if (high == mid)
                {
                    return mid;
                }
                else
                {
                    Console.WriteLine("INVALID INPUT");
                }
            }

            return low;
        }
    }
}