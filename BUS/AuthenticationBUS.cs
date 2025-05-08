using CompanyHRManagement.Models;
using System;
using CompanyHRManagement.DAL_ADO;
using CompanyHRManagement.BUS.Utils;

namespace CompanyHRManagement.BUS
{
    public class AuthenticationBUS
    {
        private UserDAO userDAO = new UserDAO();

        public bool ValidateUser(string username, string password)
        {
            // Mã hóa mật khẩu người dùng nhập vào
            string hashedPassword = EncryptionUtil.MD5Hash(password);
            
            // Lấy thông tin người dùng từ UserDAO
            User user = userDAO.GetUserByUsername(username);
            
            if (user != null && user.PasswordHash == hashedPassword) // So sánh mật khẩu đã mã hóa
            {
                return true; // Đăng nhập thành công
            }
            return false; // Đăng nhập thất bại
        }
    }
}
