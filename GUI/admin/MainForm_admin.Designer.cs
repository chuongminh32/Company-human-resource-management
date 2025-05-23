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
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_main = new CompanyHRManagement.GUI.admin.Panel_main();
            this.panel_NhanVien = new CompanyHRManagement.GUI.admin.Panel_NhanVien();
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
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
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Location = new System.Drawing.Point(237, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1035, 787);
            this.panel_main.TabIndex = 1;
            // 
            // panel_NhanVien
            // 
            this.panel_NhanVien.Location = new System.Drawing.Point(237, 0);
            this.panel_NhanVien.Name = "panel_NhanVien";
            this.panel_NhanVien.Size = new System.Drawing.Size(1050, 787);
            this.panel_NhanVien.TabIndex = 2;
            // 
            // MainForm_admin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1275, 787);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.panel_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_admin_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
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
        private Timer timerClock;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Panel_main panel_main;
        private Panel_NhanVien panel_NhanVien;
    }
}
