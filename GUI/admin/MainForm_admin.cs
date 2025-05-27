using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CompanyHRManagement.GUI.admin
{
    public partial class MainForm_admin : Form
    {
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private int user_id;
        private string username;
        private Employee emp = new Employee();
        private LoginForm loginForm;

        public MainForm_admin(string email, LoginForm loginForm)
        {
            InitializeComponent();
            this.emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            this.user_id = emp.EmployeeID;
            this.username = emp.FullName;
            this.loginForm = loginForm;


        }
        private void MainForm_admin_Load(object sender, EventArgs e)
        {
            panel_main.LoadDashBoard_Count(emp);
            lblUsername.Text = emp.FullName;
        }



        private void HideAllPanels()
        {
            panel_main.Visible = false;
            panel_NhanVien.Visible = false;
            panel_ChamCong1.Visible = false;
            panel_Message1.Visible = false;
            panel_Luong.Visible = false;
        }



        private void guna2Button19_Click(object sender, EventArgs e)
        {

        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_NhanVien.Visible = true;
            panel_NhanVien.BringToFront();
        }



        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_main.Visible = true;
            panel_main.BringToFront();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_ChamCong1.Visible = true;
            panel_NhanVien.BringToFront();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_Message1.Visible = true;
            panel_Message1.CurrentUserId = user_id;
            panel_Message1.BringToFront();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_Luong.Visible = true;
            panel_Luong.BringToFront();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_NhanVien.Visible = true;
            panel_NhanVien.BringToFront();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");
            if (result == DialogResult.Yes)
            {
                loginForm.ResetFields(); // Xóa email + password khi quay lại
                this.Close(); // Gọi Close để quay về Login
            }
        }
    }
}
