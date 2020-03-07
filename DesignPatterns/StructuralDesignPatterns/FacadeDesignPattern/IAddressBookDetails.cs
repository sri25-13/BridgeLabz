// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAddressBookDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.StructuralDesignPatterns.FacadeDesignPattern
{
    /// <summary>
    /// Interface for IAddressBookDetails
    /// </summary>
    public interface IAddressBookDetails
    {
        /// <summary>
        /// Persons the name.
        /// </summary>
        public void PersonName();

        /// <summary>
        /// Persons the age.
        /// </summary>
        public void PersonAge();

        /// <summary>
        /// Persons the city.
        /// </summary>
        public void PersonCity();
    }
}
