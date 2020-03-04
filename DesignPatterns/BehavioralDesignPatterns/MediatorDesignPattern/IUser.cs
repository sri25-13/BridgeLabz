using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    interface IUser
    {
        void SendMessage(string message);
        void ReceiveMessage(string message);
    
}
}
