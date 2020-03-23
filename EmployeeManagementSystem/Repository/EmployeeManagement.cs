// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EmployeeManagement.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagementSystem.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using EmployeeManagementSystem.Model;

    /// <summary>
    /// class for EmployeeManagement
    /// </summary>
    public class EmployeeManagement : IEmployee
    {
         string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=EmployeeManagementSystem; Integrated Security=true");

        /// <summary>
        /// Adds the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public string AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                int i=cmd.ExecuteNonQuery();
                con.Close();
                return "updated";
            }
        }

        /// <summary>
        /// Updates the employeedata
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool UpdateEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", employee.Id);
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                int i=cmd.ExecuteNonQuery();
                if(i>=1)
                {
                    return true;
                }
                con.Close();
                return false;
            }
        }

        /// <summary>
        /// Deletes the employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                int i=cmd.ExecuteNonQuery();
                if(i==1)
                {
                    return true;
                }
                con.Close();
                return false; ;
            }
        }

        /// <summary>
        /// Get AllEmployeeData
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetAllEmployee()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.FirstName = reader["FirstName"].ToString();
                    employee.LastName = reader["LastName"].ToString();
                    employee.Email = reader["Email"].ToString();
                    employee.Password = reader["Password"].ToString();
                    employees.Add(employee);
                }
                con.Close();
            }
            return employees;
        }

        /// <summary>
        /// Logging In
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string email, string password)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Equals(dataReader["password"].ToString(), password))
                    {
                        if (Equals(dataReader["email"].ToString(), email))
                        {
                            return true;
                        }
                    }
                }
                con.Close();
                return false;
            }
        }
    }
}

