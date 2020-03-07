// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.DependencyInjection
{
    using System;

    /// <summary>
    /// class for Client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Starts the specified service.
        /// </summary>
        /// <param name="service">The service.</param>
        public void Start(IService service)
        {
            service.Serve();
        }
    }
}
