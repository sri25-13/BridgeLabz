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
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
       public override string ToString()
        {
            return string.Format("employeeName : {0}"+ "   "+"employeeId : {1}", EmployeeName,EmployeeId);
        }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}

