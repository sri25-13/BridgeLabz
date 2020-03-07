// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUser.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// Interface IUser
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessage(string message);

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ReceiveMessage(string message);
    }
}
