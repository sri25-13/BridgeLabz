// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstMember.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    using System;

    /// <summary>
    /// class for firstmember
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern.IUser" />
   public class FirstMember : IUser
    {
        /// <summary>
        /// The name
        /// </summary>
        readonly string name;
        /// <summary>
        /// The chat mediator
        /// </summary>
        readonly IChatMediator chatMediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstMember"/> class.
        /// </summary>
        /// <param name="chatMediator">The chat mediator.</param>
        /// <param name="name">The name.</param>
        public FirstMember(IChatMediator chatMediator, string name)
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
            Console.WriteLine(name + "sentmessage :" + message);
           this.chatMediator.SendMessage(message, this);
        }

        /// <summary>
        /// Receives the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ReceiveMessage(string message)
        {
            Console.WriteLine(name + "received message: " + message);
        }
    }
}
