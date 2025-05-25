using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        "ON s.EmployeeID = e.EmployeeID";


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



}
