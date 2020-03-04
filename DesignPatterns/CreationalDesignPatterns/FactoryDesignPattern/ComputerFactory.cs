// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.FactoryDesignPattern
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    public class ComputerFactory
    {
        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public static Computer GetComputer(string obj)
        {
            Computer obje = null;
            if ("PC".Equals(obj))
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Pc");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obje = new PC(ram, hdd, cpu);
            }
            else if ("Server".Equals(obj))
            {
                Console.WriteLine("enter RAM,HDD,CPU values for Server");
                string ram = Utility.ReadString();
                string hdd = Utility.ReadString();
                string cpu = Utility.ReadString();
                obje = new Server(ram, hdd, cpu);
            }

            return obje;
        }
    }
}
