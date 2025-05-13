using CompanyHRManagement.BUS;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CompanyHRManagement.BUS._ado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private DashBoardBUS db_BUS = new DashBoardBUS();
        private UserBUS userBUS = new UserBUS();

        private string fullname;
        private string username;
        private string role;
        private string name_dapartment;


        public MainForm_user(string username)
        {
            var userInfo = userBUS.getInfoUser(username);
            this.username = userInfo.Username;
            this.fullname = userInfo.FullName;
            this.role = userInfo.Role;
            this.name_dapartment = db_BUS.GetDepartmentNameById(userInfo.UserID);
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            lblHoTen.Text = "Họ tên: " + this.fullname;
            lblChucVu.Text = "Chức vụ: Nhân viên";
            lblPhongBan.Text = "Phòng ban: " + name_dapartment;
        }


        private void LoadSalaryChart()
        {
            var data = db_BUS.GetSalaryChartData(userBUS.getInfoUser(this.username).UserID);

            chartSalary.Series.Clear();
            chartSalary.ChartAreas.Clear();
            chartSalary.ChartAreas.Add(new ChartArea("Area"));

            ChartArea chartArea = chartSalary.ChartAreas[0];

            // Định dạng trục Y hiển thị đơn vị tiền (VD: 10,000 VNĐ)
            chartArea.AxisY.LabelStyle.Format = "#,##0 'VNĐ'";
            chartArea.AxisY.Title = "Tổng lương (VNĐ)";
            chartArea.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold);
            chartArea.AxisY.TitleForeColor = Color.DarkGreen;

            // Đặt tiêu đề trục X nếu cần
            chartArea.AxisX.Title = "Tháng";
            chartArea.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold);

            Series series = new Series("Tổng lương")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Orange
            };

            foreach (var item in data)
            {
                series.Points.AddXY(item.MonthYear, item.TotalSalary);
            }

            chartSalary.Series.Add(series);
        }


        private void LoadAttendanceChart()
        {
            var data = db_BUS.GetAttendanceChartData(userBUS.getInfoUser(this.username).UserID);

            chartAttendance.Series.Clear();
            chartAttendance.ChartAreas.Clear();
            chartAttendance.ChartAreas.Add(new ChartArea("Area"));

            Series series = new Series("Ngày công") { ChartType = SeriesChartType.Column };

            foreach (var item in data)
            {
                series.Points.AddXY(item.MonthYear, item.WorkDays);
            }

            chartAttendance.Series.Add(series);

            // Đơn vị trục Y
            chartAttendance.ChartAreas[0].AxisY.Title = "Số ngày công";
        }




        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSalaryChart();
            LoadAttendanceChart();
            LoadDashboardData();
            lblUsername.Text = this.fullname;
            lblRole.Text = "Quyền hạn: " + this.role;
            lblXinChao.Text = "Xin chào: " + this.fullname + " !";
            timerClock.Start();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn thoát ?", "Xác nhận thoát");

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
            panelTrangChu_user.Visible = false;
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
            //panelNhanVien.BringToFront(); // Quan trọng nếu các panel chồng lên nhau
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            panelTrangChu_user.Visible = true;
            //panelTrangChu.BringToFront(); // Quan trọng nếu các panel chồng lên nhau
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.Yes)
            {
                LoginForm lg = new LoginForm();
                lg.Show();
                this.Hide();
            }
        }
    }
}
