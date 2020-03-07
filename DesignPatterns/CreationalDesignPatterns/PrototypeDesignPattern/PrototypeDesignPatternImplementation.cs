// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeDesignPatternImplementation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.CreationalDesignPatterns.PrototypeDesignPattern
{
    using System;

    /// <summary>
    /// class for implementing PrototypeDesignPattern
    /// </summary>
    public class PrototypeDesignPatternImplementation
    {
        /// <summary>
        /// Prototypes the implementing.
        /// </summary>
        public static void PrototypeImplementing()
        {
            Employee employee = new Employee();
            Console.WriteLine("enter employeename");
            employee.EmployeeName = Utility.ReadString();
            Console.WriteLine("enter employee id");
            employee.EmployeeId = Utility.ReadInt();
            Console.WriteLine(employee.GetDetails());
            Employee employee1 = employee.Clone();
            Console.WriteLine("enter another employeename");
            employee1.EmployeeName = Utility.ReadString();
            //Console.WriteLine(employee1.GetDetails());
            Console.WriteLine("--------------");
            Console.WriteLine(employee.GetDetails());
            Console.WriteLine(employee1.GetDetails());
        }
    }
}
