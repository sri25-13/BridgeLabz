// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using EmployeeManagementSystem.Model;
    using System.Collections.Generic;

    /// <summary>
    /// interface for employee
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// method to get employeedata
        /// </summary>
        /// <returns></returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// method to add the employeee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        string AddEmployee(Employee employee);

        /// <summary>
        /// method to update employee data
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        bool UpdateEmployee(Employee employee);

        /// <summary>
        /// deletes th employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// logging In
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string email, string password);
    }
}
