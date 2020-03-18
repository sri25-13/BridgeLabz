using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeeManagementSystem.Controller
{
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            this.employeeManager = employeeManager;
        }

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

        [HttpPut]
        [Route("api/update")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            try
            {
                var result = this.employeeManager.UpdateEmployee(employee);
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
        [HttpDelete]
        [Route("api/delete")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var result = this.employeeManager.DeleteEmployee(id);
                return this.Ok(result);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
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

