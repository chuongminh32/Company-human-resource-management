using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.BUS._ado;
using CompanyHRManagement.Models;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_PhongChucVu : UserControl
    {
        DepartmentBUS departmentBUS = new DepartmentBUS();
        private bool them, sua = false;
        public Panel_PhongChucVu()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            LoadDepartmentsToGrid(departmentBUS.LayTatCaPhongBan());
            cbAction.SelectedIndex = 0;
        }

        private void LoadDepartmentsToGrid(List<Department> danhsach)
        {
            dgvDepartment.DataSource = danhsach;
            dgvDepartment.Columns["DepartmentID"].HeaderText = "Mã Phòng Ban";
            dgvDepartment.Columns["DepartmentName"].HeaderText = "Tên Phòng Ban";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                txtIDDepartment.Enabled = false;
                LoadDepartmentsToGrid(departmentBUS.TimTenPhongBan(txtDepartmentName.Text.ToString()));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                txtIDDepartment.Enabled = false;
                txtDepartmentName.Clear();
                them = true;
            }
            else if (cbAction.SelectedIndex == 1) {
                txtIDPos.Enabled = false;
                txtPositionName.Clear();
                txtBaseSalary.Clear();
                them = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Phòng Ban hoặc Chức vụ");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbAction.SelectedIndex == 0)
            {
                string deptName = txtDepartmentName.Text.Trim();
                string error = "";

                if (string.IsNullOrWhiteSpace(deptName))
                {
                    MessageBox.Show("Vui lòng nhập tên phòng ban.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = false;

                if (them)
                {
                    result = departmentBUS.ThemPhongBan(deptName, ref error);
                    if (result)
                        MessageBox.Show("Thêm phòng ban thành công.");
                }
                else
                {
                    
                }

                if (!result)
                {
                    MessageBox.Show("Lỗi: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadData();
                txtDepartmentName.Clear();
                them = false;
            }
            else if (cbAction.SelectedIndex == 1)
            {
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hành động là Phòng Ban hoặc Chức vụ");
            }
        }

        private void dgvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo người dùng click hợp lệ (không click header)
            if (e.RowIndex >= 0 && dgvDepartment.Rows[e.RowIndex].Cells["DepartmentID"].Value != null)
            {
                DataGridViewRow row = dgvDepartment.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView xuống các TextBox
                txtIDDepartment.Text = row.Cells["DepartmentID"].Value.ToString();
                txtDepartmentName.Text = row.Cells["DepartmentName"].Value.ToString();
            }
        }

        private void Panel_PhongChucVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
