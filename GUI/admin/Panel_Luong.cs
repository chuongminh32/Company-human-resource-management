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
        private bool them = false;
        private bool sua = false;
        public Panel_Luong()
        {
            InitializeComponent();
        }
        private void LoadData()
        { 
            LoadSalariesData();
            LoadDGV(_salaryBUS.LayTatCaThongTinLuong_Admin());
            LoadDepartmentsToCB();
            LoadPositionsToCB();
            LoadYearToCB();
            LoadMonthtoCB();
            EnableAllText();
            ClearAllText();

        }
        private void ClearAllText()
        {
            panel_thongtin.Enabled = true;
            //Xóa tất cả text trên các textbox 
            txtSalaryID.Clear();
            txtFullName.Clear();
            txtAllowance.Clear();
            txtBaseSalary.Clear();
            txtBonus.Clear();
            txtOvertimeHours.Clear();
            txtPenalty.Clear();
        }

        private void EnableAllText()
        {
            txtSalaryID.Enabled = true;
            txtFullName.Enabled = true;
            txtAllowance.Enabled = true;
            txtBaseSalary.Enabled = true;
            txtBonus.Enabled = true;
            txtOvertimeHours.Enabled = true;
            txtPenalty.Enabled = true;
        }
        private void LoadDGV(List<Salary> danhSachLuong)
        {
            try
            {
                
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
            cbPhong.Items.Add("Tất cả"); // Thêm tùy chọn trống hoặc "Tất cả"
            cbPhong.Items.AddRange(departments.ToArray());
        }
        private void LoadMonthtoCB()
        {
            cbMonth.SelectedIndex = 0;
        }
        private void LoadPositionsToCB()
        {
            List<string> Positions = _positionBUS.LayDSTenChucVu();

            cbChucVu.Items.Clear();
            cbChucVu.Items.Add("Tất cả"); // Thêm tùy chọn trống hoặc "Tất cả"
            cbChucVu.Items.AddRange(Positions.ToArray());
        }

        private void LoadYearToCB()
        {
            List<int> years = _salaryBUS.LayDanhSachNam();

            cbYear.Items.Clear();
            cbYear.Items.Add("Tất cả"); // Hoặc "" nếu bạn muốn để trống

            foreach (int year in years)
            {
                cbYear.Items.Add(year.ToString());
            }

            cbYear.SelectedIndex = 0;
            

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

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadDGV(_salaryBUS.Loc_TimKiem(txtSalaryID.Text.ToString(),
                txtFullName.Text.ToString(), txtBaseSalary.Text.ToString(),
                txtAllowance.Text.ToString(), txtBonus.Text.ToString(),
                txtPenalty.Text.ToString(), txtOvertimeHours.Text.ToString(),
                cbMonth.Text.ToString(), cbYear.Text.ToString()));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            txtSalaryID.Enabled = false;
            txtBaseSalary.Enabled = false;
            txtBonus.Enabled = false;
            txtPenalty.Enabled = false;
            txtOvertimeHours.Enabled = false;      
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string error = "";
            if (them)
            {
                bool success = _salaryBUS.ThemLuong(
                txtFullName.Text.Trim(),
                cbMonth.Text.Trim(),
                cbYear.Text.Trim(),
                txtAllowance.Text.Trim(),
                ref error);

                if (success)
                {
                    MessageBox.Show("Thêm lương thành công!");
                    them = false;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
            else if (sua == true)
            {
                                // Lấy dữ liệu từ các control trên form
                if (!int.TryParse(txtSalaryID.Text, out int salaryID) || salaryID <= 0)
                {
                    MessageBox.Show("SalaryID không hợp lệ.");
                    return;
                }

                string fullName = txtFullName.Text.Trim();
                string allowanceStr = txtAllowance.Text.Trim();
                string monthStr = cbMonth.Text.Trim();
                string yearStr = cbYear.Text.Trim();

                // Gọi hàm sửa trong BUS
                bool result = _salaryBUS.SuaLuong(salaryID, fullName, allowanceStr, monthStr, yearStr, ref error);

                if (result)
                {
                    MessageBox.Show("Cập nhật lương thành công!");
                    sua = false;
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Lỗi: " + error);
                }
            }
            else
                {
                    MessageBox.Show("Vui lòng chọn hành động Thêm/Xóa/Sửa trước khi nhấn Lưu");
                }
        }

        private void dgvLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng bấm vào header hoặc ngoài vùng dữ liệu
            if (e.RowIndex < 0)
                return;

            // Kiểm tra có dòng được chọn hay không
            if (dgvLuong.SelectedRows.Count > 1)
            {
                ClearAllText();
                List<string> selectedIDs = new List<string>();

                // Lấy các ID trong cột SalaryID của dòng được chọn
                foreach (DataGridViewRow row in dgvLuong.SelectedRows)
                {
                    if (row.Cells["SalaryID"].Value != null)
                    {
                        selectedIDs.Add(row.Cells["SalaryID"].Value.ToString());
                    }
                }

                // Nối danh sách ID thành chuỗi phân cách dấu phẩy
                string input = string.Join(", ", selectedIDs);

                // Gán vào textbox
                txtSalaryID.Text = input;
            } else if (dgvLuong.SelectedRows.Count == 1)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow row = dgvLuong.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox (chuyển đổi kiểu dữ liệu phù hợp)
                txtSalaryID.Text = row.Cells["SalaryID"].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells["FullName"].Value?.ToString() ?? "";
                txtBaseSalary.Text = row.Cells["BaseSalary"].Value?.ToString() ?? "";
                txtAllowance.Text = row.Cells["Allowance"].Value?.ToString() ?? "";
                txtBonus.Text = row.Cells["Bonus"].Value?.ToString() ?? "";
                txtPenalty.Text = row.Cells["Penalty"].Value?.ToString() ?? "";
                txtOvertimeHours.Text = row.Cells["OvertimeHours"].Value?.ToString() ?? "";
                cbMonth.Text = row.Cells["SalaryMonth"].Value?.ToString() ?? "";
                cbYear.Text = row.Cells["SalaryYear"].Value?.ToString() ?? "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string error = "";
            string input = txtSalaryID.Text;

            // 1. Phân tách danh sách ID
            List<int> salaryIDs = input.Split(',')
                .Select(id => int.TryParse(id.Trim(), out int parsedId) ? parsedId : 0)
                .Where(id => id > 0)
                .ToList();

            if (salaryIDs.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập ID cần xóa hợp lệ.");
                return;
            }

            // 2. Hỏi xác nhận người dùng
            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {salaryIDs.Count} bản ghi lương?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
                return;

            // 3. Gọi BUS thực hiện xóa nhiều ID cùng lúc
            bool result = _salaryBUS.XoaLuongtheoIDs(salaryIDs, ref error);

            // 4. Kết quả
            if (result)
            {
                MessageBox.Show("Xóa thành công!");
                LoadData(); // Load lại dữ liệu
            }
            else
            {
                MessageBox.Show("Lỗi: " + error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            panel_thongtin.Enabled = true;
            txtSalaryID.Enabled = false;
            txtBaseSalary.Enabled = false;
            txtBonus.Enabled = false;
            txtPenalty.Enabled = false;
            txtOvertimeHours.Enabled = false;
            sua = true;
        }
    }
}
