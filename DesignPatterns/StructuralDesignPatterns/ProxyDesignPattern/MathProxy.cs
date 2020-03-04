// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MathProxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern.IMath" />
    public class MathProxy : IMath
    {
        private Math math = new Math();

        /// <summary>
        /// Adding the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Adding(int x, int y)
        {
            return math.Adding(x, y);
        }

        /// <summary>
        /// Subtracting the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Subtracting(int x, int y)
        {
            return math.Subtracting(x, y);
        }
    }
}