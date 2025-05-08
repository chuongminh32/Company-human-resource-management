//namespace CompanyHRManagement.GUI.Login
//{
//    partial class LoginForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.btnLogin = new System.Windows.Forms.Button();
//            this.label3 = new System.Windows.Forms.Label();
//            this.SuspendLayout();
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.Location = new System.Drawing.Point(332, 171);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(182, 22);
//            this.txtUsername.TabIndex = 0;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(256, 171);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(70, 16);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "Username";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(256, 226);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(67, 16);
//            this.label2.TabIndex = 3;
//            this.label2.Text = "Password";
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.Location = new System.Drawing.Point(332, 223);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(182, 22);
//            this.txtPassword.TabIndex = 2;
//            // 
//            // btnLogin
//            // 
//            this.btnLogin.Location = new System.Drawing.Point(259, 288);
//            this.btnLogin.Name = "btnLogin";
//            this.btnLogin.Size = new System.Drawing.Size(261, 34);
//            this.btnLogin.TabIndex = 4;
//            this.btnLogin.Text = "Login";
//            this.btnLogin.UseVisualStyleBackColor = true;
//            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.Location = new System.Drawing.Point(306, 103);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(168, 29);
//            this.label3.TabIndex = 5;
//            this.label3.Text = "LOGIN PAGE";
//            // 
//            // LoginForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.btnLogin);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.txtPassword);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.txtUsername);
//            this.Name = "LoginForm";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.LoginForm_Load);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.TextBox txtUsername;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.TextBox txtPassword;
//        private System.Windows.Forms.Button btnLogin;
//        private System.Windows.Forms.Label label3;
//    }
//}
using System.Windows.Forms;

namespace CompanyHRManagement.GUI.Login
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        // Guna UI2 controls
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPassword;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;

            //
            // MessageDialog
            //
            this.guna2MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog.Parent = this;

            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(230, 180);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Enter username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(320, 40);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(230, 270);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(320, 40);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.FillColor2 = System.Drawing.Color.DeepPink;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(230, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(281, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LOGIN PAGE";
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(230, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.Location = new System.Drawing.Point(230, 240);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(74, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(753, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(49, 41);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ĐĂNG NHẬP";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
