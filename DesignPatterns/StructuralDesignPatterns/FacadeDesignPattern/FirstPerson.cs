// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstPerson.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    using System;

    /// <summary>
    /// Class for Person
    /// </summary>
    /// <seealso cref="DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern.IAddressbookDetails" />
    public class FirstPerson : IAddressBookDetails
    {
        /// <summary>
        /// Persons the name.
        /// </summary>
        public void PersonName()
        {
            Console.WriteLine("Harshini");
        }

        /// <summary>
        /// Persons the age.
        /// </summary>
        public void PersonAge()
        {
            Console.WriteLine("22 years old");
        }

        /// <summary>
        /// Persons the city.
        /// </summary>
        public void PersonCity()
        {
            Console.WriteLine("Bangalore");
        }
    }
}