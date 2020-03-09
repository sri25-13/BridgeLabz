// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// class for InventoryManagement
    /// </summary>
    public class InventoryManagement1
    {
        /// <summary>
        /// Callings the methods.
        /// </summary>
        /// <param name="model">The model.</param>
        public void CallingMethods(Model model)
        {
            Console.WriteLine("1.Adding to Rice ");
            Console.WriteLine("2.Adding to Pulses ");
            Console.WriteLine("3.Adding to Wheats ");
            Console.WriteLine("4.Removing item");
            Console.WriteLine("5.Update an item");
            Console.WriteLine("enter any option to get executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    Utility.AddRice(model);
                    break;
                case 2:
                    Utility.AddWheats(model);
                    break;
                case 3:
                    Utility.AddPulses(model);
                    break;
                case 4:
                    Utility.RemoveItem(model);
                    break;
                case 5:
                    Utility.UpdateData(model);
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
        }
    }
}