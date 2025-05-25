using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyHRManagement.DAL._ado;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_NhanVien : UserControl
    {
        DataTable dtNV = null;
        String err = null;

        EmployeeDAO dbEm = new EmployeeDAO();

        public Panel_NhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtNV = new DataTable();
                dtNV.Clear();
                DataSet ds = dbEm.GetEmployee();
                dtNV = ds.Tables[0];
                dgvNhanVien.DataSource = dtNV;
                dgvNhanVien.AutoResizeColumns();

                var distinctDepartments = dtNV.AsEnumerable()
                    .Select(r => r.Field<string>("DepartmentName"))
                    .Where(x => x != null)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                cbPhong.Items.Clear();
                cbPhong.Items.Add(""); 
                cbPhong.Items.AddRange(distinctDepartments.ToArray());

                var distinctPositions = dtNV.AsEnumerable()
                    .Select(r => r.Field<string>("PositionName"))
                    .Where(x => x != null)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();
                cbBoPhan.Items.Clear();
                cbBoPhan.Items.Add("");
                cbBoPhan.Items.AddRange(distinctPositions.ToArray());
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }

        }

        void ApplyNhanVienFilter()
        {
            if (dtNV == null) return;

            string filter = "";

            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                filter += $"FullName LIKE '%{txtTimKiem.Text.Replace("'", "''")}%' ";
            }

            if (!string.IsNullOrWhiteSpace(cbPhong.Text))
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"DepartmentName = '{cbPhong.Text.Replace("'", "''")}' ";
            }

            if (!string.IsNullOrWhiteSpace(cbBoPhan.Text))
            {
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"PositionName = '{cbBoPhan.Text.Replace("'", "''")}' ";
            }

            DataView dv = dtNV.DefaultView;
            dv.RowFilter = filter;
            dgvNhanVien.DataSource = dv;
        }

        private void Panel_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvNhanVien.AllowUserToAddRows = true;
            dgvNhanVien.ReadOnly = false;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;

            var dao = new EmployeeDAO();
            bool allOk = true;

            foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
            {
                int id = (int)row.Cells["EmployeeID"].Value;
                if (!dao.DeleteEmployee(id))
                    allOk = false;
            }

            MessageBox.Show(allOk ? "Đã xóa thành công!" : "Có dòng bị lỗi khi xóa.");
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var emp = new Employee
            {
                FullName = txtFullName.Text,
                DateOfBirth = DateTime.Parse(txtBirthDate.Text),
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = int.Parse(txtDepartmentID.Text),
                PositionID = int.Parse(txtPositionID.Text),
                HireDate = DateTime.Parse(txtHireDate.Text),
                isProbation = int.Parse(txtIsProbation.Text),
                isFired = int.Parse(txtIsFired.Text),
                password = txtPassword.Text
            };

            if (new EmployeeDAO().InsertEmployee(emp))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            ApplyNhanVienFilter();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count == 0) return;
            var row = dgvNhanVien.SelectedRows[0];

            txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtBirthDate.Text = row.Cells["BirthDate"].Value.ToString();
            txtGender.Text = row.Cells["Gender"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtDepartmentID.Text = row.Cells["DepartmentID"].Value.ToString();
            txtPositionID.Text = row.Cells["PositionID"].Value.ToString();
            txtHireDate.Text = row.Cells["HireDate"].Value.ToString();
            txtIsProbation.Text = Convert.ToInt32(row.Cells["IsProbation"].Value).ToString();
            txtIsFired.Text = Convert.ToInt32(row.Cells["IsFired"].Value).ToString();
            txtPassword.Text = row.Cells["Password"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text, out int id)) return;

            var emp = new Employee
            {
                EmployeeID = int.Parse(txtEmployeeID.Text),
                FullName = txtFullName.Text,
                DateOfBirth = DateTime.Parse(txtBirthDate.Text),
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = int.Parse(txtDepartmentID.Text),
                PositionID = int.Parse(txtPositionID.Text),
                HireDate = DateTime.Parse(txtHireDate.Text),
                isProbation = int.Parse(txtIsProbation.Text),
                isFired = int.Parse(txtIsFired.Text),
                password = txtPassword.Text
            };

            if (new EmployeeDAO().UpdateEmp(emp))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
    }
}
