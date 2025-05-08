using System;
using System.Windows.Forms;
using CompanyHRManagement.BUS;

namespace CompanyHRManagement.GUI.Login
{
    public partial class LoginForm: Form
    {
        private AuthenticationBUS authenticationBUS = new AuthenticationBUS();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog.Show("Bạn vui lòng nhập cả mật khẩu và tên đăng nhập nha.", "Nhập thiếu rồi!");
                return;
            }


            // Kiểm tra tên đăng nhập và mật khẩu
            bool isValid = authenticationBUS.ValidateUser(username, password);

        if (isValid)
        {
            guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            guna2MessageDialog.Show("Đăng nhập thành công!");
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
        else
        {
                guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog.Show("Sai tên đăng nhập hoặc mật khẩu rồi.", "Lỗi rồi!");
        }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.No)
            {
                // Nếu người dùng chọn "No", hủy sự kiện FormClosing
                e.Cancel = true;
            }
        }

    }
}
