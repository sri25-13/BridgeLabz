using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    class SecondMember :IUser
    {
        string name;
        IChatMediator chatMediator;

        public SecondMember(IChatMediator chatMediator, string name)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine( name + "sentmessage: " + message);
            chatMediator.SendMessage(message, this);
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine(  name + " received message: " + message);
        }
    }
}

