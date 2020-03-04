// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LazyInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    using System;

    /// <summary>
    /// class for LazyIniatialization
    /// </summary>
    public class LazyInitialization
    {
        private static LazyInitialization instance;
        private static int counter = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
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
        public static LazyInitialization Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazyInitialization();
                }

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
