// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// class for finding roots of the QuadraticEquation
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Quads this instance.
        /// </summary>
        public static void Quad()
        {
            Console.WriteLine("enter a value");
            int a = Utility.ReadInt();
            Console.WriteLine("enter b value");
            int b = Utility.ReadInt();
            Console.WriteLine("enter c value");
            int c = Utility.ReadInt();
            int delta = (b * b) - (4 * a * c);
            double root1 = (-b + Math.Pow(delta, 0.5)) / (2 * a);
            double root2 = (-b - Math.Pow(delta, 0.5)) / (2 * a);
            Console.WriteLine(root1);
            Console.WriteLine(root2);
        }
    }
}
