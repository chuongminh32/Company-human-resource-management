using CompanyHRManagement.Models;
using System;
using CompanyHRManagement.DAL._ado;
using System.Security.Cryptography;
using System.Text;

namespace CompanyHRManagement.BUS
{
    public class AuthenticationBUS
    {
        private UserDAO userDAO = new UserDAO();

        // Hàm MD5 hash
        public string MD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển byte[] thành chuỗi hex
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }


        // Hàm so sánh mật khẩu đã mã hóa
        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string hashedPassword = MD5Hash(enteredPassword);
            return hashedPassword == storedHash;
        }

        public bool ValidateUser(string username, string password)
        {
            // Mã hóa mật khẩu người dùng nhập vào
            string hashedPassword = MD5Hash(password);

            // Lấy thông tin người dùng từ UserDAO
            User u = userDAO.GetUserByUsername(username);

            if (u != null && u.PasswordHash == hashedPassword) // So sánh mật khẩu đã mã hóa
            {
                return true; // Đăng nhập thành công
            }
            return false; // Đăng nhập thất bại
        }

        public string GetRole(string username)
        {
            User u = userDAO.GetUserByUsername(username);
            if (u != null)
            {
                return u.Role;
            }
            return "";
        }

        public string GetFullName(string username)
        {
            User u = userDAO.GetUserByUsername(username);
            if (u != null)
            {
                return u.FullName;
            }
            return "";
        }
    }
}
