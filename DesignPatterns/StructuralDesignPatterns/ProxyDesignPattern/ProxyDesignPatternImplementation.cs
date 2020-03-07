// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProxyDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.ProxyDesignPattern
{
    using System;

    /// <summary>
    /// class for implementing  ProxyDesignPattern
    /// </summary>
    public class ProxyDesignPatternImplementation
    {
        /// <summary>
        /// Proxies the design pattern.
        /// </summary>
        public static void ProxyDesignPattern()
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine(proxy.Adding(4, 2));
            Console.WriteLine(proxy.Subtracting(4, 2));
        }
    }
}
