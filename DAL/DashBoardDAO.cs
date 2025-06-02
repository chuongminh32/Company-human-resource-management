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

        //---------- Employee DashBoard - USER -----------
        // Lấy tên vị trí chức vụ theo ID 
        public string LayVitriChucVuTheoID(int userID)
        {
            string query = @"       
                SELECT p.PositionName
                FROM Employees e
                JOIN Positions p ON e.PositionID = p.PositionID
                WHERE e.EmployeeID = @userID
            ";

            SqlParameter[] parameters = { new SqlParameter("@userID", userID) };
            object result = DBConnection.ExecuteScalar(query, parameters);
            return result?.ToString();
        }


        public string LayTenPhongBanQuaID(int idDeparment)
        {
            string query = @"       
                SELECT D.DepartmentName
                FROM Employees E
                JOIN Departments D ON E.DepartmentID = D.DepartmentID
                WHERE E.DepartmentID = @idDeparment;
            ";

            SqlParameter[] parameters = { new SqlParameter("@idDeparment", idDeparment) };
            object result = DBConnection.ExecuteScalar(query, parameters);
            return result?.ToString(); // tránh lỗi ép kiểu nếu result là int/null
        }
        // Tổng lương theo tháng của 1 nhân viên
        public List<(int Month, int Year, decimal TotalSalary)> TongLuongTheoThang(int employeeId)
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

        // Số ngày công theo tháng
        public List<(int Month, int Year, int WorkDays)> SoNgayCongTheoThang(int employeeId)
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
