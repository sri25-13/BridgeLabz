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
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);

        bool Login(string email, string password);

    }
}
