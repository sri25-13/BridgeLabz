// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerInitializationImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    /// <summary>
    /// class for implementing EagerInitialization
    /// </summary>
    public class EagerInitializationImplementation
    {
        /// <summary>
        /// Eagers the initializing implementing.
        /// </summary>
        public static void EagerInitializingImplementing()
        {
            EagerInitialization eagerInitialization = EagerInitialization.Instance;
            eagerInitialization.PrintDetails("firstname");
            EagerInitialization eagerInitialization1 = EagerInitialization.Instance;
            eagerInitialization1.PrintDetails("secondname");
        }
    }
}
