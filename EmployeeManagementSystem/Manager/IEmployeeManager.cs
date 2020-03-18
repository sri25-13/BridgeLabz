using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Manager
{
    public interface IEmployeeManager
    {
         List<Employee> GetAllEmployee();
        string AddEmployee(Employee employee);
        string UpdateEmployee(Employee employee);
        string DeleteEmployee(int id);

        bool Login(string email, string password);

    }
}
