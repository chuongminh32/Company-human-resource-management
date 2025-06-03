using System.Net.Mail;
using System.Net;
using System;

namespace CompanyHRManagement.Utils
{
    public class EmailHelper
    {
        public static string SendOTP(string toEmail)
        {
            // Tạo mã OTP gồm 6 chữ số ngẫu nhiên (từ 100000 đến 999998) và chuyển thành chuỗi
            string otp = new Random().Next(100000, 999999).ToString();

            // Tạo một đối tượng MailMessage với địa chỉ người gửi và người nhận
            MailMessage mail = new MailMessage("chuongminh3225@gmail.com", toEmail);

            // Đặt tiêu đề (subject) của email
            mail.Subject = "Mã xác thực khôi phục mật khẩu";

            // Đặt nội dung (body) của email, chèn mã OTP vào nội dung
            mail.Body = $"Mã OTP của bạn là: {otp}";

            // Tạo đối tượng SmtpClient để gửi email qua máy chủ SMTP của Gmail
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); // Sử dụng cổng 587 cho TLS

            // Cung cấp thông tin đăng nhập tài khoản Gmail (email + mật khẩu ứng dụng)
            smtp.Credentials = new NetworkCredential("chuongminh3225@gmail.com", "jwcp vomk bdpi fduz");

            // Bật SSL để đảm bảo gửi email qua kết nối an toàn
            smtp.EnableSsl = true;

            // Thực hiện gửi email đi
            smtp.Send(mail);

            // Trả về mã OTP đã tạo để dùng sau này (ví dụ: xác minh OTP người dùng nhập vào)
            return otp;

        }
    }
}
