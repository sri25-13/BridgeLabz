// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns
{
    /// <summary>
    /// interface for Observer
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the specified availability.
        /// </summary>
        /// <param name="availability">The availability.</param>
        public void Update(string availability);
    }
}
