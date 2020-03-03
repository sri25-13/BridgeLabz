﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// main program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("1.InventoryManagements\n2.InventoryDataManagement\n3.AddressBookProblem\n4.StockAccountManagement\n5.DeckOfCards\n6.Delegates");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    InventoryManagement.Test();
                    break;
                case 2:
                    InventoryFactory.Test();
                    break;
                case 3:
                    AddressBookProblem.AddressBookImplementing.SerializingAndDeserializing();
                    break;
                case 4:
                    StockAccountManagement.StockAccountImplementation.Deserializing();
                    break;
                case 5:
                    DeckOfCards ab = new DeckOfCards();
                    ab.PlayCards();
                    break;
                case 6:
                    Delegates.Delegate.MultiCasting();
                    break;
            }
        }
    }
}
