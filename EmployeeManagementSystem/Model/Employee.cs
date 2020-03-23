// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Model
{
    /// <summary>
    /// model class for employee
    /// </summary>
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        /// <summary>
        /// get and sets the lastname
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// get and sets the firstname
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Get and Set the lastname
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        /// <summary>
        /// Get and Set the Email
        /// </summary>
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        /// <summary>
        /// Get and set the Password
        /// </summary>
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }
    }
}
