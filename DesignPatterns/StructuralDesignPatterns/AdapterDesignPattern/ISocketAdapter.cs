// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns
{
    /// <summary>
    /// Interface for SocketAdapter
    /// </summary>
   public interface ISocketAdapter
    {
        /// <summary>
        /// Get120volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get120volt();

        /// <summary>
        /// Get12volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get12volt();

        /// <summary>
        /// Get3volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get3volt();
    }
}
