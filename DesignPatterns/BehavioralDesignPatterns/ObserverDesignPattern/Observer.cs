// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Observer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns
{
    using System;

    /// <summary>
    /// class for observer implements IObserver
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.IObserver" />
    public class Observer : IObserver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Observer"/> class.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <param name="subject">The subject.</param>
        public Observer(string userName, ISubject subject)
        {
            this.UserName = userName;
            subject.Register(this);
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Updates the specified availabiliy.
        /// </summary>
        /// <param name="availabiliy">The availabiliy.</param>
        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Flipkart");
        }
    }
}
