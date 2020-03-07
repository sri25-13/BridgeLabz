// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class for Subject
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.ISubject" />
    public class Subject : ISubject
    {
        /// <summary>
        /// The observers
        /// </summary>
        private readonly List<IObserver> observers = new List<IObserver>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class.
        /// </summary>
        /// <param name="productName">Name of the product.</param>
        /// <param name="productPrice">The product price.</param>
        /// <param name="availability">The availability.</param>
        public Subject(string productName, int productPrice, string availability)
        {
           this.ProductName = productName;
            this.ProductPrice = productPrice;
            this.Availability = availability;
        }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        /// <value>
        /// The name of the product.
        /// </value>
        private string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the product price.
        /// </summary>
        /// <value>
        /// The product price.
        /// </value>
        private int ProductPrice { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        private string Availability { get; set; }

        /// <summary>
        /// Gets the availability.
        /// </summary>
        /// <returns>
        /// returns availability
        /// </returns>
        public string GetAvailability()
        {
            return this.Availability;
        }

        /// <summary>
        /// Sets the availability.
        /// </summary>
        /// <param name="availability">The availability.</param>
        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
           this.NotifyObservers();
        }

        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Uns the register.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void UnRegister(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers()
        {
            Console.WriteLine(" Notifying observers...");
            foreach (IObserver observer in observers)
            {
               observer.Update(Availability);
            }
        }
    }
}
