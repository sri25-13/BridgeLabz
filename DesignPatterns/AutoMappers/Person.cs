// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.AutoMappers
{
    /// <summary>
    /// Class for person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        /// <value>
        /// The name of the person.
        /// </value>
        public string PersonName { get; set; }

        /// <summary>
        /// Gets or sets the person identifier.
        /// </summary>
        /// <value>
        /// The person identifier.
        /// </value>
        public string PersonId { get; set; }

        /// <summary>
        /// Gets or sets the person address.
        /// </summary>
        /// <value>
        /// The person address.
        /// </value>
        public string PersonAddress { get; set; }
    }
}
