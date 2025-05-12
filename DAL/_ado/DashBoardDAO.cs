using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyHRManagement.DAL._ado
{
    public class DashBoardDAO
    {
        DBConnection db = new DBConnection();

        public Dictionary<string, int> GetEmployeeCountByDepartment()
        {
            var result = new Dictionary<string, int>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"
                SELECT d.DepartmentName, COUNT(e.EmployeeID) AS EmployeeCount
                FROM Departments d
                LEFT JOIN Employees e ON d.DepartmentID = e.DepartmentID
                GROUP BY d.DepartmentName";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string dept = reader["DepartmentName"].ToString();
                    int count = Convert.ToInt32(reader["EmployeeCount"]);
                    result[dept] = count;
                }
            }

            return result;
        }

        public DataTable GetSalaryStructureThisYear(int year)
        {
            SqlConnection conn = DBConnection.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                string query = @"
            SELECT 
                SUM(BaseSalary) AS TotalBaseSalary,
                SUM(Allowance) AS TotalAllowance,
                SUM(Bonus) AS TotalBonus,
                SUM(Penalty) AS TotalPenalty,
                SUM(OvertimeHours) AS TotalOvertime
            FROM Salaries
            WHERE SalaryYear = @year";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public int GetToTalRewardSalary()
        {
            string query = "SELECT SUM(Amount) FROM Rewards";
            object result = DBConnection.ExecuteScalar(query);

            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }


        public int GetTotalValidInsurances()
        {
            string query = "SELECT COUNT(*) FROM Insurance WHERE ExpiryDate >= GETDATE()";
            return (int)DBConnection.ExecuteScalar(query);
        }


        public int GetTotalEmployees()
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE IsFired = 0";
            return (int)DBConnection.ExecuteScalar(query);
        }

        public int GetTotalDepartments()
        {
            string query = "SELECT COUNT(*) FROM Departments";
            return (int)DBConnection.ExecuteScalar(query);
        }

        public int GetTotalPositions()
        {
            string query = "SELECT COUNT(*) FROM Positions";
            return (int)DBConnection.ExecuteScalar(query);
        }

        public int GetProbationCount()
        {
            string query = "SELECT COUNT(*) FROM Employees WHERE IsProbation = 1 AND IsFired = 0";
            return (int)DBConnection.ExecuteScalar(query);
        }
    }
}
