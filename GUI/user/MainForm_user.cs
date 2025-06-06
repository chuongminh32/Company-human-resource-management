﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using CompanyHRManagement.DAL._ado;
using CompanyHRManagement.Models;
using static Guna.UI2.Native.WinApi;
using System.Text.RegularExpressions;


namespace CompanyHRManagement.GUI.user
{
    public partial class MainForm_user : Form
    {
        private readonly DashBoardBUS db_BUS = new DashBoardBUS();
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private AttendanceBUS attendanceBUS = new AttendanceBUS();
        private SalaryBUS salaryBUS = new SalaryBUS();
        private LeavesBUS leaveBUS = new LeavesBUS();
        private MessageBUS messageBUS = new MessageBUS();
        private RewardBUS rewardBUS = new RewardBUS();
        private DisciplineBUS disciplineBUS = new DisciplineBUS();
        private LoginForm login = new LoginForm();
        private PositionBUS positionBUS = new PositionBUS();

        private string fullname;
        private int user_id;
        private string email;
        private string name_dapartment;
        private string name_position;
        private List<Guna2Button> navButtons;

        private int editingLeaveID = -1;
        private int editingMessageID = -1;



        // Constructor
        public MainForm_user(string email, LoginForm login)
        {
            Employee emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            this.email = email;
            this.user_id = emp.EmployeeID;
            this.fullname = emp.FullName;
            this.name_dapartment = db_BUS.LayTenPhongBanQuaID(emp.EmployeeID);
            this.name_position = positionBUS.LayTenChucVuTheoID(emp.PositionID);
            this.login = login;




            InitializeComponent();
        }

        // Load form
        private void MainForm_Load(object sender, EventArgs e)
        {
            TaiDuLieuNhanVienVaoCBB();
            TaiTinNhanGuiDi();
            TaiTinNhanMoiNhan();
            TaiLaiTatCaDuLieu();

            lblUsername.Text = fullname;
            lblRole.Text = "Quyền hạn:" + name_position;
            lblXinChao.Text = "Xin chào: " + fullname + " !";
            lblPhongBan.Text = "Phòng ban: " + name_dapartment;

            // Gán mặc định là hôm nay
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today;

            // Gán luôn cho label tương ứng
            lblNgayBatDau.Text = dtpNgayBatDau.Value.ToString("dd/MM/yyyy");
            lblNgayKetThuc.Text = dtpNgayKetThuc.Value.ToString("dd/MM/yyyy");


            timerClock.Start();
            KhoiTaoDanhSachNutDieuHuong();
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog.Show("Bạn thực sự muốn đăng xuất ?", "Xác nhận thoát");
            if (result == DialogResult.Yes)
            {
                login.ResetFields();
                this.Close(); // Đóng MainForm (sẽ kích hoạt sự kiện FormClosed ở LoginForm)
            }

        }


        // --------- BUTTON ---------
        // Khởi tạo các nút điều hướng
        private void KhoiTaoDanhSachNutDieuHuong()
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
        private void TaiThongTinNhanVien(int employeeID)
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

        private void TaiDuLieuLenDashBoard()
        {
            lblUsername.Text = fullname;
            lblXinChao.Text = "Xin chào: " + fullname + " !";
            lblHoTen.Text = "Họ tên: " + fullname;
            lblChucVu.Text = "Chức vụ: " + name_position;
            lblPhongBan.Text = "Phòng ban: " + name_dapartment;
        }

        private void TaiBieuDoLuong()
        {
            // Lấy dữ liệu tổng lương theo từng tháng của user
            var data = db_BUS.LayDuLieuLuong(user_id);

            // Xóa toàn bộ series (dữ liệu cũ) và vùng biểu đồ hiện có
            chartSalary.Series.Clear();
            chartSalary.ChartAreas.Clear();

            // Tạo vùng biểu đồ mới tên là "Area"
            chartSalary.ChartAreas.Add(new ChartArea("Area"));

            // Cấu hình trục Y
            var area = chartSalary.ChartAreas[0];
            area.AxisY.LabelStyle.Format = "#,##0 'VNĐ'"; // Hiển thị đơn vị VNĐ
            area.AxisY.Title = "Tổng lương (VNĐ)"; // Tiêu đề trục Y
            area.AxisY.TitleFont = new Font("Arial", 10, FontStyle.Bold); // Font tiêu đề trục Y
            area.AxisY.TitleForeColor = Color.DarkGreen; // Màu chữ tiêu đề trục Y

            // Cấu hình trục X
            area.AxisX.Title = "Tháng"; // Tiêu đề trục X
            area.AxisX.TitleFont = new Font("Arial", 10, FontStyle.Bold); // Font tiêu đề trục X

            // Tạo series (tập dữ liệu) mới cho cột "Tổng lương"
            var series = new Series("Tổng lương")
            {
                ChartType = SeriesChartType.Column, // Kiểu biểu đồ cột
                Color = Color.Orange // Màu cột
            };

            // Thêm dữ liệu vào biểu đồ: trục X là tháng, trục Y là tổng lương
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.TotalSalary));

            // Thêm series vào biểu đồ
            chartSalary.Series.Add(series);
        }

        private void TaiBieuDoCong()
        {
            // Lấy dữ liệu số ngày làm việc theo từng tháng của user
            var data = db_BUS.LayDuLieuChamCong(user_id);

            // Xóa dữ liệu và biểu đồ cũ
            chartAttendance.Series.Clear();
            chartAttendance.ChartAreas.Clear();

            // Tạo vùng biểu đồ mới
            chartAttendance.ChartAreas.Add(new ChartArea("Area"));

            // Tạo series mới để hiển thị "Ngày công"
            var series = new Series("Ngày công")
            {
                ChartType = SeriesChartType.Column // Kiểu biểu đồ cột
            };

            // Thêm dữ liệu vào biểu đồ: trục X là tháng, trục Y là số ngày làm việc
            data.ForEach(item => series.Points.AddXY(item.MonthYear, item.WorkDays));

            // Thêm series vào biểu đồ
            chartAttendance.Series.Add(series);

            // Cấu hình tiêu đề trục Y
            chartAttendance.ChartAreas[0].AxisY.Title = "Số ngày công";
        }


        private void TaiDuLieuMoiCapNhat()
        {
            Employee emp = employeeBUS.LayDuLieuNhanVienQuaEmail(email);
            fullname = emp.FullName;
            name_dapartment = db_BUS.LayTenPhongBanQuaID(emp.DepartmentID);
            name_position = db_BUS.LayTenViTriChucVu(emp.EmployeeID);

            TaiDuLieuLenDashBoard();

        }

        private void TaiLaiTatCaDuLieu()
        {
            // Reset panel giao diện
            AnTatCaPanel();
            TaiBieuDoLuong();  // Tải lại biểu đồ lương
            TaiBieuDoCong();  // Tải lại biểu đồ ngày công
            TaiDuLieuLenDashBoard();  // Tải lại các thông tin tổng quan như tên, chức vụ
            TaiThongTinNhanVien(user_id); // Tải lại thông tin nhân viên

            panelTrangChu_user.Visible = true;
        }


        // Đồng hồ
        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time:  " + DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = "Today:  " + DateTime.Now.ToString("dd/MM/yyyy");
        }


        // -------- BUTTON - CLICK --------- 
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelTrangChu_user.Visible = true;

        }




        // ---------- TRANG THÔNG TIN CÁ NHÂN -----------
        private void btnThongTin_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;

        }

        // Click nút lưu thông tin cá nhân 
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra định dạng Email
            string email = txtEmail.Text.Trim();
            string phone = txtSDT.Text.Trim();

            // Regex kiểm tra email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Regex kiểm tra số điện thoại Việt Nam (10 chữ số, bắt đầu bằng 03, 05, 07, 08, 09)
            string phonePattern = @"^(03|05|07|08|09)\d{8}$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                guna2MessageDialog2.Icon = MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Email không hợp lệ. Vui lòng nhập lại.", "Thông báo");
                return;
            }

            if (!Regex.IsMatch(phone, phonePattern))
            {
                guna2MessageDialog2.Icon = MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.", "Thông báo");
                return;
            }
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
                TaiDuLieuMoiCapNhat();
            }
        }

        // click nút làm mới ở trang thông tin cá nhân 
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            TaiLaiTatCaDuLieu();
            panelThongTin.Visible = true;
            panelThongTin_CaNhan.Visible = true;
        }

        // click icon reload    
        private void btnReload_Click(object sender, EventArgs e)
        {

            TaiLaiTatCaDuLieu();
        }





        // ------------ CHỨC NĂNG CHẤM CÔNG ------------
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_ChamCong.Visible = true;
            TaiDuLieuBangChamCong();  // Tải lại bảng dữ liệu chấm công
            DinhDangDGV(dgvBangChamCong);
        }

        private void TaiDuLieuBangChamCong()
        {
            var list = attendanceBUS.LayDuLieuChamCongQuaID(user_id);
            dgvBangChamCong.DataSource = list;
            // cập nhật lại các thông tin chấm công 
            lblID.Text = user_id.ToString();
            lblNgayHomNay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblSoNgayCong.Text = attendanceBUS.laySoNgayCongTrongThangHienTaiTheoID(user_id).ToString();
            lblTongGioLam.Text = attendanceBUS.layTongGioLamTrongThangHienTaiTheoID(user_id).ToString();

            // định dạng cột trong dgv
            dgvBangChamCong.Columns["AttendanceID"].HeaderText = "Mã chấm công";
            dgvBangChamCong.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvBangChamCong.Columns["WorkDate"].HeaderText = "Ngày";
            dgvBangChamCong.Columns["CheckIn"].HeaderText = "Giờ vào";
            dgvBangChamCong.Columns["CheckOut"].HeaderText = "Giờ ra";
            dgvBangChamCong.Columns["OvertimeHours"].HeaderText = "Giờ tăng ca";
            dgvBangChamCong.Columns["AbsenceStatus"].HeaderText = "Trạng thái";

            dgvBangChamCong.Columns["MonthYear"].Visible = false;
            dgvBangChamCong.Columns["WorkDays"].Visible = false;

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
                btnChamCongHomNay.Enabled = false;
                lblTrangThai.Text = "Đã chấm công";
            }

            // Load lại bảng dữ liệu
            TaiDuLieuBangChamCong();
        }



        // ------------ CHỨC NĂNG TÍNH LƯƠNG ------------
        private void btnBangLuongCaNhan_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelThongTin.Visible = true;
            panelThongTin_BangLuong.Visible = true;
            TaiLuongNhanVien(user_id);
            TaiThuongNhanVien(user_id);
            TaiPhatNhanVien(user_id);
            DinhDangDGV(dgvLuong);
            DinhDangDGV(dgvPhat);
            DinhDangDGV(dgvThuong);


        }

        private void TaiThuongNhanVien(int employeeId)
        {
            // Lấy dữ liệu từ BUS 
            var table = rewardBUS.LayDanhSachThuongTheoNhanVien(employeeId);

            // Gán dữ liệu vào DataGridView
            dgvThuong.DataSource = table;

            // Đặt tiêu đề cột
            dgvThuong.Columns["RewardID"].HeaderText = "Mã thưởng";
            dgvThuong.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvThuong.Columns["Reason"].HeaderText = "Lý do";
            dgvThuong.Columns["RewardDate"].HeaderText = "Ngày thưởng";
            dgvThuong.Columns["Amount"].HeaderText = "Số tiền thưởng";
            dgvLuong.Columns["FullName"].Visible = false;

        }



        private void TaiPhatNhanVien(int employeeId)
        {
            var table = disciplineBUS.LayDanhSachPhatTheoNhanVien(employeeId);
            dgvPhat.DataSource = table;

            // Đổi tiêu đề các cột
            dgvPhat.Columns["DisciplineID"].HeaderText = "Mã kỷ luật";
            dgvPhat.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvPhat.Columns["Reason"].HeaderText = "Lý do";
            dgvPhat.Columns["DisciplineDate"].HeaderText = "Ngày kỷ luật";
            dgvPhat.Columns["Amount"].HeaderText = "Số tiền phạt";

            // Định dạng cột số tiền
            dgvPhat.Columns["Amount"].DefaultCellStyle.Format = "N0";
            dgvLuong.Columns["FullName"].Visible = false;

        }

        private void TaiLuongNhanVien(int employeeId)
        {
            var list = salaryBUS.LayLuongTheoNhanVien(employeeId);
            dgvLuong.DataSource = list;
            //  Đổi tiêu đề cột cho dễ hiểu
            dgvLuong.Columns["SalaryID"].HeaderText = "Mã lương";
            dgvLuong.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvLuong.Columns["BaseSalary"].HeaderText = "Lương cơ bản";
            dgvLuong.Columns["Allowance"].HeaderText = "Phụ cấp";
            dgvLuong.Columns["Bonus"].HeaderText = "Thưởng";
            dgvLuong.Columns["Penalty"].HeaderText = "Phạt";
            dgvLuong.Columns["OvertimeHours"].HeaderText = "Giờ tăng ca";
            dgvLuong.Columns["SalaryMonth"].HeaderText = "Tháng";
            dgvLuong.Columns["SalaryYear"].HeaderText = "Năm";
            // Ẩn các cột không muốn hiển thị
            dgvLuong.Columns["FullName"].Visible = false;
            dgvLuong.Columns["TotalSalary"].Visible = false;

        }
        private void btnTinhTongLuong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tháng và năm từ ComboBox
                int thang = Convert.ToInt32(cbbThang.SelectedItem);
                int nam = Convert.ToInt32(cbbNam.SelectedItem);

                if (thang.ToString() == "0" || nam.ToString() == "0")
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                    guna2MessageDialog2.Show("Bạn chưa chọn tháng hoặc năm!", "Cảnh báo");
                    return;
                }
                // Tính tổng lương
                decimal tongLuong = salaryBUS.TinhTongLuongTheoThangNam(user_id, thang, nam);

                // Hiển thị tổng lương định dạng theo tiền Việt
                lblTongLuong.Text = $"{tongLuong.ToString("C0", new System.Globalization.CultureInfo("vi-VN"))}";
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Đã xảy ra lỗi khi tính tổng lương:\n" + ex.Message, "Lỗi");
            }

        }





        // ------------ CHỨC NĂNG NGHỈ PHÉP ------------
        private void btnNghiPhep_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelNghiPhep.Visible = true;

            TaiDuLuNghiPhepNhanVien();
            DinhDangDGV(dgvNghiPhep);
        }

        // tải dữ liệu nghỉ phép của nhân viên
        public void TaiDuLuNghiPhepNhanVien()
        {
            DataTable db = new DataTable();
            db = leaveBUS.LayDuLieuNghiPhepTheoIDNhanVien(user_id);
            dgvNghiPhep.DataSource = db;

            lbl_ID.Text = user_id.ToString();
            lblHoVaTen.Text = fullname;

            // (Tùy chọn) Đổi tiêu đề cột cho dễ hiểu
            dgvNghiPhep.Columns["leaveID"].HeaderText = "STT";
            dgvNghiPhep.Columns["EmployeeID"].HeaderText = "Mã nhân viên";
            dgvNghiPhep.Columns["startDate"].HeaderText = "Ngày bắt đầu";
            dgvNghiPhep.Columns["endDate"].HeaderText = "Ngày kết thúc";
            dgvNghiPhep.Columns["reason"].HeaderText = "Lý do";
            dgvNghiPhep.Columns["status"].HeaderText = "Trạng thái";
        }

        private void btnDangKyNghiPhep_Click(object sender, EventArgs e)
        {
            string lyDo = txtLyDo.Text;

            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;

            if (lyDo.Equals(""))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn chưa nhập lý do nghỉ phép!", "Cảnh báo");
                return;
            }
            // Kiểm tra xem ngày bắt đầu và ngày kết thúc có hợp lệ không
            if (ngayBatDau > ngayKetThuc)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo");
                return;
            }
            TimeSpan timeSpan = ngayKetThuc - ngayBatDau;
            if (timeSpan.Days > 30)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Thời gian nghỉ phép không được quá 30 ngày!", "Cảnh báo");
                return;
            }

            // Gọi hàm cập nhật
            bool ketQua = leaveBUS.ThemNghiPhep(user_id, ngayBatDau, ngayKetThuc, lyDo);

            if (ketQua)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Đăng kí nghỉ phép thành công!", "Thông báo");
                TaiDuLuNghiPhepNhanVien();
                ;
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Cập nhật thất bại. Vui lòng kiểm tra lại!", "Lỗi");
            }

        }

        private void dgvNghiPhep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNghiPhep.Rows[e.RowIndex];

            try
            {
                // --- Lấy dữ liệu dòng click và hiển thị lên control ---
                txtLyDo.Text = row.Cells["reason"].Value?.ToString() ?? "";
                lblNgayBatDau.Text = Convert.ToDateTime(row.Cells["startDate"].Value).ToString("dd/MM/yyyy");
                lblNgayKetThuc.Text = Convert.ToDateTime(row.Cells["endDate"].Value).ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi");
                return;
            }

            string columnName = dgvNghiPhep.Columns[e.ColumnIndex].Name;

            // --- Nếu click vào nút Sửa ---
            if (columnName == "btnEdit")
            {
                try
                {
                    txtLyDo.Text = row.Cells["reason"].Value?.ToString() ?? "";
                    dtpNgayBatDau.Value = Convert.ToDateTime(row.Cells["startDate"].Value);
                    dtpNgayKetThuc.Value = Convert.ToDateTime(row.Cells["endDate"].Value);
                    // Ghi nhớ ID để cập nhật sau
                    editingLeaveID = Convert.ToInt32(row.Cells["leaveID"].Value);
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi");
                }
            }

            // --- Nếu click vào nút Xóa ---
            if (columnName == "btnDelete")
            {
                try
                {
                    int leaveID = Convert.ToInt32(row.Cells["leaveID"].Value);

                    // Hiển thị hộp thoại xác nhận
                    guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    var result = guna2MessageDialog.Show("Bạn thực sự muốn xóa ?", "Xác nhận xóa");

                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện xóa
                        bool success = leaveBUS.XoaNghiPhep(leaveID);
                        if (success)
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog2.Show("Xóa thành công!", "Thành công");
                            TaiDuLuNghiPhepNhanVien(); // reload lại DataGridView
                        }
                        else
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            guna2MessageDialog2.Show("Xóa thất bại", "Lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            lblNgayBatDau.Text = dtpNgayBatDau.Value.ToString("dd/MM/yyyy");

        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            lblNgayKetThuc.Text = dtpNgayKetThuc.Value.ToString("dd/MM/yyyy");

        }

        private void btnSua_NghiPhep_Click(object sender, EventArgs e)
        {
            if (editingLeaveID == -1)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Vui lòng chọn dòng cần sửa!", "Cảnh báo");
                return;
            }

            // Lấy dữ liệu từ form
            string lyDo = txtLyDo.Text.Trim();
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date;

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(lyDo))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Lý do không được để trống!", "Cảnh báo");
                return;
            }

            // Tạo đối tượng mới để cập nhật
            Leave leave = new Leave
            {
                LeaveID = editingLeaveID,
                Reason = lyDo,
                StartDate = ngayBatDau,
                EndDate = ngayKetThuc
            };

            // Gọi hàm cập nhật từ BUS
            bool success = leaveBUS.SuaNghiPhep(leave);

            if (success)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                guna2MessageDialog2.Show("Cập nhật thành công!", "Thành công");

                // Làm mới lại bảng và form
                TaiDuLuNghiPhepNhanVien();
                editingLeaveID = -1;
            }
            else
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Cập nhật thất bại!", "Lỗi");
            }
        }




        // ------------ CHỨC NĂNG CHAT ------------
        private void btnNhanTin_Click(object sender, EventArgs e)
        {
            AnTatCaPanel();
            panelChat.Visible = true;
        }
        private void TaiDuLieuNhanVienVaoCBB()
        {
            List<Employee> employees = employeeBUS.GetAllEmployees();
            cbbNhanVien.DataSource = employees;
            cbbNhanVien.DisplayMember = "FullName";
            cbbNhanVien.ValueMember = "EmployeeID";
        }

        private void TaiTinNhanGuiDi()
        {
            // Lấy danh sách tin nhắn đã gửi (phải là từ SenderID)
            var list = messageBUS.TaiBangGuiTinNhan(user_id);

            // Gán dữ liệu vào DataGridView hiển thị tin nhắn đã gửi
            dgvTinNhanGui.DataSource = list;

            // Đặt lại tên các cột hiển thị
            dgvTinNhanGui.Columns["ReceiverName"].HeaderText = "Người nhận";
            dgvTinNhanGui.Columns["Content"].HeaderText = "Nội dung";
            dgvTinNhanGui.Columns["SentAt"].HeaderText = "Thời điểm";

            // Ẩn các cột không cần thiết
            if (dgvTinNhanGui.Columns.Contains("SenderID"))
                dgvTinNhanGui.Columns["SenderID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("ReceiverID"))
                dgvTinNhanGui.Columns["ReceiverID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("MessageID"))
                dgvTinNhanGui.Columns["MessageID"].Visible = false;
            if (dgvTinNhanGui.Columns.Contains("SenderName"))
                dgvTinNhanGui.Columns["SenderName"].Visible = false;

            DinhDangDGV(dgvTinNhanGui);
            ThemCotChucNangChoDGV();

        }

        private void TaiTinNhanMoiNhan()
        {
            // Lấy danh sách tin nhắn đã nhận
            var list = messageBUS.TaiBangNhanTinNhanMoi(user_id);

            // Gán dữ liệu vào DataGridView hiển thị tin nhắn nhận
            dgvTinNhanNhan.DataSource = list;

            // Đặt lại tên các cột hiển thị
            dgvTinNhanNhan.Columns["SenderName"].HeaderText = "Người gửi";
            dgvTinNhanNhan.Columns["Content"].HeaderText = "Nội dung";
            dgvTinNhanNhan.Columns["SentAt"].HeaderText = "Thời điểm";

            // Ẩn các cột không cần hiển thị nếu có
            if (dgvTinNhanNhan.Columns.Contains("SenderID"))
                dgvTinNhanNhan.Columns["SenderID"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("ReceiverID"))
                dgvTinNhanNhan.Columns["ReceiverID"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("ReceiverName"))
                dgvTinNhanNhan.Columns["ReceiverName"].Visible = false;
            if (dgvTinNhanNhan.Columns.Contains("MessageID"))
                dgvTinNhanNhan.Columns["MessageID"].Visible = false;

            // Gọi hàm định dạng giao diện bảng
            DinhDangDGV(dgvTinNhanNhan);
        }

        // Xử lý sự kiện click vào nút gửi tin nhắn(có thể thêm/sửa)
        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Vui lòng nhập nội dung.", "Thông báo");
                return;
            }

            int senderId = user_id;
            int receiverId = Convert.ToInt32(cbbNhanVien.SelectedValue);
            if (receiverId == 0)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Vui lòng chọn người nhận.", "Thông báo");
                return;
            }

            if (senderId == receiverId)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                guna2MessageDialog2.Show("Bạn không thể gửi tin nhắn cho chính mình.", "Thông báo");
                return;
            }

            string content = txtNoiDung.Text.Trim();

            bool success = false;

            //  Nếu đang ở chế độ chỉnh sửa tin nhắn
            if (editingMessageID != -1)
            {
                success = messageBUS.CapNhatTinNhan(editingMessageID, senderId, receiverId, content);

                if (success)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog2.Show("Cập nhật tin nhắn thành công!", "Thông báo");
                    editingMessageID = -1; // reset về chế độ gửi mới
                    txtNoiDung.Clear();
                    TaiTinNhanGuiDi();
                }
                else
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Cập nhật thất bại!", "Lỗi");
                }
            }
            else
            {
                //  Gửi mới
                success = messageBUS.GuiTin(senderId, receiverId, content);

                if (success)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog2.Show("Gửi thành công!", "Thông báo");
                    txtNoiDung.Clear();
                    TaiTinNhanGuiDi();
                }
                else
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Gửi thất bại!", "Thông báo");
                }
            }
        }

        private void ThemCotChucNangChoDGV()
        {
            // Xóa cột nút nếu đã tồn tại để tránh thêm nhiều lần
            if (dgvTinNhanGui.Columns.Contains("btnEdit"))
                dgvTinNhanGui.Columns.Remove("btnEdit");
            if (dgvTinNhanGui.Columns.Contains("btnDelete"))
                dgvTinNhanGui.Columns.Remove("btnDelete");

            // Tạo cột nút Sửa
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.Name = "btnEdit";
            btnEdit.HeaderText = "Sửa";
            btnEdit.Text = "✏";
            btnEdit.UseColumnTextForButtonValue = true;
            dgvTinNhanGui.Columns.Add(btnEdit);

            // Tạo cột nút Xóa
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "btnDelete";
            btnDelete.HeaderText = "Xóa";
            btnDelete.Text = "❌";
            btnDelete.UseColumnTextForButtonValue = true;
            dgvTinNhanGui.Columns.Add(btnDelete);
        }

        private void dgvTinNhanGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo không click vào header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTinNhanGui.Rows[e.RowIndex];

            try
            {
                // Hiển thị nội dung và người nhận
                txtNoiDung.Text = row.Cells["Content"].Value?.ToString() ?? "";
                // Gán người nhận dựa trên ID
                int receiverID = Convert.ToInt32(row.Cells["ReceiverID"].Value);
                cbbNhanVien.SelectedValue = receiverID;  // sẽ hiện FullName trong ComboBox
            }
            catch (Exception ex)
            {
                guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                guna2MessageDialog2.Show("Lỗi khi hiển thị dữ liệu: " + ex.Message, "Lỗi");
                return;
            }

            string columnName = dgvTinNhanGui.Columns[e.ColumnIndex].Name;

            // --- Nếu click nút Sửa ---
            if (columnName == "btnEdit")
            {
                try
                {
                    // Hiển thị nội dung và người nhận
                    txtNoiDung.Text = row.Cells["content"].Value?.ToString() ?? "";
                    cbbNhanVien.SelectedValue = Convert.ToInt32(row.Cells["receiverID"].Value);

                    // biến toàn cục để lưu ID đang sửa -> click nút sửa sẽ cập nhật
                    editingMessageID = Convert.ToInt32(row.Cells["messageID"].Value);
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi");
                }
            }

            // --- Nếu click nút Xóa ---
            if (columnName == "btnDelete")
            {
                try
                {
                    int messageID = Convert.ToInt32(row.Cells["messageID"].Value);

                    guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    var result = guna2MessageDialog.Show($"Bạn có chắc muốn xóa tin nhắn này? {messageID}", "Xác nhận xóa");

                    if (result == DialogResult.Yes)
                    {
                        bool success = messageBUS.XoaTin(messageID);
                        if (success)
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                            guna2MessageDialog2.Show("Xóa thành công!", "Thành công");
                            TaiTinNhanGuiDi();
                        }
                        else
                        {
                            guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                            guna2MessageDialog2.Show("Xóa thất bại!", "Lỗi");
                        }
                    }
                }
                catch (Exception ex)
                {
                    guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    guna2MessageDialog2.Show("Lỗi khi xóa: " + ex.Message, "Lỗi");
                }
            }
        }


        // Định dạng DataGridView
        private void DinhDangDGV(DataGridView dgv)
        {
            // Tạo kiểu định dạng dùng chung
            DataGridViewCellStyle commonStyle = new DataGridViewCellStyle();
            commonStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            commonStyle.ForeColor = Color.Black;
            commonStyle.BackColor = Color.White;
            commonStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            commonStyle.SelectionBackColor = Color.LightSkyBlue;

            // Áp dụng cho dòng lẻ
            dgv.RowsDefaultCellStyle = commonStyle;

            // Áp dụng giống hệt cho dòng chẵn
            dgv.AlternatingRowsDefaultCellStyle = commonStyle;

            // Header
            dgv.ColumnHeadersHeight = 64;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Grid và border
            dgv.GridColor = Color.DarkGray;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // Khóa sửa
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;


        }


        // Ẩn tất cả các panel
        private void AnTatCaPanel()
        {
            panelThongTin_CaNhan.Visible = false;
            panelThongTin_BangLuong.Visible = false;
            panelThongTin_ChamCong.Visible = false;
            panelTrangChu_user.Visible = false;
            panelThongTin.Visible = false;
            panelNghiPhep.Visible = false;
            panelChat.Visible = false;
        }
    }
}
