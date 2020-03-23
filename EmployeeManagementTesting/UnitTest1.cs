// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UnitTest1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementTesting
{
    using EmployeeManagementSystem.Manager;
    using EmployeeManagementSystem.Model;
    using NUnit.Framework;

    /// <summary>
    /// test class
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Test the AddEmployee
        /// </summary>
        [Test]
        public void AddEmployeeTest()
        {
            EmployeeManager manager = new EmployeeManager();
            Employee employee = new Employee();
            employee.FirstName = "harsh";
            employee.LastName = "rao";
            employee.Email = "harsh@gmail.com";
            employee.Password = "abc";
            string result = manager.AddEmployee(employee);
            Assert.AreEqual("updated", result);
        }

        /// <summary>
        /// Test the DeleteEmployee
        /// </summary>
        [Test]
        public void DeleteEmployeeTest()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            Employee employee = new Employee();
            employee.Id = 12;
            bool result = employeeManager.DeleteEmployee(employee.Id);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// Tests the LogIn
        /// </summary>
        [Test]
        public void LoginTest()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            string email = "harshini@gmail.com";
            string password = "harshinirao";
            bool result = employeeManager.Login(email, password);
            Assert.AreEqual(true, result);
        }

        /// <summary>
        /// teste the updateEmployee
        /// </summary>
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
            Assert.AreEqual(true, result);
        }
    }
}