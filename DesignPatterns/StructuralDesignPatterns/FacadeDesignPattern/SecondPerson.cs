// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SecondPerson.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// class for SecondPerson
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern.IAddressbookDetails" />
    public class SecondPerson : IAddressBookDetails
    {
        /// <summary>
        /// Persons the name.
        /// </summary>
        public void PersonName()
        {
            Console.WriteLine("Amulya");
        }

        /// <summary>
        /// Persons the age.
        /// </summary>
        public void PersonAge()
        {
            Console.WriteLine("15 years old");
        }

        /// <summary>
        /// Persons the city.
        /// </summary>
        public void PersonCity()
        {
            Console.WriteLine("Karimnagar");
        }
    }
}
