// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Volt.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns
{
    /// <summary>
    /// class for Volt
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volt
        /// </summary>
        public int volt;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        public Volt()
        {
            this.volt = 120;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Volt(int v)
        {
            this.volt = v;
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns></returns>
        public int GetVolt()
        {
            return this.volt;
        }
    }
}
