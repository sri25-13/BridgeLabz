// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediatorDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// -------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehavioralDesignPatterns.MediatorDesignPattern
{
    /// <summary>
    /// class for implementing MediatorDesignPattern
    /// </summary>
    public class MediatorDesignPatternImplementation
    {
        /// <summary>
        /// Mediators the design pattern.
        /// </summary>
        public static void MediatorDesignPattern()
        {
            IChatMediator chatMediator = new GroupChatMediator();
            IUser john = new FirstMember(chatMediator, "John");
            IUser tina = new SecondMember(chatMediator, "Tina");
            IUser lara = new ThirdMember(chatMediator, "Lara");
            chatMediator.AddUser(john);
            chatMediator.AddUser(tina);
            chatMediator.AddUser(lara);
            lara.SendMessage("Hello Everyone!");
        }
    }
}
