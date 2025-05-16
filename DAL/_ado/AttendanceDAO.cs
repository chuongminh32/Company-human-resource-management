using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

public class AttendanceDAO
{
    private DBConnection dbConnection = new DBConnection();

    // lấy thông tin chấm công của nhân viên theo ID
    public List<Attendance> LayDuLieuChamCongQuaID(int employeeID)
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
                    try
                    {
                        Attendance attendance = new Attendance()
                        {
                            AttendanceID = reader.GetInt32(0),  // Lấy AttendanceID
                            EmployeeID = reader.GetInt32(1),    // Lấy EmployeeID
                            WorkDate = reader.GetDateTime(2),    // Lấy WorkDate (ngày làm việc)
                            CheckIn = reader.IsDBNull(3) ? (TimeSpan?)null : reader.GetTimeSpan(3),  // Lấy CheckIn (giờ vào)
                            CheckOut = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4),  // Lấy CheckOut (giờ ra)
                            OvertimeHours = reader.GetInt32(5),  // Trả về giá trị mặc định nếu NULL (cho kiểu int)
                            AbsenceStatus = reader.GetString(6)  // Trả về giá trị mặc định nếu NULL (cho kiểu string)
                        };

                        attendances.Add(attendance);

                    }
                    catch (InvalidCastException ex)
                    {
                        // Xử lý ngoại lệ khi kiểu dữ liệu không hợp lệ, ví dụ như dữ liệu không phải là DateTime
                        Console.WriteLine($"Lỗi khi chuyển đổi kiểu dữ liệu: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Xử lý các lỗi chung khác
                        Console.WriteLine($"Lỗi khi xử lý dữ liệu attendance: {ex.Message}");
                    }
                }
            }
        }
        return attendances;
    }

    // lấy số ngày công trong tháng hiện tại của nhân viên
    public int laySoNgayCongTrongThangHienTaiTheoID(int employeeID)
    {
        int daysWorked = 0;
        string query = @"
        SELECT COUNT(DISTINCT WorkDate) AS DaysWorked
        FROM Attendance
        WHERE EmployeeID = @EmployeeID
        AND MONTH(WorkDate) = MONTH(GETDATE()) 
        AND YEAR(WorkDate) = YEAR(GETDATE())
        AND CheckIn IS NOT NULL AND CheckOut IS NOT NULL;
    ";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                var result = cmd.ExecuteScalar();
                daysWorked = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            }
        }
        return daysWorked;
    }

    // -- chấm công ----
    // hàm kiểm tra ngày hôm nay có chấm công hay chưa 
    public Attendance KiemTraCongHomNay(int idNhanVien, DateTime ngayLam)
    {
        Attendance attendance = null;
        string query = "SELECT * FROM Attendance WHERE EmployeeID = @EmployeeID AND WorkDate = @WorkDate";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", idNhanVien);
                cmd.Parameters.AddWithValue("@WorkDate", ngayLam);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    attendance = new Attendance()
                    {
                        AttendanceID = reader.GetInt32(0),
                        EmployeeID = reader.GetInt32(1),
                        WorkDate = reader.GetDateTime(2),
                        CheckIn = reader.IsDBNull(3) ? (TimeSpan?)null : reader.GetTimeSpan(3),  // Lấy CheckIn (giờ vào)
                        CheckOut = reader.IsDBNull(4) ? (TimeSpan?)null : reader.GetTimeSpan(4),  // Lấy CheckOut (giờ ra)
                        OvertimeHours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                        AbsenceStatus = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    };
                }
            }
        }
        return attendance;
    }

    // hàm chấm công cho nhân viên
    public bool themCong(Attendance attendance)
    {
        string query = "INSERT INTO Attendance (EmployeeID, WorkDate, CheckIn, CheckOut, OvertimeHours, AbsenceStatus) " +
                       "VALUES (@EmployeeID, @WorkDate, @CheckIn, @CheckOut, @OvertimeHours, @AbsenceStatus)";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", attendance.EmployeeID);
                cmd.Parameters.AddWithValue("@WorkDate", attendance.WorkDate);
                cmd.Parameters.AddWithValue("@CheckIn", attendance.CheckIn ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CheckOut", attendance.CheckOut ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", attendance.OvertimeHours);
                cmd.Parameters.AddWithValue("@AbsenceStatus", attendance.AbsenceStatus ?? "");

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    // hàm cập nhật giờ ra và số giờ tăng ca
    public bool capNhatCong(Attendance attendance)
    {
        string query = "UPDATE Attendance SET CheckOut = @CheckOut, OvertimeHours = @OvertimeHours WHERE AttendanceID = @AttendanceID";

        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@CheckOut", attendance.CheckOut ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@OvertimeHours", attendance.OvertimeHours);
                cmd.Parameters.AddWithValue("@AttendanceID", attendance.AttendanceID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    // Hàm tính tổng giờ làm việc trong tháng hiện tại của nhân viên
    public double TinhTongGioLamTrongThang(int employeeId)
    {
        double tongGioLam = 0;

        // Xác định ngày đầu và cuối tháng hiện tại
        DateTime ngayDauThang = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        DateTime ngayCuoiThang = ngayDauThang.AddMonths(1).AddDays(-1); // lấy ngày đầu tháng kế tiếp - 1 -> ngày cuối tháng hiện tại
        string query = @"
        SELECT CheckIn, CheckOut 
        FROM Attendance
        WHERE EmployeeID = @EmployeeID 
            AND WorkDate >= @TuNgay 
            AND WorkDate <= @DenNgay
            AND CheckIn IS NOT NULL 
            AND CheckOut IS NOT NULL";
        using (var conn = DBConnection.GetConnection())
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                cmd.Parameters.AddWithValue("@TuNgay", ngayDauThang);
                cmd.Parameters.AddWithValue("@DenNgay", ngayCuoiThang);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TimeSpan checkIn = reader.GetTimeSpan(0);     // Cột CheckIn
                        TimeSpan checkOut = reader.GetTimeSpan(1);    // Cột CheckOut
                        TimeSpan duration = checkOut - checkIn;

                        tongGioLam += duration.TotalHours;
                    }
                }
            }
            return Math.Round(tongGioLam, 2);

        }
    }

}
