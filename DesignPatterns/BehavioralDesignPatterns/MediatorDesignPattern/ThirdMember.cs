// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThirdMember.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    using System;

    /// <summary>
    /// class for ThirdMember
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern.IUser" />
    public class ThirdMember : IUser
    {
        readonly string name;
        readonly IChatMediator chatMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdMember"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public ThirdMember(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void SendMessage(string message)
        {
            Console.WriteLine(name + " sentmessage: " + message);
            this.chatMediator.SendMessage(message, this);
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(name + " received message: " + message);
        }
    }
}
