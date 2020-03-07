// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.Singleton
{
    using System;

    /// <summary>
    /// class for ThreadSafeSingleton
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// The instancelock
        /// </summary>
        private static readonly object Instancelock = new object();

        /// <summary>
        /// The counter
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        /// <summary>
        /// The object
        /// </summary>
        private static ThreadSafeSingleton obj = null;

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if (obj == null)
                {
                    lock (Instancelock)
                    {
                        if (obj == null)
                        {
                            obj = new ThreadSafeSingleton();
                        }
                    }
                }

                return obj;
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