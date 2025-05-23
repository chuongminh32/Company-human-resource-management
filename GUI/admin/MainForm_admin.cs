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
        private Panel_main panel_main = new Panel_main();
        private Panel_NhanVien panel_nhanVien = new Panel_NhanVien();


        public MainForm_admin(string email)
        {
            //this.emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            //this.fullname = emp.FullName;
            //this.role = db_BUS.LayTenViTriChucVu(emp.EmployeeID);
            InitializeComponent();

            // Khởi tạo và cấu hình Panel_main, Panel_NhanVien
            InitializePanelMain();
            InitializePanelNhanVien();

        }

        private void InitializePanelMain()
        {
            // Đặt vị trí và kích thước của panel_main giống panel_element
            panel_main.Location = panel_element.Location;
            panel_main.Size = panel_element.Size;

            // Thêm panel_main vào Controls nếu chưa có
            if (!this.Controls.Contains(panel_main))
            {
                this.Controls.Add(panel_main);
            }

            panel_main.BringToFront();
            panel_main.Visible = true;

        }


        private void InitializePanelNhanVien()
        {
            if (!this.Controls.Contains(panel_nhanVien))
            {
                //panel_nhanVien = new Panel_NhanVien();
                panel_nhanVien.Size = new Size(400, this.ClientSize.Height); // Width cố định
                panel_nhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                panel_nhanVien.Location = new Point(this.ClientSize.Width - panel_nhanVien.Width, 0);
                panel_nhanVien.Visible = false;
                this.Controls.Add(panel_nhanVien);
                panel_nhanVien.BringToFront();
            }
        }

        private void HideAllPanels()
        {
            panel_main.Visible = false;
            panel_nhanVien.Visible = false;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");

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

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panel_nhanVien.Visible = true;
            panel_nhanVien.BringToFront();
            Console.WriteLine("Số lượng controls: " + this.Controls.Count);
            Console.WriteLine("Có chứa panel_nhanVien không: " + this.Controls.Contains(panel_nhanVien));

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
