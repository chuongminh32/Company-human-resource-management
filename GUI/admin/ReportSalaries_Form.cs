using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.Reports;
using Microsoft.Reporting.WinForms;

namespace CompanyHRManagement.GUI.admin
{
    public partial class ReportSalaries_Form : Form
    {
        private DataTable luongTable;
        public ReportSalaries_Form(DataTable dt)
        {
            InitializeComponent();
            luongTable = dt;
        }

        private void ReportSalaries_Form_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("LuongDataSet", luongTable); // "LuongDataSet" là tên dataset bạn gán trong RDLC
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "Reports\\RptSalaries.rdlc"; 
            reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
