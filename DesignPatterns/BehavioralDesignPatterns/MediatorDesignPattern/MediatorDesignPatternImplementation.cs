using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    class MediatorDesignPatternImplementation
    {
        public static void MediatorDesignPattern()
        {
            IChatMediator chatMediator = new GroupChatMediator();
            IUser john = new FirstMember(chatMediator, "John");
            IUser tina = new SecondMember(chatMediator, "Tina");
            IUser lara = new ThirdMember(chatMediator, "Lara");
            chatMediator.AddUser(john);
            chatMediator.AddUser(tina);
            chatMediator.AddUser(lara);
            // send message
            lara.SendMessage("Hello Everyone!");
        }
    }
}
