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




        //---------- Employee DashBoard -----------


        public string GetPositionNameById(int posID)
        {
            string query = @"       
                SELECT PositionName
                FROM Positions
                WHERE PositionID = @posID
            ";

            SqlParameter[] parameters = { new SqlParameter("@posID", posID) };
            object result = DBConnection.ExecuteScalar(query, parameters);
            return result?.ToString();
        }


        public string GetDepartmentNameByUserId(int userId)
        {
            string query = @"       
                SELECT D.DepartmentName
                FROM Users U
                JOIN Employees E ON U.UserID = E.EmployeeID
                JOIN Departments D ON E.DepartmentID = D.DepartmentID
                WHERE U.UserID = @UserID
            ";

            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            object result = DBConnection.ExecuteScalar(query, parameters);
            return result?.ToString(); // tránh lỗi ép kiểu nếu result là int/null
        }
        // 1. Tổng lương theo tháng của 1 nhân viên
        public List<(int Month, int Year, decimal TotalSalary)> GetMonthlySalary(int employeeId)
        {
            string query = @"
        SELECT SalaryMonth, SalaryYear,
               (BaseSalary + Allowance + Bonus - Penalty) AS TotalSalary
        FROM Salaries
        WHERE EmployeeID = @EmployeeID
        ORDER BY SalaryYear, SalaryMonth";

            SqlParameter[] parameters = { new SqlParameter("@EmployeeID", employeeId) };

            var result = new List<(int, int, decimal)>();
            using (var reader = DBConnection.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    int month = (int)reader["SalaryMonth"];
                    int year = (int)reader["SalaryYear"];
                    decimal salary = (decimal)reader["TotalSalary"];
                    result.Add((month, year, salary));
                }
            }
            return result;
        }

        // 2. Số ngày công theo tháng
        public List<(int Month, int Year, int WorkDays)> GetMonthlyAttendance(int employeeId)
        {
            string query = @"
        SELECT MONTH(WorkDate) AS Month, YEAR(WorkDate) AS Year, COUNT(*) AS WorkDays
        FROM Attendance
        WHERE EmployeeID = @EmployeeID
        GROUP BY MONTH(WorkDate), YEAR(WorkDate)
        ORDER BY Year, Month";

            SqlParameter[] parameters = { new SqlParameter("@EmployeeID", employeeId) };

            var result = new List<(int, int, int)>();
            using (var reader = DBConnection.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    int month = (int)reader["Month"];
                    int year = (int)reader["Year"];
                    int days = (int)reader["WorkDays"];
                    result.Add((month, year, days));
                }
            }
            return result;
        }




    }
}
