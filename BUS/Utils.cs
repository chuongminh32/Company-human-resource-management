using System;
using System.Security.Cryptography;
using System.Text;

namespace CompanyHRManagement.BUS.Utils
{
    public static class EncryptionUtil
    {
        // Hàm MD5 hash
        public static string MD5Hash(string input)
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

        // Hàm SHA256 hash (có thể thay thế MD5 bằng SHA256)
        public static string SHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

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
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string hashedPassword = MD5Hash(enteredPassword);
            return hashedPassword == storedHash;
        }
    }
}
