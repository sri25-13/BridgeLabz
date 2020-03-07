// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns
{
    /// <summary>
    /// class for Socket
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns></returns>
        public Volt GetVolts()
        {
            return new Volt();
        }
    }
}
