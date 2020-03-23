// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using System.Collections.Generic;
    using EmployeeManagementSystem.Model;

    /// <summary>
    /// interface for Employeemanager
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Gets the all employee data
        /// </summary>
        /// <returns></returns>
        List<Employee> GetAllEmployee();

        /// <summary>
        /// adds the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        string AddEmployee(Employee employee);

        /// <summary>
        /// Updates the employeedata
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        bool UpdateEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteEmployee(int id);

        /// <summary>
        /// Logging In
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool Login(string email, string password);
    }
}
