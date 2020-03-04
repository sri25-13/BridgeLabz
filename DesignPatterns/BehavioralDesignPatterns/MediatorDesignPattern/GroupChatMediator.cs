using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    class GroupChatMediator : IChatMediator
    {
        List<IUser> users;

        public GroupChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach (IUser user in users)
            {
                if (user != sender)
                    user.ReceiveMessage(message);
            }
        }
    }
}
