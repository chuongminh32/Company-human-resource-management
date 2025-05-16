using CompanyHRManagement.BUS;
using CompanyHRManagement.BUS._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;




namespace CompanyHRManagement.GUI.admin
{
    public partial class MainForm_admin : Form
    {
        //private UserDAO userDAO = new UserDAO();
        private DashBoardBUS db_BUS = new DashBoardBUS();
        private UserBUS userBUS = new UserBUS();
        private EmployeeBUS employeeBUS = new EmployeeBUS();
        private Employee emp = new Employee();
        private string fullname;
        private string role;


        public MainForm_admin(string email)
        {
            this.emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            this.fullname = emp.FullName;
            this.role = db_BUS.LayTenViTriChucVu(emp.EmployeeID);
            InitializeComponent();
        }

        private string FormatMoneyCompact(decimal amount)
        {
            if (amount >= 1_000_000_000)
                return (amount / 1_000_000_000M).ToString("0.#") + "B"; // Tỷ
            else if (amount >= 1_000_000)
                return (amount / 1_000_000M).ToString("0.#") + "M";     // Triệu
            else if (amount >= 1_000)
                return (amount / 1_000M).ToString("0.#") + "K";         // Ngàn
            else
                return amount.ToString("0");
        }


        // Load dữ liệu cho bảng điều khiển
        private void LoadDashboardData()
        {
            lblTongNhanVien.Text = db_BUS.GetTotalEmployees().ToString();
            lblSoPhongBan.Text = db_BUS.GetTotalDepartments().ToString();
            lblSoChucVu.Text = db_BUS.GetTotalPositions().ToString();
            lblNhanVienThuViec.Text = db_BUS.GetProbationCount().ToString();
            decimal totalRewardSalary = db_BUS.GetToTalRewardSalary();
            lblTongLuongThuong.Text = FormatMoneyCompact(totalRewardSalary);
            lblSoBaoHiemConHan.Text = db_BUS.GetTotalValidInsurances().ToString();
        }

        // char nhân viên theo phòng ban 
        private void LoadChart()
        {
            var data = db_BUS.GetEmployeeStats();

            chartNhanVienPhongBan.Series.Clear();
            chartNhanVienPhongBan.ChartAreas.Clear();
            chartNhanVienPhongBan.ChartAreas.Add(new ChartArea("MainArea"));
            chartNhanVienPhongBan.Series.Add("Nhân viên");
            chartNhanVienPhongBan.Series["Nhân viên"].ChartType = SeriesChartType.Column;

            foreach (var item in data)
            {
                chartNhanVienPhongBan.Series["Nhân viên"].Points.AddXY(item.Key, item.Value);
            }

        }

        // lỗi chưa hiển thị được % lên biêu đồ .....
        private void LoadSalaryPieChart()
        {
            // Lấy dữ liệu tổng lương theo năm
            DataTable dt = db_BUS.GetSalaryStructureThisYear();
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            // Đọc từng phần lương
            decimal baseSalary = Convert.ToDecimal(row["TotalBaseSalary"]);
            decimal allowance = Convert.ToDecimal(row["TotalAllowance"]);
            decimal bonus = Convert.ToDecimal(row["TotalBonus"]);
            decimal penalty = Convert.ToDecimal(row["TotalPenalty"]);
            int overtimeHours = Convert.ToInt32(row["TotalOvertime"]);
            decimal overtimePay = overtimeHours * 200000; // Giả định 200k/h tăng ca

            // Gom vào dictionary để tiện xử lý
            Dictionary<string, decimal> salaryParts = new Dictionary<string, decimal>()
            {
                { "Lương cơ bản", baseSalary },
                { "Phụ cấp", allowance },
                { "Thưởng", bonus },
                { "Phạt", penalty },
                { "Tăng ca", overtimePay }
            };

            // Tính tổng lương
            decimal total = salaryParts.Values.Sum();

            // Reset biểu đồ
            chartSalary.Series.Clear();
            chartSalary.Titles.Clear();
            chartSalary.ChartAreas.Clear();

            chartSalary.ChartAreas.Add(new ChartArea("PieArea"));
            chartSalary.Titles.Add($"Cấu trúc lương năm {DateTime.Now.Year}");

            // Tạo series biểu đồ tròn
            Series series = new Series("Lương")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Transparent
            };

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in salaryParts)
            {
                double percent = (double)(item.Value / total) * 100;
                int pointIndex = series.Points.AddY(item.Value);

                // Hiển thị phần trăm trực tiếp trên label của mỗi điểm
                if (percent > 15)
                {
                    series.Points[pointIndex].Label = $"{percent:F1}%"; // Hiển thị phần trăm trực tiếp lên label
                }

                // Chú thích (legend bên phải)
                series.Points[pointIndex].LegendText = item.Key;
            }

            // Thêm series vào biểu đồ
            chartSalary.Series.Add(series);


            // Tùy chọn: hiển thị 3D nếu muốn đẹp hơn
            chartSalary.ChartAreas[0].Area3DStyle.Enable3D = true;
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

        private void HideAllPanels()
        {
            panelTrangChu_admin.Visible = false;
            panelNhanVien.Visible = false;
        }


        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt"); // Giờ:phút:giây AM/PM
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy"); // Ngày/tháng/năm
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelNhanVien.Visible = true;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTrangChu_admin.Visible = true;
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

        private void MainForm_user_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadDashboardData();
            LoadSalaryPieChart();
            lblUsername.Text = this.fullname;
            lblRole.Text = "Quyền hạn: " + this.role;
            lblXinChao.Text = "Xin chào: " + this.fullname + " !";
            timerClock.Start();
        }
    }
}
