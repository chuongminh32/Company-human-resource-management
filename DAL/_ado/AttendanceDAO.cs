using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class AttendanceDAO
{
    private DBConnection dbConnection = new DBConnection();

    public List<Attendance> GetAttendancesByEmployee(int employeeID)
    {
        List<Attendance> attendances = new List<Attendance>();
        string query = "SELECT * FROM Attendance WHERE EmployeeID = @EmployeeID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Attendance attendance = new Attendance()
                    {
                        AttendanceID = reader.GetInt32(0),
                        EmployeeID = reader.GetInt32(1),
                        Date = reader.GetDateTime(2),
                        CheckInTime = reader.GetDateTime(3),
                        CheckOutTime = reader.GetDateTime(4),
                        OvertimeHours = reader.GetInt32(5),
                        AbsenceStatus = reader.GetString(6)
                    };
                    attendances.Add(attendance);
                }
            }
        }
        return attendances;
    }
}
