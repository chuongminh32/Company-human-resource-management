using System.Drawing;
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.admin
{
    partial class MainForm_admin
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnTrangChu;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelTrangChu_admin = new Guna.UI2.WinForms.Guna2Panel();
            this.chartSalary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNhanVienPhongBan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Button26 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoBaoHiemConHan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button28 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTongLuongThuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button27 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNhanVienThuViec = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button25 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoPhongBan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button24 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSoChucVu = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button23 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button22 = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongNhanVien = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.panelNhanVien = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbBoPhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelTrangChu_admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVienPhongBan)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panelInfoDB_admin.SuspendLayout();
            this.panelNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
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
            this.sidebarPanel.Controls.Add(this.guna2Button16);
            this.sidebarPanel.Controls.Add(this.guna2Button17);
            this.sidebarPanel.Controls.Add(this.guna2Button14);
            this.sidebarPanel.Controls.Add(this.guna2Button15);
            this.sidebarPanel.Controls.Add(this.guna2Button12);
            this.sidebarPanel.Controls.Add(this.guna2Button13);
            this.sidebarPanel.Controls.Add(this.guna2Button6);
            this.sidebarPanel.Controls.Add(this.guna2Button7);
            this.sidebarPanel.Controls.Add(this.guna2Button8);
            this.sidebarPanel.Controls.Add(this.guna2Button11);
            this.sidebarPanel.Controls.Add(this.guna2Button4);
            this.sidebarPanel.Controls.Add(this.guna2Button5);
            this.sidebarPanel.Controls.Add(this.guna2Button2);
            this.sidebarPanel.Controls.Add(this.btnNhanVien);
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
            this.guna2Button18.Location = new System.Drawing.Point(21, 702);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(38, 36);
            this.guna2Button18.TabIndex = 47;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(12, 698);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 40);
            this.btnDangXuat.TabIndex = 46;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangXuat.Click += new System.EventHandler(this.guna2Button19_Click);
            // 
            // guna2Button16
            // 
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderRadius = 20;
            this.guna2Button16.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button16.ForeColor = System.Drawing.Color.White;
            this.guna2Button16.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button16.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button16.Location = new System.Drawing.Point(21, 637);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(38, 36);
            this.guna2Button16.TabIndex = 45;
            // 
            // guna2Button17
            // 
            this.guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button17.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button17.ForeColor = System.Drawing.Color.Black;
            this.guna2Button17.Location = new System.Drawing.Point(12, 633);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(193, 40);
            this.guna2Button17.TabIndex = 44;
            this.guna2Button17.Text = "Trang chủ";
            this.guna2Button17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button14.BorderRadius = 20;
            this.guna2Button14.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button14.ForeColor = System.Drawing.Color.White;
            this.guna2Button14.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button14.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button14.Location = new System.Drawing.Point(21, 576);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(38, 36);
            this.guna2Button14.TabIndex = 43;
            // 
            // guna2Button15
            // 
            this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button15.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.Black;
            this.guna2Button15.Location = new System.Drawing.Point(12, 572);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(193, 40);
            this.guna2Button15.TabIndex = 42;
            this.guna2Button15.Text = "Trang chủ";
            this.guna2Button15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button12
            // 
            this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button12.BorderRadius = 20;
            this.guna2Button12.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button12.ForeColor = System.Drawing.Color.White;
            this.guna2Button12.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button12.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button12.Location = new System.Drawing.Point(21, 507);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(38, 36);
            this.guna2Button12.TabIndex = 41;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button13.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button13.ForeColor = System.Drawing.Color.Black;
            this.guna2Button13.Location = new System.Drawing.Point(12, 503);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(193, 40);
            this.guna2Button13.TabIndex = 40;
            this.guna2Button13.Text = "Trang chủ";
            this.guna2Button13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button6.BorderRadius = 20;
            this.guna2Button6.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button6.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button6.Location = new System.Drawing.Point(21, 437);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(38, 36);
            this.guna2Button6.TabIndex = 39;
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.Black;
            this.guna2Button7.Location = new System.Drawing.Point(12, 433);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(193, 40);
            this.guna2Button7.TabIndex = 38;
            this.guna2Button7.Text = "Trang chủ";
            this.guna2Button7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button8.BorderRadius = 20;
            this.guna2Button8.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button8.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button8.Location = new System.Drawing.Point(21, 370);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(38, 36);
            this.guna2Button8.TabIndex = 37;
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button11.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.Black;
            this.guna2Button11.Location = new System.Drawing.Point(12, 366);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(193, 40);
            this.guna2Button11.TabIndex = 36;
            this.guna2Button11.Text = "Trang chủ";
            this.guna2Button11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::CompanyHRManagement.Properties.Resources.home;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(21, 301);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(38, 36);
            this.guna2Button4.TabIndex = 33;
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.Black;
            this.guna2Button5.Location = new System.Drawing.Point(12, 297);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(193, 40);
            this.guna2Button5.TabIndex = 32;
            this.guna2Button5.Text = "Trang chủ";
            this.guna2Button5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::CompanyHRManagement.Properties.Resources.staff;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(21, 236);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(38, 36);
            this.guna2Button2.TabIndex = 31;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.FillColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Location = new System.Drawing.Point(12, 232);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(193, 40);
            this.btnNhanVien.TabIndex = 30;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
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
            this.lblUsername.Size = new System.Drawing.Size(75, 33);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Admin";
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
            // panelTrangChu_admin
            // 
            this.panelTrangChu_admin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.panelTrangChu_admin.Controls.Add(this.chartSalary);
            this.panelTrangChu_admin.Controls.Add(this.chartNhanVienPhongBan);
            this.panelTrangChu_admin.Controls.Add(this.guna2Button26);
            this.panelTrangChu_admin.Controls.Add(this.guna2Panel3);
            this.panelTrangChu_admin.Controls.Add(this.panelInfoDB_admin);
            this.panelTrangChu_admin.Location = new System.Drawing.Point(225, 0);
            this.panelTrangChu_admin.Name = "panelTrangChu_admin";
            this.panelTrangChu_admin.Size = new System.Drawing.Size(1050, 787);
            this.panelTrangChu_admin.TabIndex = 62;
            // 
            // chartSalary
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSalary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSalary.Legends.Add(legend1);
            this.chartSalary.Location = new System.Drawing.Point(632, 507);
            this.chartSalary.Name = "chartSalary";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSalary.Series.Add(series1);
            this.chartSalary.Size = new System.Drawing.Size(401, 268);
            this.chartSalary.TabIndex = 59;
            this.chartSalary.Text = "chart1";
            // 
            // chartNhanVienPhongBan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartNhanVienPhongBan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartNhanVienPhongBan.Legends.Add(legend2);
            this.chartNhanVienPhongBan.Location = new System.Drawing.Point(632, 179);
            this.chartNhanVienPhongBan.Name = "chartNhanVienPhongBan";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartNhanVienPhongBan.Series.Add(series2);
            this.chartNhanVienPhongBan.Size = new System.Drawing.Size(401, 302);
            this.chartNhanVienPhongBan.TabIndex = 58;
            this.chartNhanVienPhongBan.Text = "chart1";
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
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.guna2Panel3.Controls.Add(this.guna2Panel9);
            this.guna2Panel3.Controls.Add(this.guna2Panel8);
            this.guna2Panel3.Controls.Add(this.guna2Panel7);
            this.guna2Panel3.Controls.Add(this.guna2Panel6);
            this.guna2Panel3.Controls.Add(this.guna2Panel5);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Location = new System.Drawing.Point(25, 179);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(581, 596);
            this.guna2Panel3.TabIndex = 56;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel9.BorderRadius = 10;
            this.guna2Panel9.BorderThickness = 5;
            this.guna2Panel9.Controls.Add(this.lblSoBaoHiemConHan);
            this.guna2Panel9.Controls.Add(this.guna2HtmlLabel17);
            this.guna2Panel9.Controls.Add(this.guna2Button28);
            this.guna2Panel9.Location = new System.Drawing.Point(308, 380);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel9.TabIndex = 63;
            // 
            // lblSoBaoHiemConHan
            // 
            this.lblSoBaoHiemConHan.BackColor = System.Drawing.Color.Transparent;
            this.lblSoBaoHiemConHan.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBaoHiemConHan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSoBaoHiemConHan.Location = new System.Drawing.Point(23, 17);
            this.lblSoBaoHiemConHan.Name = "lblSoBaoHiemConHan";
            this.lblSoBaoHiemConHan.Size = new System.Drawing.Size(41, 56);
            this.lblSoBaoHiemConHan.TabIndex = 62;
            this.lblSoBaoHiemConHan.Text = "10";
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(195, 33);
            this.guna2HtmlLabel17.TabIndex = 48;
            this.guna2HtmlLabel17.Text = "Bảo hiểm còn hạn";
            // 
            // guna2Button28
            // 
            this.guna2Button28.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button28.BorderRadius = 10;
            this.guna2Button28.BorderThickness = 2;
            this.guna2Button28.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button28.ForeColor = System.Drawing.Color.White;
            this.guna2Button28.Image = global::CompanyHRManagement.Properties.Resources.insurance;
            this.guna2Button28.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button28.Location = new System.Drawing.Point(141, 16);
            this.guna2Button28.Name = "guna2Button28";
            this.guna2Button28.Size = new System.Drawing.Size(69, 53);
            this.guna2Button28.TabIndex = 61;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.BorderThickness = 5;
            this.guna2Panel8.Controls.Add(this.lblTongLuongThuong);
            this.guna2Panel8.Controls.Add(this.guna2HtmlLabel15);
            this.guna2Panel8.Controls.Add(this.guna2Button27);
            this.guna2Panel8.Location = new System.Drawing.Point(36, 382);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel8.TabIndex = 63;
            // 
            // lblTongLuongThuong
            // 
            this.lblTongLuongThuong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongLuongThuong.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuongThuong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongLuongThuong.Location = new System.Drawing.Point(23, 17);
            this.lblTongLuongThuong.Name = "lblTongLuongThuong";
            this.lblTongLuongThuong.Size = new System.Drawing.Size(41, 56);
            this.lblTongLuongThuong.TabIndex = 62;
            this.lblTongLuongThuong.Text = "10";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(144, 33);
            this.guna2HtmlLabel15.TabIndex = 48;
            this.guna2HtmlLabel15.Text = "Tổng thưởng";
            // 
            // guna2Button27
            // 
            this.guna2Button27.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button27.BorderRadius = 10;
            this.guna2Button27.BorderThickness = 2;
            this.guna2Button27.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button27.ForeColor = System.Drawing.Color.White;
            this.guna2Button27.Image = global::CompanyHRManagement.Properties.Resources.salary_total_icon;
            this.guna2Button27.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button27.Location = new System.Drawing.Point(141, 16);
            this.guna2Button27.Name = "guna2Button27";
            this.guna2Button27.Size = new System.Drawing.Size(69, 53);
            this.guna2Button27.TabIndex = 61;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel7.BorderRadius = 10;
            this.guna2Panel7.BorderThickness = 5;
            this.guna2Panel7.Controls.Add(this.lblNhanVienThuViec);
            this.guna2Panel7.Controls.Add(this.guna2HtmlLabel14);
            this.guna2Panel7.Controls.Add(this.guna2Button25);
            this.guna2Panel7.Location = new System.Drawing.Point(308, 202);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel7.TabIndex = 64;
            // 
            // lblNhanVienThuViec
            // 
            this.lblNhanVienThuViec.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVienThuViec.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVienThuViec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNhanVienThuViec.Location = new System.Drawing.Point(23, 17);
            this.lblNhanVienThuViec.Name = "lblNhanVienThuViec";
            this.lblNhanVienThuViec.Size = new System.Drawing.Size(41, 56);
            this.lblNhanVienThuViec.TabIndex = 62;
            this.lblNhanVienThuViec.Text = "10";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(204, 33);
            this.guna2HtmlLabel14.TabIndex = 48;
            this.guna2HtmlLabel14.Text = "Nhân viên thử việc";
            // 
            // guna2Button25
            // 
            this.guna2Button25.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button25.BorderRadius = 10;
            this.guna2Button25.BorderThickness = 2;
            this.guna2Button25.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button25.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button25.ForeColor = System.Drawing.Color.White;
            this.guna2Button25.Image = global::CompanyHRManagement.Properties.Resources.staff_intern_total_icon;
            this.guna2Button25.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button25.Location = new System.Drawing.Point(141, 16);
            this.guna2Button25.Name = "guna2Button25";
            this.guna2Button25.Size = new System.Drawing.Size(69, 53);
            this.guna2Button25.TabIndex = 61;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel6.BorderRadius = 10;
            this.guna2Panel6.BorderThickness = 5;
            this.guna2Panel6.Controls.Add(this.lblSoPhongBan);
            this.guna2Panel6.Controls.Add(this.guna2HtmlLabel13);
            this.guna2Panel6.Controls.Add(this.guna2Button24);
            this.guna2Panel6.Location = new System.Drawing.Point(308, 16);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel6.TabIndex = 63;
            // 
            // lblSoPhongBan
            // 
            this.lblSoPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.lblSoPhongBan.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoPhongBan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSoPhongBan.Location = new System.Drawing.Point(23, 17);
            this.lblSoPhongBan.Name = "lblSoPhongBan";
            this.lblSoPhongBan.Size = new System.Drawing.Size(41, 56);
            this.lblSoPhongBan.TabIndex = 62;
            this.lblSoPhongBan.Text = "10";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(152, 33);
            this.guna2HtmlLabel13.TabIndex = 48;
            this.guna2HtmlLabel13.Text = "Số phòng ban";
            // 
            // guna2Button24
            // 
            this.guna2Button24.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button24.BorderRadius = 10;
            this.guna2Button24.BorderThickness = 2;
            this.guna2Button24.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button24.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button24.ForeColor = System.Drawing.Color.White;
            this.guna2Button24.Image = global::CompanyHRManagement.Properties.Resources.room_total_icon;
            this.guna2Button24.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button24.Location = new System.Drawing.Point(141, 16);
            this.guna2Button24.Name = "guna2Button24";
            this.guna2Button24.Size = new System.Drawing.Size(69, 53);
            this.guna2Button24.TabIndex = 61;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel5.BorderRadius = 10;
            this.guna2Panel5.BorderThickness = 5;
            this.guna2Panel5.Controls.Add(this.lblSoChucVu);
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel11);
            this.guna2Panel5.Controls.Add(this.guna2Button23);
            this.guna2Panel5.Location = new System.Drawing.Point(36, 202);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel5.TabIndex = 62;
            // 
            // lblSoChucVu
            // 
            this.lblSoChucVu.BackColor = System.Drawing.Color.Transparent;
            this.lblSoChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoChucVu.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSoChucVu.Location = new System.Drawing.Point(23, 17);
            this.lblSoChucVu.Name = "lblSoChucVu";
            this.lblSoChucVu.Size = new System.Drawing.Size(41, 56);
            this.lblSoChucVu.TabIndex = 62;
            this.lblSoChucVu.Text = "10";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(119, 33);
            this.guna2HtmlLabel11.TabIndex = 48;
            this.guna2HtmlLabel11.Text = "Số chức vụ ";
            // 
            // guna2Button23
            // 
            this.guna2Button23.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button23.BorderRadius = 10;
            this.guna2Button23.BorderThickness = 2;
            this.guna2Button23.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button23.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button23.ForeColor = System.Drawing.Color.White;
            this.guna2Button23.Image = global::CompanyHRManagement.Properties.Resources.rank_total_icon;
            this.guna2Button23.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button23.Location = new System.Drawing.Point(141, 16);
            this.guna2Button23.Name = "guna2Button23";
            this.guna2Button23.Size = new System.Drawing.Size(69, 53);
            this.guna2Button23.TabIndex = 61;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Azure;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.guna2Panel4.BorderRadius = 10;
            this.guna2Panel4.BorderThickness = 5;
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel10);
            this.guna2Panel4.Controls.Add(this.guna2Button22);
            this.guna2Panel4.Controls.Add(this.lblTongNhanVien);
            this.guna2Panel4.Location = new System.Drawing.Point(36, 16);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(224, 158);
            this.guna2Panel4.TabIndex = 57;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(15, 104);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(169, 33);
            this.guna2HtmlLabel10.TabIndex = 48;
            this.guna2HtmlLabel10.Text = "Tổng nhân viên ";
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
            this.guna2Button22.Location = new System.Drawing.Point(141, 16);
            this.guna2Button22.Name = "guna2Button22";
            this.guna2Button22.Size = new System.Drawing.Size(69, 53);
            this.guna2Button22.TabIndex = 61;
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongNhanVien.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTongNhanVien.Location = new System.Drawing.Point(23, 16);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(41, 56);
            this.lblTongNhanVien.TabIndex = 58;
            this.lblTongNhanVien.Text = "10";
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
            this.lblRole.ForeColor = System.Drawing.Color.SlateGray;
            this.lblRole.Location = new System.Drawing.Point(463, 32);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(72, 30);
            this.lblRole.TabIndex = 57;
            this.lblRole.Text = "Vai trò: ";
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.SlateGray;
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
            this.lblDate.ForeColor = System.Drawing.Color.SlateGray;
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
            this.lblXinChao.ForeColor = System.Drawing.Color.SlateGray;
            this.lblXinChao.Location = new System.Drawing.Point(58, 32);
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
            // panelNhanVien
            // 
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel9);
            this.panelNhanVien.Controls.Add(this.guna2Button10);
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel8);
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel7);
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel6);
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel5);
            this.panelNhanVien.Controls.Add(this.guna2Button9);
            this.panelNhanVien.Controls.Add(this.guna2HtmlLabel2);
            this.panelNhanVien.Controls.Add(this.dgvNhanVien);
            this.panelNhanVien.Controls.Add(this.txtTimKiem);
            this.panelNhanVien.Controls.Add(this.cbBoPhan);
            this.panelNhanVien.Controls.Add(this.cbPhong);
            this.panelNhanVien.Controls.Add(this.btnThem);
            this.panelNhanVien.Controls.Add(this.btnXoa);
            this.panelNhanVien.Controls.Add(this.btnSua);
            this.panelNhanVien.Controls.Add(this.btnLamMoi);
            this.panelNhanVien.Controls.Add(this.btnXuatExcel);
            this.panelNhanVien.Location = new System.Drawing.Point(228, 0);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(1050, 787);
            this.panelNhanVien.TabIndex = 28;
            this.panelNhanVien.Visible = false;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(733, 179);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(95, 33);
            this.guna2HtmlLabel9.TabIndex = 61;
            this.guna2HtmlLabel9.Text = "Bộ phận:";
            // 
            // guna2Button10
            // 
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.Location = new System.Drawing.Point(22, 102);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.Size = new System.Drawing.Size(962, 40);
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
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel8.TabIndex = 59;
            this.guna2HtmlLabel8.Text = "Gửi Mail";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(586, 43);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(147, 22);
            this.guna2HtmlLabel7.TabIndex = 58;
            this.guna2HtmlLabel7.Text = "Quản lý thử/thôi việc";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(317, 43);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlLabel6.TabIndex = 57;
            this.guna2HtmlLabel6.Text = "Quản lý chế độ";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.SlateGray;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(22, 43);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel5.TabIndex = 54;
            this.guna2HtmlLabel5.Text = "Nhân viên";
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2Button9.BorderRadius = 20;
            this.guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.Image = global::CompanyHRManagement.Properties.Resources.fiter;
            this.guna2Button9.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button9.Location = new System.Drawing.Point(365, 179);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.Size = new System.Drawing.Size(61, 36);
            this.guna2Button9.TabIndex = 56;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(443, 179);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(121, 33);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Phòng ban: ";
            // 
            // dgvNhanVien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.Location = new System.Drawing.Point(22, 241);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(962, 400);
            this.dgvNhanVien.TabIndex = 45;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvNhanVien.ThemeStyle.ReadOnly = false;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(22, 179);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Tìm kiếm nhân viên...";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(337, 36);
            this.txtTimKiem.TabIndex = 46;
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.BackColor = System.Drawing.Color.Transparent;
            this.cbBoPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoPhan.FocusedColor = System.Drawing.Color.Empty;
            this.cbBoPhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoPhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBoPhan.ItemHeight = 30;
            this.cbBoPhan.Items.AddRange(new object[] {
            "Bộ phận 1",
            "Bộ phận 2"});
            this.cbBoPhan.Location = new System.Drawing.Point(570, 179);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(150, 36);
            this.cbBoPhan.TabIndex = 47;
            // 
            // cbPhong
            // 
            this.cbPhong.BackColor = System.Drawing.Color.Transparent;
            this.cbPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FocusedColor = System.Drawing.Color.Empty;
            this.cbPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhong.ItemHeight = 30;
            this.cbPhong.Items.AddRange(new object[] {
            "Phòng A",
            "Phòng B"});
            this.cbPhong.Location = new System.Drawing.Point(834, 179);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(150, 36);
            this.cbPhong.TabIndex = 48;
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 10;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(22, 679);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 49;
            this.btnThem.Text = "Thêm";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(242, 679);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 50;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 10;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(454, 679);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 40);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 10;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(657, 679);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 40);
            this.btnLamMoi.TabIndex = 52;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BorderRadius = 10;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(884, 679);
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
            // MainForm_admin
            // 
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.panelTrangChu_admin);
            this.Controls.Add(this.panelNhanVien);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "MainForm_admin";
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_user_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelTrangChu_admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhanVienPhongBan)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel9.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.panelInfoDB_admin.ResumeLayout(false);
            this.panelInfoDB_admin.PerformLayout();
            this.panelNhanVien.ResumeLayout(false);
            this.panelNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Panel panelNhanVien;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbBoPhan;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhong;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2Panel panelTrangChu_admin;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Timer timerClock;
        private Guna.UI2.WinForms.Guna2Panel panelInfoDB_admin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblXinChao;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRole;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Button guna2Button21;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongNhanVien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button22;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Button guna2Button23;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoPhongBan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2Button guna2Button24;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoChucVu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNhanVienThuViec;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2Button guna2Button25;
        private Guna.UI2.WinForms.Guna2Button guna2Button26;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhanVienPhongBan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoBaoHiemConHan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2Button guna2Button28;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongLuongThuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2Button guna2Button27;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSalary;
    }
}
