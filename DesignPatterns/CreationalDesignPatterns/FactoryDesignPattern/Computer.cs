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
}