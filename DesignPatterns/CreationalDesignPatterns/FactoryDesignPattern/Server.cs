// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Server.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// class for server
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Computer" />
    public class Server : Computer
    {
        /// <summary>
        /// The ram
        /// </summary>
        private readonly string ram;

        /// <summary>
        /// The HDD
        /// </summary>
        private readonly string hdd;

        /// <summary>
        /// The cpu
        /// </summary>
        private readonly string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns></returns>
        public override string GetCPU()
        {
            return this.cpu;
        }

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns></returns>
        public override string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns></returns>
        public override string GetRAM()
        {
            return this.ram;
        }
    }
}