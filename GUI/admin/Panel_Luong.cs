using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using CompanyHRManagement.BUS._ado;
using Guna.UI2.WinForms;
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
        private bool isNewSalaryGenerated = false;
        private DataTable dtLuong_new = null;


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

                FormatSalaryGrid();
                dgvLuong.Columns["TotalSalary"].Visible = false;


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
            cbPhong.SelectedIndex = 0;

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
            cbChucVu.SelectedIndex = 0;
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
                cbMonth.Text.ToString(), cbYear.Text.ToString(), 
                cbPhong.Text.ToString(), cbChucVu.Text.ToString()));
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
                    guna2MessageDialog1.Show("Thêm lương thành công!");
                    them = false;
                    LoadData();
                }
                else
                {
                    guna2MessageDialog1.Show("Lỗi: " + error);
                }
            }
            else if (sua == true)
            {
                // Lấy dữ liệu từ các control trên form
                if (!int.TryParse(txtSalaryID.Text, out int salaryID) || salaryID <= 0)
                {
                    guna2MessageDialog1.Show("SalaryID không hợp lệ.");
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
                    guna2MessageDialog1.Show("Cập nhật lương thành công!");
                    sua = false;
                    LoadData();
                }
                else
                {
                    guna2MessageDialog1.Show("Lỗi: " + error);
                }
            }
            else if (isNewSalaryGenerated)
            {
                bool success = _salaryBUS.LuuBangLuongMoi(dtLuong_new, ref error);
                if (success)
                {
                    guna2MessageDialog1.Show("Thêm bảng lương mới thành công!");
                    isNewSalaryGenerated = false;
                    LoadData();
                }
                else
                {
                    guna2MessageDialog1.Show("Lỗi: " + error);
                }
            }
            else
            {
                guna2MessageDialog1.Show("Vui lòng chọn hành động Thêm/Xóa/Sửa/Bảng Lương Mới trước khi nhấn Lưu");
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
            }
            else if (dgvLuong.SelectedRows.Count == 1)
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

        private void btnSalarythismonth_Click(object sender, EventArgs e)
        {
            // Thiết lập dialog hỏi người dùng
            guna2MessageDialog1.Caption = "Chọn thao tác";
            guna2MessageDialog1.Text = "Bạn muốn tính bảng lương tháng mới hay xem bảng lương cũ?\n\n" +
                                       "Chọn Yes để tính bảng lương mới.\n" +
                                       "Chọn No để xem bảng lương cũ.";
            guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = MessageDialogButtons.YesNoCancel;

            // Hiển thị dialog
            var result = guna2MessageDialog1.Show();

            if (result == DialogResult.Yes)
            {
                // Kiểm tra tháng
                if (!int.TryParse(cbMonth.Text, out int month) || month < 1 || month > 12)
                {
                    MessageBox.Show("Vui lòng chọn tháng hợp lệ (1 - 12).", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra năm
                if (!int.TryParse(cbYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                {
                    MessageBox.Show("Vui lòng nhập năm hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chỉ cho phép tính lương tháng hiện tại hoặc tháng trước
                var now = DateTime.Now;
                var currentMonth = now.Month;
                var currentYear = now.Year;

                bool isValidMonth = (year == currentYear && (month == currentMonth || month == currentMonth - 1)) ||
                                    (year == currentYear - 1 && currentMonth == 1 && month == 12);

                if (!isValidMonth)
                {
                    guna2MessageDialog1.Parent = this.FindForm();
                    guna2MessageDialog1.Caption = "Tháng/Năm không hợp lệ";
                    guna2MessageDialog1.Text = "Chỉ được tính lương cho tháng hiện tại hoặc tháng trước.\nVui lòng chọn lại.";
                    guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    guna2MessageDialog1.Buttons = MessageDialogButtons.OK;
                    guna2MessageDialog1.Show();
                    return;
                }

                // Gọi hàm tính bảng lương mới
                dtLuong_new = _salaryBUS.XuatBangLuongThangMoi(month, year);
                isNewSalaryGenerated = true;

                // Gán dữ liệu mới vào DataGridView
                dgvLuong.DataSource = dtLuong_new;
                FormatSalaryGrid();

            }
            else if (result == DialogResult.No)
            {
                FormatSalaryGrid();
                return;
            }
            else
            {
                // Người dùng bấm Cancel
                return;
            }           
        }


        private void dgvLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLuong.Columns[e.ColumnIndex].Name == "TotalSalary" && e.Value != null)
            {
                // Tô đỏ nền
                e.CellStyle.BackColor = Color.Red;
                // In đậm chữ
                e.CellStyle.Font = new System.Drawing.Font(dgvLuong.Font, FontStyle.Bold);
                // Màu chữ trắng để dễ nhìn hơn trên nền đỏ
                e.CellStyle.ForeColor = Color.White;
            }
        }

        private void FormatSalaryGrid()
        {
            if (dgvLuong.Columns.Count == 0) return;

            // Đặt kích thước DataGridView cố định
            dgvLuong.Width = 1028;
            dgvLuong.Height = 417;

            // Tắt auto resize để chỉnh tay cột
            dgvLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Đặt tiêu đề tiếng Việt
            dgvLuong.Columns["SalaryID"].HeaderText = "Mã lương";
            dgvLuong.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvLuong.Columns["FullName"].HeaderText = "Họ và tên";
            dgvLuong.Columns["SalaryMonth"].HeaderText = "Tháng";
            dgvLuong.Columns["SalaryYear"].HeaderText = "Năm";
            dgvLuong.Columns["BaseSalary"].HeaderText = "Lương cơ bản";
            dgvLuong.Columns["Allowance"].HeaderText = "Phụ cấp";
            dgvLuong.Columns["Bonus"].HeaderText = "Tiền thưởng";
            dgvLuong.Columns["Penalty"].HeaderText = "Tiền phạt";
            dgvLuong.Columns["OvertimeHours"].HeaderText = "Giờ làm thêm";

            // Ẩn cột không cần thiết
            dgvLuong.Columns["EmployeeID"].Visible = false;

            // Đổi thứ tự cột: FullName ngay sau SalaryID
            dgvLuong.Columns["SalaryID"].DisplayIndex = 0;
            dgvLuong.Columns["FullName"].DisplayIndex = 1;

            // Các cột khác lần lượt từ 2 trở đi
            int displayIndex = 2;
            string[] otherCols = new string[]
            {
        "SalaryMonth", "SalaryYear", "BaseSalary", "Allowance", "Bonus", "Penalty", "OvertimeHours"
            };

            foreach (var colName in otherCols)
            {
                if (dgvLuong.Columns.Contains(colName))
                {
                    dgvLuong.Columns[colName].DisplayIndex = displayIndex;
                    displayIndex++;
                }
            }

            // Đặt độ rộng từng cột (pixels)
            dgvLuong.Columns["SalaryID"].Width = 80;
            dgvLuong.Columns["FullName"].Width = 200;
            dgvLuong.Columns["SalaryMonth"].Width = 60;
            dgvLuong.Columns["SalaryYear"].Width = 60;
            dgvLuong.Columns["BaseSalary"].Width = 110;
            dgvLuong.Columns["Allowance"].Width = 90;
            dgvLuong.Columns["Bonus"].Width = 90;
            dgvLuong.Columns["Penalty"].Width = 90;
            dgvLuong.Columns["OvertimeHours"].Width = 90;

            // Cột TotalSalary
            if (dgvLuong.Columns.Contains("TotalSalary"))
            {
                dgvLuong.Columns["TotalSalary"].HeaderText = "Tổng lương";
                dgvLuong.Columns["TotalSalary"].Visible = true;
                dgvLuong.Columns["TotalSalary"].Width = 150;
                dgvLuong.Columns["TotalSalary"].DisplayIndex = displayIndex; // đặt cuối cùng
            }

            // Thiết lập khác
            dgvLuong.ReadOnly = true;
            dgvLuong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLuong.AllowUserToAddRows = false;
        }
    }



}
