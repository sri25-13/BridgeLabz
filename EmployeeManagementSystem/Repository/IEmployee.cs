using EmployeeManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeManagementSystem.Repository
{
   public interface IEmployee
    {
        List<Employee> GetAllEmployee();
         bool AddEmployee(Employee employee);
         bool UpdateEmployee(Employee employee);
         bool DeleteEmployee(int id);

         bool Login(string email, string password);

    }
}
