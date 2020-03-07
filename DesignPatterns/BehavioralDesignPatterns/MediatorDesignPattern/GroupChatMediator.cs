// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GroupChatMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    using System.Collections.Generic;

    /// <summary>
    /// class for groupchatmediator
    /// </summary>
    /// <seealso cref="DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern.IChatMediator" />
    public class GroupChatMediator : IChatMediator
    {
        readonly List<IUser> users;

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupChatMediator"/> class.
        /// </summary>
        public GroupChatMediator()
        {
            this.users = new List<IUser>();
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(IUser user)
        {
            this.users.Add(user);
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="sender">The sender.</param>
        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }
    }
}