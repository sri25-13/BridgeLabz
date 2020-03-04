// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FactoryDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    using System;

    /// <summary>
    /// class for implementing FactoryDesignPattern
    /// </summary>
    public class FactoryDesignPatternImplementation
    {
        /// <summary>
        /// Implementations this instance.
        /// </summary>
        public static void Implementation()
        {
            Console.WriteLine("enter your object type");
            string type = Utility.ReadString();
            Computer computer = ComputerFactory.GetComputer(type);
            Console.WriteLine("RAM of " + type + " is " + computer.GetRAM());
            Console.WriteLine("HDD of " + type + " is " + computer.GetHDD());
            Console.WriteLine("CPU of " + type + " is " + computer.GetCPU());
        }
    }
}
