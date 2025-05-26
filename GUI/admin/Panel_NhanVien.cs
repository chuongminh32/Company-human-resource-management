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

                dgvNhanVien.ReadOnly = true;

                dgvNhanVien.Columns["EmployeeID"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["FullName"].HeaderText = "Họ tên";
                dgvNhanVien.Columns["BirthDate"].HeaderText = "Ngày sinh";
                dgvNhanVien.Columns["Gender"].HeaderText = "Giới tính";
                dgvNhanVien.Columns["Address"].HeaderText = "Địa chỉ";
                dgvNhanVien.Columns["Phone"].HeaderText = "SĐT";
                dgvNhanVien.Columns["Email"].HeaderText = "Email";
                dgvNhanVien.Columns["DepartmentID"].HeaderText = "Mã Phòng";
                dgvNhanVien.Columns["PositionID"].HeaderText = "Mã Bộ phận";
                dgvNhanVien.Columns["DepartmentName"].HeaderText = "Tên Phòng ban";
                dgvNhanVien.Columns["PositionName"].HeaderText = "Tên Bộ phận";
                dgvNhanVien.Columns["HireDate"].HeaderText = "Ngày tuyển dụng";
                dgvNhanVien.Columns["IsProbation"].HeaderText = "Thử việc";
                dgvNhanVien.Columns["IsFired"].HeaderText = "Đã nghỉ";
                dgvNhanVien.Columns["Password"].HeaderText = "Mật khẩu";

                dgvNhanVien.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

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
            // Kiểm tra các trường bắt buộc không được để trống
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentID.Text) ||
                string.IsNullOrWhiteSpace(txtPositionID.Text) ||
                string.IsNullOrWhiteSpace(txtIsProbation.Text) ||
                string.IsNullOrWhiteSpace(txtIsFired.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra các trường số hợp lệ
            if (!int.TryParse(txtDepartmentID.Text, out int departmentId))
            {
                MessageBox.Show("Mã phòng ban không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPositionID.Text, out int positionId))
            {
                MessageBox.Show("Mã chức vụ không hợp lệ!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIsProbation.Text, out int isProbation))
            {
                MessageBox.Show("Trạng thái thử việc không hợp lệ! (Chỉ nhập 0 hoặc 1)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtIsFired.Text, out int isFired))
            {
                MessageBox.Show("Trạng thái nghỉ việc không hợp lệ! (Chỉ nhập 0 hoặc 1)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Employee nếu mọi thứ đều hợp lệ
            var emp = new Employee
            {
                FullName = txtFullName.Text,
                DateOfBirth = dtpBirthDay.Value,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = departmentId,
                PositionID = positionId,
                HireDate = dtpHireDate.Value,
                isProbation = isProbation,
                isFired = isFired,
                password = txtPassword.Text
            };

            // Gọi DAO để thêm nhân viên
            if (new EmployeeDAO().InsertEmployee(emp))
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // check null 
            txtEmployeeID.Text = row.Cells["EmployeeID"].Value == DBNull.Value ? "" : row.Cells["EmployeeID"].Value.ToString();
            txtFullName.Text = row.Cells["FullName"].Value == DBNull.Value ? "" : row.Cells["FullName"].Value.ToString();
            dtpBirthDay.Value = row.Cells["BirthDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["BirthDate"].Value);
            txtGender.Text = row.Cells["Gender"].Value == DBNull.Value ? "" : row.Cells["Gender"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value == DBNull.Value ? "" : row.Cells["Address"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value == DBNull.Value ? "" : row.Cells["Phone"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value == DBNull.Value ? "" : row.Cells["Email"].Value.ToString();
            txtDepartmentID.Text = row.Cells["DepartmentID"].Value == DBNull.Value ? "" : row.Cells["DepartmentID"].Value.ToString();
            txtPositionID.Text = row.Cells["PositionID"].Value == DBNull.Value ? "" : row.Cells["PositionID"].Value.ToString();
            dtpHireDate.Value = row.Cells["HireDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["HireDate"].Value);
            txtIsProbation.Text = row.Cells["IsProbation"].Value == DBNull.Value ? "0" : Convert.ToInt32(row.Cells["IsProbation"].Value).ToString();
            txtIsFired.Text = row.Cells["IsFired"].Value == DBNull.Value ? "0" : Convert.ToInt32(row.Cells["IsFired"].Value).ToString();
            txtPassword.Text = row.Cells["Password"].Value == DBNull.Value ? "" : row.Cells["Password"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeID.Text, out int id)) return;

            var emp = new Employee
            {
                EmployeeID = int.Parse(txtEmployeeID.Text),
                FullName = txtFullName.Text,
                DateOfBirth = dtpBirthDay.Value,
                Gender = txtGender.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                DepartmentID = int.Parse(txtDepartmentID.Text),
                PositionID = int.Parse(txtPositionID.Text),
                HireDate = dtpHireDate.Value,
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
