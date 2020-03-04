// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Math.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    /// <summary>
    /// class for Math
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern.IMath" />
    public class Math : IMath
    {
        /// <summary>
        /// Adding the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Adding(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtracting the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Subtracting(int x, int y)
        {
            return x - y;
        }
    }
}
