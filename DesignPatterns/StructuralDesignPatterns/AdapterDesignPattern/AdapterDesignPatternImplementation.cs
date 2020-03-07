// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdapterDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns
{
    using System;

    /// <summary>
    /// class for implementing AdapterDesignPattern
    /// </summary>
    public class AdapterDesignPatternImplementation
    {
        /// <summary>
        /// Adapters the implementation.
        /// </summary>
        public static void AdapterImplementation()
        {
            SocketObjectAdapterImplementation socketObjectAdapter = new SocketObjectAdapterImplementation();
            Volt get12volt = socketObjectAdapter.Get12volt();
            Volt get3volt = socketObjectAdapter.Get3volt();
            Volt get120volt = socketObjectAdapter.Get120volt();
            Console.WriteLine(get3volt.GetVolt());
            Console.WriteLine(get12volt.GetVolt());
            Console.WriteLine(get120volt.GetVolt());
        }
    }
}
