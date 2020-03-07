// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DependencyInjection.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// class for DependencyInjection
    /// </summary>
    public class DependencyInjection
    {
        /// <summary>
        /// Dependencies the injection implementation.
        /// </summary>
        public static void DependencyInjectionImplementation()
        {
            Service service = new Service();
            Client client = new Client();
            client.Start(service);
            Customer customer = new Customer();
            client = new Client();
            client.Start(customer);
        }
    }
}
