// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// ----------------------------------------------------------------------------------------------------------
namespace AlgorithmPrograms
{
    using System;

    /// <summary>
    /// class for finding SquareRoot of non negative number
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// SQRTs this instance.
        /// </summary>
        public static void Squarert()
        {
            Console.WriteLine("enter a number");
            double c = Utility.ReadDouble();
            double epsilon = 1.0e-15;
            double t = c;
            if (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;
            }

            Console.WriteLine(t);
        }
    }
}
