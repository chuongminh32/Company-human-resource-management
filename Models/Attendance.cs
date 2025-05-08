using System;

public class Attendance
{
    public int AttendanceID { get; set; }
    public int EmployeeID { get; set; }
    public DateTime Date { get; set; }
    public DateTime CheckInTime { get; set; }
    public DateTime CheckOutTime { get; set; }
    public int OvertimeHours { get; set; }
    public string AbsenceStatus { get; set; }
}
