using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.BUS._ado;
using iTextSharp.text;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_Luong : UserControl
    {
        private SalaryBUS _salaryBUS = new SalaryBUS();
        public Panel_Luong()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                List<Salary> danhSachLuong = _salaryBUS.LayTatCaThongTinLuong_Admin(); 

                dgvLuong.DataSource = danhSachLuong; 

                // Ẩn cột EmployeeID
                dgvLuong.Columns["EmployeeID"].Visible = false;

                // Đổi tiêu đề các cột sang tiếng Việt
                dgvLuong.Columns["FullName"].HeaderText = "Họ và tên";
                dgvLuong.Columns["SalaryID"].HeaderText = "Mã lương";
                dgvLuong.Columns["BaseSalary"].HeaderText = "Lương cơ bản";
                dgvLuong.Columns["Allowance"].HeaderText = "Phụ cấp";
                dgvLuong.Columns["Bonus"].HeaderText = "Thưởng";
                dgvLuong.Columns["Penalty"].HeaderText = "Phạt";
                dgvLuong.Columns["OvertimeHours"].HeaderText = "Số giờ tăng ca";
                dgvLuong.Columns["SalaryMonth"].HeaderText = "Tháng";
                dgvLuong.Columns["SalaryYear"].HeaderText = "Năm";

                dgvLuong.Columns["FullName"].DisplayIndex = 1;

                // Tùy chọn thêm: căn giữa hoặc chỉnh độ rộng
                dgvLuong.AutoResizeColumns();

            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung bảng lương. Đã xảy ra lỗi!" + e.Message);
            }
        }

        private void Panel_Luong_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvLuong.ReadOnly = true;
            dgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuong.AllowUserToAddRows = true;
            
        }
    }
}
