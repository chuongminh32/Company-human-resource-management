using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CompanyHRManagement.GUI.admin
{
    public partial class MainForm_admin : Form
    {


        public MainForm_admin(string email)
        {
            //this.emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            //this.fullname = emp.FullName;
            //this.role = db_BUS.LayTenViTriChucVu(emp.EmployeeID);
            InitializeComponent();
           

        }
        private void MainForm_admin_Load(object sender, EventArgs e)
        {
            panel_main.LoadDashBoard_Count();
        }

        private void HideAllPanels()
        {
            panel_main.Visible = false;
            panel_NhanVien.Visible = false;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất?", "Xác nhận thoát");

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0); // Thoát toàn bộ app lập tức
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_NhanVien.Visible = true;
            panel_NhanVien.BringToFront();
            

        }


        private void guna2Button19_Click(object sender, EventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_main.Visible = true;
            panel_main.BringToFront();
        }

        
    }
}
