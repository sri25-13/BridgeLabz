// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SocketObjectAdapterImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns
{
    /// <summary>
    /// class for Implementing SocketObjectAdapter
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPatterns.ISocketAdapter" />
    public class SocketObjectAdapterImplementation : ISocketAdapter
    {
        /// <summary>
        /// The socket
        /// </summary>
       public readonly Socket socket = new Socket();

        /// <summary>
        /// Get120volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get120volt()
        {
            return this.socket.GetVolts();
        }

        /// <summary>
        /// Get12volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get12volt()
        {
            Volt volt = this.socket.GetVolts();
            return this.ConvertVolts(volt, 10);
        }

        /// <summary>
        /// Get3volts this instance.
        /// </summary>
        /// <returns></returns>
        public Volt Get3volt()
        {
            Volt volt = this.socket.GetVolts();
            return this.ConvertVolts(volt, 40);
        }

        /// <summary>
        /// Converts the volts.
        /// </summary>
        /// <param name="volt">The volt.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public Volt ConvertVolts(Volt volt, int i)
        {
            Volt volt1 = new Volt();
            return new Volt(volt1.GetVolt() / i);
        }
    }
}
