using EmployeeManagementSystem.Manager;
using EmployeeManagementSystem.Model;
using NUnit.Framework;


namespace EmployeeManagementTesting
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AddEmployeeTest()
        {
            EmployeeManager manager = new EmployeeManager();
            Employee employee = new Employee();
            employee.FirstName = "harsh";
            employee.LastName = "rao";
            employee.Email = "harsh@gmail.com";
            employee.Password = "abc";
            bool result = manager.AddEmployee(employee);
            Assert.AreEqual(true,result);
        }
        [Test]
        public void DeleteEmployeeTest()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Employee employee = new Employee();
            employee.Id =12 ;
            bool result = employeeManager.DeleteEmployee(employee.Id);
            Assert.AreEqual(true,result);
        }
        [Test]
        public void LoginTest()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            string email = "harshini@gmail.com";
            string password = "harshinirao";
            bool result = employeeManager.Login(email,password);
            Assert.AreEqual(true, result);
        }
        [Test]
        public void UpdateEmployee()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Employee employee = new Employee();
            employee.Id = 34;
            employee.FirstName = "harshini";
            employee.LastName = "rao";
            employee.Email = "sri@gmail.com";
            employee.Password = "abcd";
            bool result = employeeManager.UpdateEmployee(employee);
            Assert.AreEqual(true,result);
        }
    }
}