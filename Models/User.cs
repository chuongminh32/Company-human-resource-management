using System;
namespace CompanyHRManagement.Models
{
public class User
{
    public int UserID { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; } // hoặc Password nếu bạn đang dùng tên này
    public string FullName { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }
}
}
