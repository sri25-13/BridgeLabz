// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    /// <summary>
    /// employee class
    /// </summary>
    /// <seealso cref="DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern.EmployeeDetails" />
    public class Employee : EmployeeDetails
    {
        public string employeeName;
        public int employeeId;

        /// <summary>
        /// Gets or sets the name of the employee.
        /// </summary>
        /// <value>
        /// The name of the employee.
        /// </value>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("employeeName : {0}" + "   " + "employeeId : {1}", EmployeeName, EmployeeId);
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}