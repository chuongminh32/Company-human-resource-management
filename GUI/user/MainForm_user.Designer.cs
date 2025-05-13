using System.Drawing;
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.user
{
    partial class MainForm_user
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanTin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNghiPhep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelTrangChu_user = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.panelDashBoard_User = new Guna.UI2.WinForms.Guna2Panel();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.panelInfoDB_admin = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Button21 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.lblRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.lblXinChao = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelThongTin = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgayVaoLam = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtbNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDaNghiViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIDNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbIDPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblThuViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGioiTinh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelTrangChu_user.SuspendLayout();
            this.panelDashBoard_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.panelInfoDB_admin.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2MessageDialog
            // 
            this.guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.guna2MessageDialog.Caption = null;
            this.guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog.Parent = this;
            this.guna2MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog.Text = null;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.sidebarPanel.Controls.Add(this.guna2Button18);
            this.sidebarPanel.Controls.Add(this.btnDangXuat);
            this.sidebarPanel.Controls.Add(this.guna2Button8);
            this.sidebarPanel.Controls.Add(this.btnNhanTin);
            this.sidebarPanel.Controls.Add(this.guna2Button4);
            this.sidebarPanel.Controls.Add(this.btnNghiPhep);
            this.sidebarPanel.Controls.Add(this.guna2Button2);
            this.sidebarPanel.Controls.Add(this.btnThongTin);
            this.sidebarPanel.Controls.Add(this.guna2Button1);
            this.sidebarPanel.Controls.Add(this.guna2Panel1);
            this.sidebarPanel.Controls.Add(this.guna2HtmlLabel4);
            this.sidebarPanel.Controls.Add(this.guna2PictureBox1);
            this.sidebarPanel.Controls.Add(this.guna2HtmlLabel3);
            this.sidebarPanel.Controls.Add(this.btnTrangChu);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(231, 787);
            this.sidebarPanel.TabIndex = 0;
            // 
            // guna2Button18
            // 
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 20;
            this.guna2Button18.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button18.ForeColor = System.Drawing.Color.White;
            this.guna2Button18.Image = global::CompanyHRManagement.Properties.Resources.logout;
            this.guna2Button18.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button18.Location = new System.Drawing.Point(24, 706);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(38, 36);
            this.guna2Button18.TabIndex = 49;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(15, 702);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 40);
            this.btnDangXuat.TabIndex = 48;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 20;
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button8.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button8.Location = new System.Drawing.Point(21, 370);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(38, 36);
            this.guna2Button8.TabIndex = 37;
            // 
            // btnNhanTin
            // 
            this.btnNhanTin.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanTin.FillColor = System.Drawing.Color.Transparent;
            this.btnNhanTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanTin.ForeColor = System.Drawing.Color.Black;
            this.btnNhanTin.Location = new System.Drawing.Point(12, 366);
            this.btnNhanTin.Name = "btnNhanTin";
            this.btnNhanTin.Size = new System.Drawing.Size(193, 40);
            this.btnNhanTin.TabIndex = 36;
            this.btnNhanTin.Text = "Nhắn tin";
            this.btnNhanTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(21, 301);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(38, 36);
            this.guna2Button4.TabIndex = 33;
            // 
            // btnNghiPhep
            // 
            this.btnNghiPhep.BackColor = System.Drawing.Color.Transparent;
            this.btnNghiPhep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNghiPhep.FillColor = System.Drawing.Color.Transparent;
            this.btnNghiPhep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNghiPhep.ForeColor = System.Drawing.Color.Black;
            this.btnNghiPhep.Location = new System.Drawing.Point(12, 297);
            this.btnNghiPhep.Name = "btnNghiPhep";
            this.btnNghiPhep.Size = new System.Drawing.Size(193, 40);
            this.btnNghiPhep.TabIndex = 32;
            this.btnNghiPhep.Text = "Nghỉ phép";
            this.btnNghiPhep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Image = global::CompanyHRManagement.Properties.Resources.staff;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(21, 236);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(38, 36);
            this.guna2Button2.TabIndex = 31;
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.FillColor = System.Drawing.Color.Transparent;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Black;
            this.btnThongTin.Location = new System.Drawing.Point(12, 232);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(193, 40);
            this.btnThongTin.TabIndex = 30;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(21, 167);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(38, 36);
            this.guna2Button1.TabIndex = 29;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.btnCaiDat);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 93);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(196, 43);
            this.guna2Panel1.TabIndex = 28;
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.BorderRadius = 20;
            this.btnCaiDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaiDat.FillColor = System.Drawing.Color.Transparent;
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::CompanyHRManagement.Properties.Resources.setting;
            this.btnCaiDat.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCaiDat.Location = new System.Drawing.Point(155, 4);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(38, 36);
            this.btnCaiDat.TabIndex = 28;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(20, 6);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(109, 33);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "NhanVien";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 54);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(59, 22);
            this.guna2HtmlLabel4.TabIndex = 19;
            this.guna2HtmlLabel4.Text = "Manage";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::CompanyHRManagement.Properties.Resources.staff_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(127, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(81, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 18;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 24);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 29);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "ComHR";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.FillColor = System.Drawing.Color.Transparent;
            this.btnTrangChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Location = new System.Drawing.Point(12, 163);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(193, 40);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // panelTrangChu_user
            // 
            this.panelTrangChu_user.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panelTrangChu_user.Controls.Add(this.guna2Button26);
            this.panelTrangChu_user.Controls.Add(this.panelDashBoard_User);
            this.panelTrangChu_user.Controls.Add(this.panelInfoDB_admin);
            this.panelTrangChu_user.Location = new System.Drawing.Point(225, 0);
            this.panelTrangChu_user.Name = "panelTrangChu_user";
            this.panelTrangChu_user.Size = new System.Drawing.Size(1050, 787);
            this.panelTrangChu_user.TabIndex = 62;
            // 
            // guna2Button26
            // 
            this.guna2Button26.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button26.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button26.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button26.ForeColor = System.Drawing.Color.White;
            this.guna2Button26.Location = new System.Drawing.Point(25, 112);
            this.guna2Button26.Name = "guna2Button26";
            this.guna2Button26.Size = new System.Drawing.Size(1008, 45);
            this.guna2Button26.TabIndex = 57;
            this.guna2Button26.Text = "Thông tin chi tiết";
            this.guna2Button26.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelDashBoard_User
            // 
            this.panelDashBoard_User.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDashBoard_User.Controls.Add(this.chartAttendance);
            this.panelDashBoard_User.Controls.Add(this.chartSalary);
            this.panelDashBoard_User.Controls.Add(this.guna2Panel4);
            this.panelDashBoard_User.Location = new System.Drawing.Point(25, 179);
            this.panelDashBoard_User.Name = "panelDashBoard_User";
            this.panelDashBoard_User.Size = new System.Drawing.Size(1008, 574);
            this.panelDashBoard_User.TabIndex = 56;
            // 
            // chartAttendance
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAttendance.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartAttendance.Legends.Add(legend3);
            this.chartAttendance.Location = new System.Drawing.Point(36, 271);
            this.chartAttendance.Name = "chartAttendance";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartAttendance.Series.Add(series3);
            this.chartAttendance.Size = new System.Drawing.Size(534, 269);
            this.chartAttendance.TabIndex = 59;
            this.chartAttendance.Text = "chart1";
            // 
            // chartSalary
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSalary.Legends.Add(legend4);
            this.chartSalary.Location = new System.Drawing.Point(591, 16);
            this.chartSalary.Name = "chartSalary";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSalary.Series.Add(series4);
            this.chartSalary.Size = new System.Drawing.Size(414, 524);
            this.chartSalary.TabIndex = 58;
            this.chartSalary.Text = "chart1";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.lblPhongBan);
            this.guna2Panel4.Controls.Add(this.lblChucVu);
            this.guna2Panel4.Controls.Add(this.lblHoTen);
            this.guna2Panel4.Controls.Add(this.guna2Button22);
            this.guna2Panel4.Location = new System.Drawing.Point(36, 16);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(534, 211);
            this.guna2Panel4.TabIndex = 57;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhongBan.Location = new System.Drawing.Point(21, 155);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(125, 33);
            this.lblPhongBan.TabIndex = 64;
            this.lblPhongBan.Text = "Phòng ban: ";
            // 
            // lblChucVu
            // 
            this.lblChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChucVu.Location = new System.Drawing.Point(21, 86);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(95, 33);
            this.lblChucVu.TabIndex = 62;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHoTen.Location = new System.Drawing.Point(21, 27);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(82, 33);
            this.lblHoTen.TabIndex = 48;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // guna2Button22
            // 
            this.guna2Button22.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button22.BorderRadius = 10;
            this.guna2Button22.BorderThickness = 2;
            this.guna2Button22.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button22.ForeColor = System.Drawing.Color.White;
            this.guna2Button22.Image = global::CompanyHRManagement.Properties.Resources.staff_total_icon;
            this.guna2Button22.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button22.Location = new System.Drawing.Point(446, 7);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(69, 53);
            this.guna2Button22.TabIndex = 61;
            // 
            // panelInfoDB_admin
            // 
            this.panelInfoDB_admin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoDB_admin.Controls.Add(this.guna2VSeparator2);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button21);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button20);
            this.panelInfoDB_admin.Controls.Add(this.lblRole);
            this.panelInfoDB_admin.Controls.Add(this.lblTime);
            this.panelInfoDB_admin.Controls.Add(this.lblDate);
            this.panelInfoDB_admin.Controls.Add(this.guna2Button3);
            this.panelInfoDB_admin.Controls.Add(this.lblXinChao);
            this.panelInfoDB_admin.Controls.Add(this.guna2HtmlLabel1);
            this.panelInfoDB_admin.Controls.Add(this.guna2VSeparator1);
            this.panelInfoDB_admin.Location = new System.Drawing.Point(3, 3);
            this.panelInfoDB_admin.Name = "panelInfoDB_admin";
            this.panelInfoDB_admin.Size = new System.Drawing.Size(1044, 93);
            this.panelInfoDB_admin.TabIndex = 55;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(384, 17);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator2.TabIndex = 60;
            // 
            // guna2Button21
            // 
            this.guna2Button21.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button21.BorderRadius = 20;
            this.guna2Button21.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button21.ForeColor = System.Drawing.Color.White;
            this.guna2Button21.Image = global::CompanyHRManagement.Properties.Resources.admin;
            this.guna2Button21.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button21.Location = new System.Drawing.Point(651, 21);
            this.guna2Button21.Name = "guna2Button21";
            this.guna2Button21.Size = new System.Drawing.Size(69, 53);
            this.guna2Button21.TabIndex = 59;
            // 
            // guna2Button20
            // 
            this.guna2Button20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderRadius = 20;
            this.guna2Button20.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button20.ForeColor = System.Drawing.Color.White;
            this.guna2Button20.Image = global::CompanyHRManagement.Properties.Resources.welcome;
            this.guna2Button20.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button20.Location = new System.Drawing.Point(290, 20);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(69, 53);
            this.guna2Button20.TabIndex = 58;
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRole.Location = new System.Drawing.Point(415, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(72, 30);
            this.lblRole.TabIndex = 57;
            this.lblRole.Text = "Vai trò: ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTime.Location = new System.Drawing.Point(811, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 30);
            this.lblTime.TabIndex = 56;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDate.Location = new System.Drawing.Point(811, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(93, 30);
            this.lblDate.TabIndex = 55;
            this.lblDate.Text = "Hôm nay: ";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::CompanyHRManagement.Properties.Resources.sun;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(961, 20);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(69, 53);
            this.guna2Button3.TabIndex = 29;
            // 
            // lblXinChao
            // 
            this.lblXinChao.BackColor = System.Drawing.Color.Transparent;
            this.lblXinChao.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinChao.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblXinChao.Location = new System.Drawing.Point(16, 29);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(127, 39);
            this.lblXinChao.TabIndex = 54;
            this.lblXinChao.Text = "Xin chào :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(961, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel1.TabIndex = 48;
            this.guna2HtmlLabel1.Text = null;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(784, 18);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator1.TabIndex = 53;
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.btnReload);
            this.panelThongTin.Controls.Add(this.guna2Panel2);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel11);
            this.panelThongTin.Controls.Add(this.guna2Button10);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel8);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel7);
            this.panelThongTin.Controls.Add(this.guna2HtmlLabel6);
            this.panelThongTin.Controls.Add(this.btnSua);
            this.panelThongTin.Controls.Add(this.btnLamMoi);
            this.panelThongTin.Controls.Add(this.btnXuatExcel);
            this.panelThongTin.Location = new System.Drawing.Point(228, 0);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1050, 787);
            this.panelThongTin.TabIndex = 28;
            this.panelThongTin.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 20;
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = global::CompanyHRManagement.Properties.Resources.reload;
            this.btnReload.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReload.Location = new System.Drawing.Point(993, 106);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 36);
            this.btnReload.TabIndex = 50;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.Controls.Add(this.txtDiaChi);
            this.guna2Panel2.Controls.Add(this.lblNgaySinh);
            this.guna2Panel2.Controls.Add(this.lblNgayVaoLam);
            this.guna2Panel2.Controls.Add(this.dtbNgaySinh);
            this.guna2Panel2.Controls.Add(this.lblDaNghiViec);
            this.guna2Panel2.Controls.Add(this.lblIDChucVu);
            this.guna2Panel2.Controls.Add(this.lblIDNhanVien);
            this.guna2Panel2.Controls.Add(this.lbIDPhongBan);
            this.guna2Panel2.Controls.Add(this.lblThuViec);
            this.guna2Panel2.Controls.Add(this.txtSDT);
            this.guna2Panel2.Controls.Add(this.txtGioiTinh);
            this.guna2Panel2.Controls.Add(this.txtEmail);
            this.guna2Panel2.Controls.Add(this.txtTen);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel22);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel21);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel20);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel19);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel18);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel16);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel12);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Location = new System.Drawing.Point(22, 163);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(965, 487);
            this.guna2Panel2.TabIndex = 66;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(127, 236);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(245, 30);
            this.txtDiaChi.TabIndex = 96;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgaySinh.Location = new System.Drawing.Point(808, 246);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(26, 25);
            this.lblNgaySinh.TabIndex = 95;
            this.lblNgaySinh.Text = "ID:";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayVaoLam.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(837, 143);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(26, 25);
            this.lblNgayVaoLam.TabIndex = 94;
            this.lblNgayVaoLam.Text = "ID:";
            // 
            // dtbNgaySinh
            // 
            this.dtbNgaySinh.Checked = true;
            this.dtbNgaySinh.FillColor = System.Drawing.Color.LightSkyBlue;
            this.dtbNgaySinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtbNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtbNgaySinh.Location = new System.Drawing.Point(699, 276);
            this.dtbNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtbNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtbNgaySinh.Name = "dtbNgaySinh";
            this.dtbNgaySinh.Size = new System.Drawing.Size(200, 36);
            this.dtbNgaySinh.TabIndex = 93;
            this.dtbNgaySinh.Value = new System.DateTime(2025, 5, 13, 9, 11, 26, 348);
            // 
            // lblDaNghiViec
            // 
            this.lblDaNghiViec.BackColor = System.Drawing.Color.Transparent;
            this.lblDaNghiViec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaNghiViec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDaNghiViec.Location = new System.Drawing.Point(814, 374);
            this.lblDaNghiViec.Name = "lblDaNghiViec";
            this.lblDaNghiViec.Size = new System.Drawing.Size(26, 25);
            this.lblDaNghiViec.TabIndex = 91;
            this.lblDaNghiViec.Text = "ID:";
            // 
            // lblIDChucVu
            // 
            this.lblIDChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblIDChucVu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDChucVu.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIDChucVu.Location = new System.Drawing.Point(797, 44);
            this.lblIDChucVu.Name = "lblIDChucVu";
            this.lblIDChucVu.Size = new System.Drawing.Size(26, 25);
            this.lblIDChucVu.TabIndex = 90;
            this.lblIDChucVu.Text = "ID:";
            // 
            // lblIDNhanVien
            // 
            this.lblIDNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblIDNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNhanVien.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIDNhanVien.Location = new System.Drawing.Point(68, 44);
            this.lblIDNhanVien.Name = "lblIDNhanVien";
            this.lblIDNhanVien.Size = new System.Drawing.Size(26, 25);
            this.lblIDNhanVien.TabIndex = 89;
            this.lblIDNhanVien.Text = "ID:";
            // 
            // lbIDPhongBan
            // 
            this.lbIDPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lbIDPhongBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDPhongBan.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbIDPhongBan.Location = new System.Drawing.Point(541, 44);
            this.lbIDPhongBan.Name = "lbIDPhongBan";
            this.lbIDPhongBan.Size = new System.Drawing.Size(26, 25);
            this.lbIDPhongBan.TabIndex = 88;
            this.lbIDPhongBan.Text = "ID:";
            // 
            // lblThuViec
            // 
            this.lblThuViec.BackColor = System.Drawing.Color.Transparent;
            this.lblThuViec.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuViec.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThuViec.Location = new System.Drawing.Point(559, 143);
            this.lblThuViec.Name = "lblThuViec";
            this.lblThuViec.Size = new System.Drawing.Size(26, 25);
            this.lblThuViec.TabIndex = 87;
            this.lblThuViec.Text = "ID:";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(467, 236);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(175, 30);
            this.txtSDT.TabIndex = 86;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGioiTinh.DefaultText = "";
            this.txtGioiTinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGioiTinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGioiTinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiTinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGioiTinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGioiTinh.Location = new System.Drawing.Point(499, 374);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.PlaceholderText = "";
            this.txtGioiTinh.SelectedText = "";
            this.txtGioiTinh.Size = new System.Drawing.Size(71, 30);
            this.txtGioiTinh.TabIndex = 85;
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(127, 374);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(245, 30);
            this.txtEmail.TabIndex = 84;
            // 
            // txtTen
            // 
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTen.Location = new System.Drawing.Point(127, 138);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(245, 30);
            this.txtTen.TabIndex = 80;
            // 
            // guna2HtmlLabel22
            // 
            this.guna2HtmlLabel22.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel22.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel22.Location = new System.Drawing.Point(699, 374);
            this.guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            this.guna2HtmlLabel22.Size = new System.Drawing.Size(107, 25);
            this.guna2HtmlLabel22.TabIndex = 77;
            this.guna2HtmlLabel22.Text = "Đã nghỉ việc:";
            // 
            // guna2HtmlLabel21
            // 
            this.guna2HtmlLabel21.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel21.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel21.Location = new System.Drawing.Point(410, 143);
            this.guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            this.guna2HtmlLabel21.Size = new System.Drawing.Size(120, 25);
            this.guna2HtmlLabel21.TabIndex = 76;
            this.guna2HtmlLabel21.Text = "Đang thử việc:";
            // 
            // guna2HtmlLabel20
            // 
            this.guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel20.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel20.Location = new System.Drawing.Point(699, 143);
            this.guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            this.guna2HtmlLabel20.Size = new System.Drawing.Size(118, 25);
            this.guna2HtmlLabel20.TabIndex = 75;
            this.guna2HtmlLabel20.Text = "Ngày vào làm:";
            // 
            // guna2HtmlLabel19
            // 
            this.guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel19.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel19.Location = new System.Drawing.Point(699, 44);
            this.guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            this.guna2HtmlLabel19.Size = new System.Drawing.Size(92, 25);
            this.guna2HtmlLabel19.TabIndex = 74;
            this.guna2HtmlLabel19.Text = "ID chức vụ:";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(36, 374);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(52, 25);
            this.guna2HtmlLabel18.TabIndex = 73;
            this.guna2HtmlLabel18.Text = "Email:";
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel16.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(36, 241);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(63, 25);
            this.guna2HtmlLabel16.TabIndex = 72;
            this.guna2HtmlLabel16.Text = "Địa chỉ:";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(410, 241);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(41, 25);
            this.guna2HtmlLabel17.TabIndex = 71;
            this.guna2HtmlLabel17.Text = "SDT:";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(410, 374);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(78, 25);
            this.guna2HtmlLabel15.TabIndex = 69;
            this.guna2HtmlLabel15.Text = "Giới tính:";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(699, 245);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(87, 25);
            this.guna2HtmlLabel14.TabIndex = 68;
            this.guna2HtmlLabel14.Text = "Ngày sinh:";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(410, 44);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(118, 25);
            this.guna2HtmlLabel13.TabIndex = 67;
            this.guna2HtmlLabel13.Text = "ID phòng ban:";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(36, 143);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(85, 25);
            this.guna2HtmlLabel12.TabIndex = 66;
            this.guna2HtmlLabel12.Text = "Họ và tên:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(36, 44);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(26, 25);
            this.guna2HtmlLabel5.TabIndex = 65;
            this.guna2HtmlLabel5.Text = "ID:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(25, 43);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(127, 22);
            this.guna2HtmlLabel11.TabIndex = 64;
            this.guna2HtmlLabel11.Text = "Thông tin cá nhân";
            // 
            // guna2Button10
            // 
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Location = new System.Drawing.Point(22, 102);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(965, 40);
            this.guna2Button10.TabIndex = 60;
            this.guna2Button10.Text = "Thông tin chi tiết";
            this.guna2Button10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(924, 43);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(80, 22);
            this.guna2HtmlLabel8.TabIndex = 59;
            this.guna2HtmlLabel8.Text = "Chấm công";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(651, 43);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(117, 22);
            this.guna2HtmlLabel7.TabIndex = 58;
            this.guna2HtmlLabel7.Text = "Bảng chấm công";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(290, 43);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(140, 22);
            this.guna2HtmlLabel6.TabIndex = 57;
            this.guna2HtmlLabel6.Text = "Bảng lương cá nhân";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(114, 702);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Lưu thay đổi";
            this.btnSua.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(457, 702);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 52;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BorderRadius = 10;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(830, 702);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(100, 40);
            this.btnXuatExcel.TabIndex = 53;
            this.btnXuatExcel.Text = "Xuất Excel";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog2.Parent = this;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog2.Text = null;
            // 
            // MainForm_user
            // 
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.panelTrangChu_user);
            this.Controls.Add(this.panelThongTin);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainForm_user";
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelTrangChu_user.ResumeLayout(false);
            this.panelDashBoard_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.panelInfoDB_admin.ResumeLayout(false);
            this.panelInfoDB_admin.PerformLayout();
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Panel panelThongTin;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Panel panelTrangChu_user;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnNghiPhep;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Timer timerClock;
        private Guna.UI2.WinForms.Guna2Panel panelInfoDB_admin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXinChao;
        private Guna.UI2.WinForms.Guna2Panel panelDashBoard_User;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChucVu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhongBan;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2Button btnNhanTin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDChucVu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIDNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbIDPhongBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThuViec;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtbNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDaNghiViec;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayVaoLam;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2Button btnReload;
    }
}
