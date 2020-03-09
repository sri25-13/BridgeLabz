// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookMethodCalling.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.AddressBookProblem
{
    using System;

    /// <summary>
    /// class for calling methods of AddressBook
    /// </summary>
    public class AddressBookMethodCalling
    {
        /// <summary>
        /// Methods the calling.
        /// </summary>
        /// <param name="model">The model.</param>
        public void MethodCalling(Model model)
        {
            Console.WriteLine("1.Adding person");
            Console.WriteLine("2.Removing person");
            Console.WriteLine("3.Updating data");
            Console.WriteLine("enter an option to be executed");
            int option = Utility.ReadInt();
            switch (option)
            {
                case 1:
                    AddressBookUtility.AddPerson(model);
                    break;
                case 2:
                    AddressBookUtility.DeletePerson(model);
                    break;
                case 3:
                    AddressBookUtility.UpdateData(model);
                    break;
            }
        }
    }
}