// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Controller
{
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// controller class
    /// </summary>
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager employeeManager;

        /// <summary>
        /// Constructor for employeecontroller
        /// </summary>
        /// <param name="employeeManager"></param>
        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

        /// <summary>
        /// Actionmethod for adding the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/create")]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {
                var result = this.employeeManager.AddEmployee(employee);
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Actionmethod for updating the employeedata
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/update")]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            try
            {
                var result = this.employeeManager.UpdateEmployee(employee);
                if (result)
                {
                    return this.Ok(result);
                }
                else
                {
                    return this.BadRequest(" invalid id");
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// actionmethod for deleting the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/delete")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var result = this.employeeManager.DeleteEmployee(id);
                if (result)
                {
                    return this.Ok(result);
                }
                else
                {
                    return this.BadRequest("invalid id");
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// actionmethod to get all the employeedata
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/get")]
        public IActionResult GetAllEmployee()
        {
            try
            {
                List<Employee> employees = this.employeeManager.GetAllEmployee();
                return this.Ok(employees);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// action method for logging in
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/login")]
        public IActionResult Login(string email, string password)
        {
            try
            {
                bool result = this.employeeManager.Login(email, password);
                if (result)
                {
                    return this.Ok(result);
                }
                else
                {
                    return this.BadRequest("Invalid details or not yet registered");
                }
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}