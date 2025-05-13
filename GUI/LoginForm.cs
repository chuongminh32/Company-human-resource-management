using System;
using System.Windows.Forms;
using CompanyHRManagement.BUS;
using CompanyHRManagement.GUI.user;
using CompanyHRManagement.GUI.admin;
using CompanyHRManagement.BUS._ado;

namespace CompanyHRManagement.GUI
{
    public partial class LoginForm : Form
    {

        private AuthenticationBUS authenticationBUS = new AuthenticationBUS();
        private UserBUS user = new UserBUS();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        public void check_role(string username)
        {
            string role = user.getInfoUser(username).Role;
            if (role == "Employee")
            {
                MainForm_user mf = new MainForm_user(username);
                mf.Show();
                this.Hide();
            }
            else if (role == "Admin")
            {
                MainForm_admin mf = new MainForm_admin(username);
                mf.Show();
                this.Hide();
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Tên đăng nhập không tồn tại", "Lỗi rồi!");

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = user.getInfoUser(username).Role;
            bool isValid = authenticationBUS.ValidateUser(username, password);// Kiểm tra tên đăng nhập và mật khẩu

            //  bỏ trống username và password
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn vui lòng nhập cả mật khẩu và tên đăng nhập nha.", "Nhập thiếu rồi!");
                return;
            }

            // Kiểm tra tên đăng nhập và mật khẩu
            if (isValid)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Chào bạn đã quay lại ", " Đăng nhập thành công !");
                check_role(username); // kiểm tra quyền của người dùng
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Sai tên đăng nhập hoặc mật khẩu rồi.", "Lỗi rồi!");
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy bỏ việc đóng form
            }
            else
            {
                // Thoát toàn bộ ứng dụng sau khi form đóng xong
                this.BeginInvoke(new Action(() =>
                {
                    Application.Exit();
                }));
            }

        }

    }
}
