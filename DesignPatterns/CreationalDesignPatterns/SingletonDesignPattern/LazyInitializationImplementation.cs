// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyInitializationImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    /// <summary>
    /// class for implementing Lazy Initialization
    /// </summary>
    public class LazyInitializationImplementation
    {
        /// <summary>
        /// Lazy initializing implementing.
        /// </summary>
        public static void LazyInitializingImplementing()
        {
            LazyInitialization lazyInitialization = LazyInitialization.Instance;
            lazyInitialization.PrintDetails("firstname");
            LazyInitialization lazyInitialization1 = LazyInitialization.Instance;
            lazyInitialization1.PrintDetails("secondname");
        }
    }
}
