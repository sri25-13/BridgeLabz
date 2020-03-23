// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Manager
{
    using System.Collections.Generic;
    using EmployeeManagementSystem.Model;
    using EmployeeManagementSystem.Repository;

    /// <summary>
    /// class for employeemanager
    /// </summary>
    public class EmployeeManager : IEmployeeManager
    {
        IEmployee employee = new EmployeeManagement();

        /// <summary>
        /// Adds the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public string AddEmployee(Employee employee)
        {
            return this.employee.AddEmployee(employee);
        }

        /// <summary>
        /// deletes the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {
            return this.employee.DeleteEmployee(id);
        }

        /// <summary>
        /// Gets the all employeedata
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployee()
        {
            return this.employee.GetAllEmployee();
        }

        /// <summary>
        /// Logging in
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string email, string password)
        {
            return this.employee.Login(email, password);
        }

        /// <summary>
        /// Updates the employeedata
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool UpdateEmployee(Employee employee)
        {
            return this.employee.UpdateEmployee(employee);
        }
    }
}
