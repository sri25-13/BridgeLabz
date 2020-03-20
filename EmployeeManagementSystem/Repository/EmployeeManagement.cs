using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Repository
{
    public class EmployeeManagement : IEmployee
    {
         string connectionString = (@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=EmployeeManagementSystem; Integrated Security=true");
        public string AddEmployee(Employee employee)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddEmployee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                cmd.Parameters.AddWithValue("@Email", employee.Email);
                cmd.Parameters.AddWithValue("@Password", employee.Password);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "added new employee";
            }
        }
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

