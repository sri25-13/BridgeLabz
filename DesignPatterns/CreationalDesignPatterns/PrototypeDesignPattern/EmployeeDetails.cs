// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeDetails.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    /// <summary>
    /// class for EmployeeDetails
    /// </summary>
    public abstract class EmployeeDetails
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public abstract Employee Clone();

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public abstract string GetDetails();
    }
}
