// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    using System;

    /// <summary>
    /// class for Computer
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns></returns>
        public abstract string GetRAM();

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns></returns>
        public abstract string GetHDD();

        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns></returns>
        public abstract string GetCPU();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Computer" />
    class PC : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="PC"/> class.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public PC(string ram, string hdd, string cpu)
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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern.Computer" />
    class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

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
