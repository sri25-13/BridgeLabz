// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Operations.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Delegates
{
    using System;

    /// <summary>
    /// class for performing operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// declaring delegate
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public delegate void Operation(int x, int y);

        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static void Adding(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        /// <summary>
        /// Multiplies the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        /// <summary>
        /// Subtracts the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine(b - a);
        }
    }
}
