// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Service.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.DependencyInjection
{
    using System;

    /// <summary>
    /// class for Service
    /// </summary>
    /// <seealso cref="DesignPatterns.DependencyInjection.IService" />
    public class Service : IService
    {
        /// <summary>
        /// Serves this instance.
        /// </summary>
        public void Serve()
        {
            Console.WriteLine("service called");
        }
    }
}
