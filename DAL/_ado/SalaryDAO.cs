using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class SalaryDAO
{

    public decimal TinhTongLuongTheoThangNam(int employeeId, int month, int year)
    {
        string query = @"
    SELECT 
        SUM(BaseSalary + Allowance + Bonus - Penalty + (OvertimeHours * 50000)) AS TotalSalary
    FROM 
        Salaries
    WHERE 
        EmployeeID = @EmployeeID AND SalaryMonth = @Month AND SalaryYear = @Year";

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@Month", month);
            cmd.Parameters.AddWithValue("@Year", year);

            conn.Open();
            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }
    }


    public List<Salary> LayThongTinLuongTheoID(int employeeId)
    {
        List<Salary> list = new List<Salary>();
        string query = @"
        SELECT SalaryID, EmployeeID, BaseSalary, Allowance, Bonus, Penalty, 
               OvertimeHours, SalaryMonth, SalaryYear
        FROM Salaries
        WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Salary s = new Salary()
                        {
                            SalaryID = reader.GetInt32(0),
                            EmployeeID = reader.GetInt32(1),
                            BaseSalary = reader.GetDecimal(2),
                            Allowance = reader.GetDecimal(3),
                            Bonus = reader.GetDecimal(4),
                            Penalty = reader.GetDecimal(5),
                            OvertimeHours = reader.GetInt32(6),
                            SalaryMonth = reader.GetInt32(7),
                            SalaryYear = reader.GetInt32(8)
                        };
                        list.Add(s);
                    }
                }
            }
        }

        return list;
    }

    public List<Salary> LayTatCaThongTinLuong_Admin()
    {
        List<Salary> list = new List<Salary>();
        string query =
        "SELECT s.SalaryID, s.EmployeeID, e.FullName, s.BaseSalary, s.Allowance, s.Bonus, " +
        "s.Penalty, s.OvertimeHours, s.SalaryMonth, s.SalaryYear " +
        "FROM Salaries s INNER JOIN Employees e " +
        "ON s.EmployeeID = e.EmployeeID " +
        "ORDER BY s.SalaryYear DESC, s.SalaryMonth DESC";


        using (SqlConnection conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Salary s = new Salary()
                        {
                            SalaryID = reader.GetInt32(0),
                            EmployeeID = reader.GetInt32(1),
                            FullName = reader.GetString(2),
                            BaseSalary = reader.GetDecimal(3),
                            Allowance = reader.GetDecimal(4),
                            Bonus = reader.GetDecimal(5),
                            Penalty = reader.GetDecimal(6),
                            OvertimeHours = reader.GetInt32(7),
                            SalaryMonth = reader.GetInt32(8),
                            SalaryYear = reader.GetInt32(9)
                        };
                        list.Add(s);
                    }
                }
            }
        }

        return list;
    }
    //Cập nhật thông tin trong bảng lương theo 
    public bool UpdateSalaries(ref string error)
    {
        string updateQuery = @"
            UPDATE S
            SET 
                Penalty = ISNULL(DP.TotalPenalty, 0),
                Bonus = ISNULL(RW.TotalBonus, 0),
                OvertimeHours = ISNULL(AT.TotalOvertime, 0)
            FROM [dbo].[Salaries] S
            LEFT JOIN (
                SELECT EmployeeID, YEAR(DisciplineDate) AS SalaryYear, MONTH(DisciplineDate) AS SalaryMonth, SUM(Amount) AS TotalPenalty
                FROM [dbo].[Disciplines]
                GROUP BY EmployeeID, YEAR(DisciplineDate), MONTH(DisciplineDate)
            ) DP ON S.EmployeeID = DP.EmployeeID AND S.SalaryYear = DP.SalaryYear AND S.SalaryMonth = DP.SalaryMonth
            LEFT JOIN (
                SELECT EmployeeID, YEAR(RewardDate) AS SalaryYear, MONTH(RewardDate) AS SalaryMonth, SUM(Amount) AS TotalBonus
                FROM [dbo].[Rewards]
                GROUP BY EmployeeID, YEAR(RewardDate), MONTH(RewardDate)
            ) RW ON S.EmployeeID = RW.EmployeeID AND S.SalaryYear = RW.SalaryYear AND S.SalaryMonth = RW.SalaryMonth
            LEFT JOIN (
                SELECT EmployeeID, YEAR(WorkDate) AS SalaryYear, MONTH(WorkDate) AS SalaryMonth, SUM(OvertimeHours) AS TotalOvertime
                FROM [dbo].[Attendance]
                GROUP BY EmployeeID, YEAR(WorkDate), MONTH(WorkDate)
            ) AT ON S.EmployeeID = AT.EmployeeID AND S.SalaryYear = AT.SalaryYear AND S.SalaryMonth = AT.SalaryMonth;
        ";

        DBConnection db = new DBConnection();
        return db.MyExecuteNonQuery(updateQuery, CommandType.Text, ref error);
    }
    //Trả về danh sách các năm có trong bảng
    public List<int> GetDistinctSalaryYears()
    {
        List<int> years = new List<int>();
        string query = "SELECT DISTINCT SalaryYear FROM Salaries ORDER BY SalaryYear DESC";

        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    years.Add(reader.GetInt32(0));
                }
            }
        }

        return years;
    }
    //Hàm Lọc + Tìm kiếm
    public List<Salary> SearchSalaries(
    int? salaryID,
    string fullName,
    decimal? baseSalary,
    decimal? allowance,
    decimal? bonus,
    decimal? penalty,
    int? overtimeHours,
    string salaryMonthStr,
    string salaryYearStr)
    {
        List<Salary> list = new List<Salary>();

        // Parse SalaryMonth
        int? salaryMonth = null;
        if (!string.IsNullOrEmpty(salaryMonthStr) && salaryMonthStr != "Tất cả")
        {
            int temp;
            if (int.TryParse(salaryMonthStr, out temp))
                salaryMonth = temp;
        }

        // Parse SalaryYear
        int? salaryYear = null;
        if (!string.IsNullOrEmpty(salaryYearStr) && salaryYearStr != "Tất cả")
        {
            int temp;
            if (int.TryParse(salaryYearStr, out temp))
                salaryYear = temp;
        }

        string query = @"
        SELECT s.SalaryID, e.FullName, s.BaseSalary, s.Allowance, s.Bonus, 
               s.Penalty, s.OvertimeHours, s.SalaryMonth, s.SalaryYear
        FROM Salaries s
        INNER JOIN Employees e ON s.EmployeeID = e.EmployeeID
        WHERE (@SalaryID IS NULL OR s.SalaryID = @SalaryID)
          AND (@FullName IS NULL OR e.FullName COLLATE SQL_Latin1_General_CP1_CI_AS LIKE '%' + @FullName + '%')
          AND (@BaseSalary IS NULL OR s.BaseSalary = @BaseSalary)
          AND (@Allowance IS NULL OR s.Allowance = @Allowance)
          AND (@Bonus IS NULL OR s.Bonus = @Bonus)
          AND (@Penalty IS NULL OR s.Penalty = @Penalty)
          AND (@OvertimeHours IS NULL OR s.OvertimeHours = @OvertimeHours)
          AND (@SalaryMonth IS NULL OR s.SalaryMonth = @SalaryMonth)
          AND (@SalaryYear IS NULL OR s.SalaryYear = @SalaryYear)";

        SqlParameter[] parameters = new SqlParameter[]
        {
        new SqlParameter("@SalaryID", SqlDbType.Int) { Value = salaryID.HasValue ? (object)salaryID.Value : DBNull.Value },
        new SqlParameter("@FullName", SqlDbType.NVarChar, 100) { Value = string.IsNullOrEmpty(fullName) ? (object)DBNull.Value : fullName },
        new SqlParameter("@BaseSalary", SqlDbType.Decimal) { Value = baseSalary.HasValue ? (object)baseSalary.Value : DBNull.Value },
        new SqlParameter("@Allowance", SqlDbType.Decimal) { Value = allowance.HasValue ? (object)allowance.Value : DBNull.Value },
        new SqlParameter("@Bonus", SqlDbType.Decimal) { Value = bonus.HasValue ? (object)bonus.Value : DBNull.Value },
        new SqlParameter("@Penalty", SqlDbType.Decimal) { Value = penalty.HasValue ? (object)penalty.Value : DBNull.Value },
        new SqlParameter("@OvertimeHours", SqlDbType.Int) { Value = overtimeHours.HasValue ? (object)overtimeHours.Value : DBNull.Value },
        new SqlParameter("@SalaryMonth", SqlDbType.Int) { Value = salaryMonth.HasValue ? (object)salaryMonth.Value : DBNull.Value },
        new SqlParameter("@SalaryYear", SqlDbType.Int) { Value = salaryYear.HasValue ? (object)salaryYear.Value : DBNull.Value }
        };

        using (SqlDataReader reader = DBConnection.ExecuteReader(query, parameters))
        {
            while (reader.Read())
            {
                Salary sal = new Salary();

                sal.SalaryID = reader.GetInt32(reader.GetOrdinal("SalaryID"));
                sal.FullName = reader.IsDBNull(reader.GetOrdinal("FullName")) ? "" : reader.GetString(reader.GetOrdinal("FullName"));
                sal.BaseSalary = reader.IsDBNull(reader.GetOrdinal("BaseSalary")) ? 0 : reader.GetDecimal(reader.GetOrdinal("BaseSalary"));
                sal.Allowance = reader.IsDBNull(reader.GetOrdinal("Allowance")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Allowance"));
                sal.Bonus = reader.IsDBNull(reader.GetOrdinal("Bonus")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Bonus"));
                sal.Penalty = reader.IsDBNull(reader.GetOrdinal("Penalty")) ? 0 : reader.GetDecimal(reader.GetOrdinal("Penalty"));
                sal.OvertimeHours = reader.IsDBNull(reader.GetOrdinal("OvertimeHours")) ? 0 : reader.GetInt32(reader.GetOrdinal("OvertimeHours"));
                sal.SalaryMonth = reader.IsDBNull(reader.GetOrdinal("SalaryMonth")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryMonth"));
                sal.SalaryYear = reader.IsDBNull(reader.GetOrdinal("SalaryYear")) ? 0 : reader.GetInt32(reader.GetOrdinal("SalaryYear"));

                list.Add(sal);
            }
        }

        return list;
    }



}
