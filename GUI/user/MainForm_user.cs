using CompanyHRManagement.BUS;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private DashBoardBUS db_BUS = new DashBoardBUS();
        private AuthenticationBUS authenticationBUS = new AuthenticationBUS();

        private string fullname;
        private string role;


        public MainForm_user(string username)
        {
            this.fullname = authenticationBUS.GetFullName(username);
            this.role = authenticationBUS.GetRole(username);
            InitializeComponent();
        }

        private void LoadDashboardData()
        {
            lblTongNhanVien.Text = db_BUS.GetTotalEmployees().ToString();
            lblSoPhongBan.Text = db_BUS.GetTotalDepartments().ToString();
            lblSoChucVu.Text = db_BUS.GetTotalPositions().ToString();
            lblNhanVienThuViec.Text = db_BUS.GetProbationCount().ToString();
        }


        private void LoadChart()
        {
            chartNhanVienPhongBan.Series.Clear();
            chartNhanVienPhongBan.ChartAreas.Clear();
            chartNhanVienPhongBan.ChartAreas.Add(new ChartArea("MainArea"));
            chartNhanVienPhongBan.Series.Add("Nhân viên");
            chartNhanVienPhongBan.Series["Nhân viên"].ChartType = SeriesChartType.Column;

            // Ví dụ: thêm dữ liệu
            chartNhanVienPhongBan.Series["Nhân viên"].Points.AddXY("Phòng IT", 10);
            chartNhanVienPhongBan.Series["Nhân viên"].Points.AddXY("Phòng Kế toán", 6);
            chartNhanVienPhongBan.Series["Nhân viên"].Points.AddXY("Phòng Nhân sự", 4);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadChart();
            LoadDashboardData();
            lblUsername.Text = this.fullname;
            lblRole.Text = "Quyền hạn: " + this.role;
            lblXinChao.Text = "Xin chào: " + this.fullname + " !";
            timerClock.Start();
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Tạo Guna2MessageDialog và cài đặt các thuộc tính
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");

            // xử lý kết quả
            if (result == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void HideAllPanels()
        {
            panelTrangChu.Visible = false;
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
            panelTrangChu.Visible = true;
            //panelTrangChu.BringToFront(); // Quan trọng nếu các panel chồng lên nhau
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void panelTrangChu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
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
    }
}
