namespace CompanyHRManagement.GUI.Payroll
{
    partial class SalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalary.Location = new System.Drawing.Point(191, 103);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersWidth = 51;
            this.dgvSalary.RowTemplate.Height = 24;
            this.dgvSalary.Size = new System.Drawing.Size(412, 245);
            this.dgvSalary.TabIndex = 0;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSalary);
            this.Name = "SalaryForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalary;
    }
}