// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    using System;

    /// <summary>
    /// class for EagerInitializing
    /// </summary>
    public class EagerInitialization
    {
        private static readonly EagerInitialization instance = new EagerInitialization();
        private static int counter = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static EagerInitialization Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Prints the details.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
