using CompanyHRManagement.Models;
using System;
using CompanyHRManagement.DAL._ado;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace CompanyHRManagement.BUS
{
    public class AuthenticationBUS
    {
        private EmployeeBUS em_BUS = new EmployeeBUS();

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

        public bool ValidateUser(string email, string password)
        {

            // Lấy thông tin người dùng từ UserDAO
            Employee e = em_BUS.GetEmployeeByEmail(email);

            if (e != null && e.password == password) // So sánh mật khẩu
            {
                return true; // Đăng nhập thành công
            }
            return false; // Đăng nhập thất bại
        }


    }
}
