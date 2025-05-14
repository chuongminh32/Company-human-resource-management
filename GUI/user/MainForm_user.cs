using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using Guna.UI2.WinForms;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Linq;

namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private readonly DashBoardBUS db_BUS = new DashBoardBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private AttendanceBUS attendanceBUS = new AttendanceBUS();

        private string fullname;
        private int user_id;
        private string email;
        private string name_dapartment;
        private string name_position;
        private List<Guna2Button> navButtons;

        // Constructor
        public MainForm_user(string email)
        {
            Employee emp = employeeBUS.GetEmployeeByEmail(email);
            this.email = email;
            this.user_id = emp.EmployeeID;
            this.fullname = emp.FullName;
            this.name_dapartment = db_BUS.GetDepartmentNameById(emp.EmployeeID);
            this.name_position = db_BUS.GetPositionNameById(emp.PositionID);

            InitializeComponent();
        }

        // Load form
        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadAllData();

            lblUsername.Text = fullname;
            lblRole.Text = "Quyền hạn: USER";
            lblXinChao.Text = "Xin chào: " + fullname + " !";

            timerClock.Start();
            InitNavButtons();
        }


        // Form đóng
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

        // --------- BUTTON ---------
        // Khởi tạo các nút điều hướng
        private void InitNavButtons()
        {
            navButtons = new List<Guna2Button> { btnThongTin, btnTrangChu, btnNghiPhep, btnNhanTin, btnDangXuat };
            navButtons.ForEach(btn => btn.Click += NavButton_Click);
        }

        // Xử lý sự kiện khi nhấn nút điều hướng
        private void NavButton_Click(object sender, EventArgs e)
        {
            var clickedBtn = sender as Guna2Button;

            navButtons.ForEach(btn =>
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.Black;
                btn.Font = new Font(btn.Font, FontStyle.Regular);
            });

            clickedBtn.FillColor = Color.LightBlue;
            clickedBtn.ForeColor = Color.White;
            clickedBtn.Font = new Font(clickedBtn.Font, FontStyle.Bold);
        }

        // -------- LOAD DATA DASHBOARD---------
        private void LoadEmployeeInfo(int employeeID)
        {
            Employee emp = employeeBUS.GetEmployeeById(employeeID);
            if (emp == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblIDNhanVien.Text = emp.EmployeeID.ToString();
            lblIDChucVu.Text = emp.PositionID.ToString();
            lbIDPhongBan.Text = emp.DepartmentID.ToString();
            txtTen.Text = emp.FullName;
            txtEmail.Text = emp.Email;
            txtSDT.Text = emp.Phone;
            txtGioiTinh.Text = emp.Gender;
            txtDiaChi.Text = emp.Address;
            lblNgayVaoLam.Text = emp.HireDate.ToString("dd/MM/yyyy");
            lblNgaySinh.Text = emp.DateOfBirth.ToString("dd/MM/yyyy");
            lblThuViec.Text = emp.isProbation == 1 ? "Có" : "Không";
            lblDaNghiViec.Text = emp.isFired == 1 ? "Có" : "Không";
        }

        private void LoadDashboardData()
        {
            lblUsername.Text = fullname;
            lblXinChao.Text = "Xin chào: " + fullname + " !";
            lblHoTen.Text = "Họ tên: " + fullname;
            lblChucVu.Text = "Chức vụ: " + name_position;
            lblPhongBan.Text = "Phòng ban: " + name_dapartment;
        }

        private void LoadSalaryChart()
        {
            var data = db_BUS.GetSalaryChartData(user_id);

            chartSalary.Series.Clear();
            chartSalary.ChartAreas.Clear();
            chartSalary.ChartAreas.Add(new ChartArea("Area"));

            var area = chartSalary.ChartAreas[0];
            area.AxisY.LabelStyle.Format = "#,##0 'VNĐ'";
            area.AxisY.Title = "Tổng lương (VNĐ)";
            area.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            area.AxisY.TitleForeColor = Color.DarkGreen;
            area.AxisX.Title = "Tháng";
            area.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);

            var series = new Series("Tổng lương") { ChartType = SeriesChartType.Column, Color = Color.Orange };
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.TotalSalary));
            chartSalary.Series.Add(series);
        }

        private void LoadAttendanceChart()
        {
            var data = db_BUS.GetAttendanceChartData(user_id);
            chartAttendance.Series.Clear();
            chartAttendance.ChartAreas.Clear();
            chartAttendance.ChartAreas.Add(new ChartArea("Area"));

            var series = new Series("Ngày công") { ChartType = SeriesChartType.Column };
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.WorkDays));

            chartAttendance.Series.Add(series);
            chartAttendance.ChartAreas[0].AxisY.Title = "Số ngày công";
        }

        private void upload_new_data()
        {
            Employee emp = employeeBUS.GetEmployeeByEmail(email);
            fullname = emp.FullName;
            name_dapartment = db_BUS.GetDepartmentNameById(emp.EmployeeID);
            name_position = db_BUS.GetPositionNameById(emp.PositionID);

            LoadDashboardData();

        }

        private void ReloadAllData()
        {
            LoadSalaryChart();  // Tải lại biểu đồ lương
            LoadAttendanceChart();  // Tải lại biểu đồ ngày công
            LoadDashboardData();  // Tải lại các thông tin tổng quan như tên, chức vụ
            LoadEmployeeInfo(user_id); // Tải lại thông tin nhân viên

            // Reset panel giao diện
            HideAllPanels();
            panelTrangChu_user.Visible = true;
        }


        // Đồng hồ
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        // -------- BUTTON - CLICK --------- 
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTrangChu_user.Visible = true;

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");
            if (result == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Hide();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                EmployeeID = int.Parse(lblIDNhanVien.Text),
                PositionID = int.Parse(lblIDChucVu.Text),
                DepartmentID = int.Parse(lbIDPhongBan.Text),
                FullName = txtTen.Text,
                Email = txtEmail.Text,
                Phone = txtSDT.Text,
                Gender = txtGioiTinh.Text,
                Address = txtDiaChi.Text,
                HireDate = DateTime.ParseExact(lblNgayVaoLam.Text, "dd/MM/yyyy", null),
                DateOfBirth = dtbNgaySinh.Value,
                isProbation = lblThuViec.Text == "Có" ? 1 : 0,
                isFired = lblDaNghiViec.Text == "Có" ? 1 : 0
            };

            bool success = employeeBUS.UpdateEmployee(emp);
            guna2MessageDialog2.Icon = success ?
                MessageDialogIcon.Information :
                MessageDialogIcon.Error;

            guna2MessageDialog2.Show(
                success ? "Cập nhật thành công" : "Cập nhật thất bại",
                success ? "OK!" : "Lỗi rồi!"
            );


            if (success)
            {
                // Load lại dữ liệu mới nhất từ DB
                upload_new_data();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ReloadAllData();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            ReloadAllData();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            panelThongTin_ChamCong.Visible = true;
            TaiDuLieuBangChamCong();  // Tải lại bảng dữ liệu chấm công


        }

        private void btnBangLuongCaNhan_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
            panelThongTin_BangLuong.Visible = true;
        }

        private void TaiDuLieuBangChamCong()
        {
            var list = attendanceBUS.GetAttendancesByEmployee(user_id);
            dgvBangChamCong.DataSource = list;
            // cập nhật lại các thông tin chấm công 
            lblID.Text = user_id.ToString();
            lblNgayHomNay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblSoNgayCong.Text = attendanceBUS.laySoNgayCongTrongThangHienTaiTheoID(user_id).ToString();
            lblTongGioLam.Text = attendanceBUS.layTongGioLamTrongThangHienTaiTheoID(user_id).ToString();

            FormatDGV();
        }



        private void FormatDGV()
        {

            // Tắt cho phép chỉnh sửa
            dgvBangChamCong.ReadOnly = true;
            dgvBangChamCong.AllowUserToAddRows = false;
            dgvBangChamCong.AllowUserToDeleteRows = false;
            dgvBangChamCong.AllowUserToOrderColumns = false;

            // Hiển thị header ngay cả khi không có dữ liệu
            dgvBangChamCong.ColumnHeadersVisible = true;

            // Nếu không có dữ liệu, đảm bảo header vẫn hiển thị
            if (dgvBangChamCong.Rows.Count == 0)
            {
                dgvBangChamCong.Rows.Add();  // Thêm một dòng trống nếu không có dữ liệu
            }


            dgvBangChamCong.Columns["AttendanceID"].HeaderText = "Mã chấm công";
            dgvBangChamCong.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvBangChamCong.Columns["WorkDate"].HeaderText = "Ngày";
            dgvBangChamCong.Columns["CheckIn"].HeaderText = "Giờ vào";
            dgvBangChamCong.Columns["CheckOut"].HeaderText = "Giờ ra";
            dgvBangChamCong.Columns["OvertimeHours"].HeaderText = "Giờ tăng ca";
            dgvBangChamCong.Columns["AbsenceStatus"].HeaderText = "Trạng thái";
        }



        // Ẩn tất cả các panel
        private void HideAllPanels()
        {
            panelThongTin_CaNhan.Visible = false;
            panelThongTin_BangLuong.Visible = false;
            panelThongTin_ChamCong.Visible = false;
            panelTrangChu_user.Visible = false;
            panelThongTin.Visible = false;
        }

        private void dgvBangChamCong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu cột hiện tại là cột AbsenceStatus (giả sử cột AbsenceStatus là cột thứ 6)
            if (dgvBangChamCong.Columns[e.ColumnIndex].Name == "AbsenceStatus")
            {
                if (e.Value != null)
                {
                    // Thay đổi giá trị hiển thị
                    if (e.Value.ToString() == "Absent")
                    {
                        e.Value = "Vắng";
                    }
                    else if (e.Value.ToString() == "Present")
                    {
                        e.Value = "Có mặt";
                    }
                }
            }
        }

        private void btnChamCongHomNay_Click(object sender, EventArgs e)
        {
            string ketQua = attendanceBUS.ChamCong(user_id);

            // Hiển thị thông báo tùy vào nội dung trả về
            if (ketQua.ToLower().Contains("check-in"))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Bạn đã Check - in, nhớ Check - out nha !", "Thành công!");
                btnChamCongHomNay.Text = "Check - out";
            }
            else if (ketQua.ToLower().Contains("check-out"))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Check - out thành công, Bạn đã chấm công ngày hôm nay !", "Thành công!");
                btnChamCongHomNay.Text = "Đã chấm công !";
                btnChamCongHomNay.Enabled = false;
                lblTrangThai.Text = "Đã chấm công";
            }
            else
            {
                // Nếu đã chấm công cả hai lần
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn đã chấm công xong hôm nay.", "Thông báo");
            }

            // Load lại bảng dữ liệu
            TaiDuLieuBangChamCong();
        }
    }
}
