using System.Collections.Generic;
using System.Data.SqlClient;

public class EmployeeDAO
{
    private DBConnection dbConnection = new DBConnection();

    public List<Employee> GetAllEmployees()
    {
        List<Employee> employees = new List<Employee>();
        string query = "SELECT * FROM Employee";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee employee = new Employee()
                    {
                        EmployeeID = reader.GetInt32(0),
                        FullName = reader.GetString(1),
                        Gender = reader.GetString(2),
                        DateOfBirth = reader.GetDateTime(3),
                        Email = reader.GetString(4),
                        Phone = reader.GetString(5),
                        Department = reader.GetString(6),
                        Position = reader.GetString(7),
                        HireDate = reader.GetDateTime(8),
                        SalaryID = reader.GetInt32(9)
                    };
                    employees.Add(employee);
                }
            }
        }
        return employees;
    }

    //public Employee GetEmployeeById(int employeeID)
    //{
    //    string query = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";
    //    using (var conn = DBConnection.GetConnection())
    //    {
    //        conn.Open();
    //        using (var cmd = new SqlCommand(query, conn))
    //        {
    //            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            if (reader.Read())
    //            {
    //                return new Employee()
    //                {
    //                    EmployeeID = reader.GetInt32(0),
    //                    FullName = reader.GetString(1),
    //                    Gender = reader.GetString(2),
    //                    DateOfBirth = reader.GetDateTime(3),
    //                    Email = reader.GetString(4),
    //                    Phone = reader.GetString(5),
    //                    Department = reader.GetString(6),
    //                    Position = reader.GetString(7),
    //                    HireDate = reader.GetDateTime(8),
    //                    SalaryID = reader.GetInt32(9)
    //                };
    //            }
    //        }
    //    }
    //    return null;
    //}
}
