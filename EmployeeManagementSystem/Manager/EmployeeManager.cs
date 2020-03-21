using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Repository;

namespace EmployeeManagementSystem.Manager
{
    public class EmployeeManager : IEmployeeManager
    {
        IEmployee employee = new EmployeeManagement();
        public string AddEmployee(Employee employee)
        {
            return this.employee.AddEmployee(employee);
        }

        public bool DeleteEmployee(int id)
        {
            return this.employee.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployee()
        {
            return this.employee.GetAllEmployee();
        }

        public bool Login(string email, string password)
        {
            return this.employee.Login(email, password);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return this.employee.UpdateEmployee(employee);
        }

        
    }
}
