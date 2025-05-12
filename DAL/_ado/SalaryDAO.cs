using System.Collections.Generic;
using System.Data.SqlClient;

public class SalaryDAO
{
    private DBConnection dbConnection = new DBConnection();

    public List<Salary> GetAllSalaries()
    {
        List<Salary> salaries = new List<Salary>();
        string query = "SELECT * FROM Salary";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Salary salary = new Salary()
                    {
                        SalaryID = reader.GetInt32(0),
                        EmployeeID = reader.GetInt32(1),
                        BaseSalary = reader.GetDecimal(2),
                        Allowance = reader.GetDecimal(3),
                        Bonus = reader.GetDecimal(4),
                        Penalty = reader.GetDecimal(5),
                        Overtime = reader.GetDecimal(6),
                        SalaryMonth = reader.GetInt32(7),
                        SalaryYear = reader.GetInt32(8)
                    };
                    salaries.Add(salary);
                }
            }
        }
        return salaries;
    }
}
