using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace WebApplication1
{
    public class EmpRepo
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        
        public void AddEmp(EmployeeModel e1)
        {
            try
            {
                conn.Open();

                // Perform additional operations here after the connection is opened, if needed.

                // Assume you have a table named "Employees" with columns FirstName, LastName, and Email.
                string query = $"INSERT INTO Employee (first_name, last_name, email) VALUES ('{e1.first_name}', '{e1.last_name}', '{e1.email}')";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Execute the query
                cmd.ExecuteNonQuery();

                // The employee has been added successfully.
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log it or throw it).
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
            finally
            {
                // Close the connection in the finally block to ensure it's always closed,
                // even if an exception occurs.
                
                    conn.Close();
                
            }
        }
        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            try
            {
                conn.Open();

                // Assume you have a table named "Employees" with columns FirstName, LastName, and Email.
                string query = "SELECT * FROM Employee";
                SqlCommand cmd = new SqlCommand(query, conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Assuming EmployeeModel has properties first_name, last_name, and email
                        EmployeeModel employee = new EmployeeModel
                        {
                            id=reader["id"].ToString(),
                            first_name = reader["first_name"].ToString(),
                            last_name = reader["last_name"].ToString(),
                            email = reader["email"].ToString()
                        };

                        employees.Add(employee);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log it or throw it).
                Console.WriteLine($"Error executing query: {ex.Message}");
            }
            finally
            {
                // Close the connection in the finally block to ensure it's always closed,
                // even if an exception occurs.
                conn.Close();
            }

            return employees;
        }


    }
}
