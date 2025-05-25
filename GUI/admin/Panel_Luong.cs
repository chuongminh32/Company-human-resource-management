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
        private DepartmentBUS _departmentBUS = new DepartmentBUS();
        private PositionBUS _positionBUS = new PositionBUS();
        public Panel_Luong()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            LoadDGV();
            LoadDepartmentsToCB();
            LoadPositionsToCB();
            LoadSalariesData();
        }
        private void LoadDGV()
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
                dgvLuong.ReadOnly = true;
                dgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvLuong.AllowUserToAddRows = true;

            }
            catch (SqlException e)
            {
                MessageBox.Show("Không lấy được nội dung bảng lương. Đã xảy ra lỗi!" + e.Message);
            }
        }

        private void LoadDepartmentsToCB()
        {
            List<string> departments = _departmentBUS.LayDSTenPhongBan();
            cbPhong.Items.Clear();
            cbPhong.Items.Add(""); // Thêm tùy chọn trống hoặc "Tất cả"
            cbPhong.Items.AddRange(departments.ToArray());
        }

        private void LoadPositionsToCB()
        {
            List<string> Positions = _positionBUS.LayDSTenChucVu();

            cbChucVu.Items.Clear();
            cbChucVu.Items.Add(""); // Thêm tùy chọn trống hoặc "Tất cả"
            cbChucVu.Items.AddRange(Positions.ToArray());
        }
        private void LoadSalariesData()
        {
            string error = "";
            try
            {
                bool result = _salaryBUS.TaiLaiDataLuong(ref error);

                if (!result)
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không mong muốn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Panel_Luong_Load(object sender, EventArgs e)
        {
            
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        
        }
    }
}
