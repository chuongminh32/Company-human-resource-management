using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using Guna.UI2.WinForms;

namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private readonly DashBoardBUS db_BUS = new DashBoardBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();

        private readonly string fullname;
        private readonly int user_id;
        private readonly string name_dapartment;
        private readonly string name_position;
        private List<Guna2Button> navButtons;

        public MainForm_user(string email)
        {
            Employee emp = employeeBUS.GetEmployeeByEmail(email);
            this.user_id = emp.EmployeeID;
            this.fullname = emp.FullName;
            this.name_dapartment = db_BUS.GetDepartmentNameById(emp.EmployeeID);
            this.name_position = db_BUS.GetPositionNameById(emp.PositionID);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReloadAllData();

            lblUsername.Text = fullname;
            lblRole.Text = "Quyền hạn: USER";
            lblXinChao.Text = "Xin chào: " + fullname + " !";

            timerClock.Start();
            InitNavButtons();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                BeginInvoke(new Action(Application.Exit));
        }

        private void InitNavButtons()
        {
            navButtons = new List<Guna2Button> { btnThongTin, btnTrangChu, btnNghiPhep, btnNhanTin, btnDangXuat };
            navButtons.ForEach(btn => btn.Click += NavButton_Click);
        }

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

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelThongTin.Visible = true;
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
                LoadEmployeeInfo(user_id);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadEmployeeInfo(user_id);
        }

        private void HideAllPanels()
        {
            panelTrangChu_user.Visible = false;
            panelThongTin.Visible = false;
        }

        private void ReloadAllData()
        {
            LoadSalaryChart();  // Tải lại biểu đồ lương
            LoadAttendanceChart();  // Tải lại biểu đồ ngày công
            LoadDashboardData();  // Tải lại các thông tin tổng quan như tên, chức vụ
            LoadEmployeeInfo(user_id); // Tải lại thông tin nhân viên

            // Reset panel giao diện
            HideAllPanels();
            panelTrangChu_user.Visible = true; // Hiển thị lại panel chính
        }


        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadAllData();
        }
    }
}
