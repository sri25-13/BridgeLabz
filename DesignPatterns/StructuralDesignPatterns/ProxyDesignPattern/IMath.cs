// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMath.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    /// <summary>
    /// interface math
    /// </summary>
    public interface IMath
    {
        /// <summary>
        /// Adding the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Adding(int x, int y);

        /// <summary>
        /// Subtracting the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public int Subtracting(int x, int y);
    }
}
