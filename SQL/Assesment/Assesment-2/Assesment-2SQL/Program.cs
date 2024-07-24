using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2SQL
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    class Program
    {
        static void Main()
        {
            // Connection string
            string connectionString = "Server=ICS-LT-DLDQ4D3\\SQLEXPRESS;Database=Employeemanagement;User Id=sa;Password=Raghav1206@;";

            // Create a new SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a new SqlCommand object
                using (SqlCommand command = new SqlCommand("sp_AddEmployee", connection))
                {
                    // Set the CommandType to StoredProcedure
                    command.CommandType = CommandType.StoredProcedure;

                    // Add the input parameters
                    command.Parameters.AddWithValue("@EmpName", "Jane Doe");
                    command.Parameters.AddWithValue("@Empsal", 35000.00);
                    command.Parameters.AddWithValue("@Emptype", "P");
                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Employee details inserted successfully!");
     

            // Display all employee rows
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Employee_Details", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                      
                        {
                            Console.WriteLine($"Empno: {reader["Empno"]}, EmpName: {reader["EmpName"]}, Empsal: {reader["Empsal"]}, Emptype: {reader["Emptype"]}");

                        }
                    }
                }
            }
        }
                     

    }
}
      
