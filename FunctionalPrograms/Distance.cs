// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
    
    /// <summary>
    /// class for finding distance from one point to origin 
    /// </summary>
   public class Distance
    {
        /// <summary>
        /// Distance this instance.
        /// </summary>
        public static void Dist()
        {
            Console.WriteLine("enter x value:");

            Console.WriteLine("enter y value:");
            int x = Utility.ReadInt();

            int y = Utility.ReadInt();
            int a = (x * x) + (y * y);
            double res = Math.Pow(a, 0.5);
            Console.WriteLine(res);
        }
    }
}