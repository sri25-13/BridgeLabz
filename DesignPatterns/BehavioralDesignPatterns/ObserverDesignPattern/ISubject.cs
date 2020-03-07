// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISubject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns
{
    /// <summary>
    /// Interface for Subject
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer);

        /// <summary>
        /// Uns the register.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void UnRegister(IObserver observer);

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers();
    }
}
