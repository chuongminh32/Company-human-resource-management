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
    public partial class Panel_ChamCong : UserControl
    {
        DataTable Attendance = null;
        DataTable Leave = null;
        String err = null;

        AttendanceDAO dbAttendance = new AttendanceDAO();
        LeaveDAO dbLeave = new LeaveDAO();

        private bool isEdit = false;

        public Panel_ChamCong()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                Attendance = new DataTable();
                Leave = new DataTable();
                Attendance.Clear();
                Leave.Clear();
                DataSet ds1 = dbAttendance.GetAttendance();
                DataSet ds2 = dbLeave.GetLeave();

                Attendance = ds1.Tables[0];
                Leave = ds2.Tables[0];
                
                dgv_Attendance.DataSource = Attendance;
                dgv_Leaves.DataSource = Leave;
                
                dgv_Attendance.AutoResizeColumns();
                dgv_Leaves.AutoResizeColumns();
                
                this.txtID.ResetText();
                this.txtTenNV.ResetText(); ;
                this.txtStartDate.ResetText();
                this.txtEndDate.ResetText();
                this.txtReason.ResetText();
                
                this.btnPheDuyet.Enabled = false;
                this.btnTuChoi.Enabled = false;
                //this.panel1.Enabled = false;

                dgv_Attendance.ReadOnly = !isEdit;
                //btnChinhSua.Enabled = isEdit;
                btnLuu.Enabled = isEdit;
                btnXoa.Enabled = isEdit;

                dgv_Leaves_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Attendance hay Leave. Lỗi rồi!!!");
            }
        }
        void CalculateAndDisplaySummary()
        {
            if (cbSelectDate.SelectedItem == null)
                return;
            if (DateTime.TryParse(cbSelectDate.SelectedItem?.ToString(), out DateTime selectedDate))
            {
                var dao = new AttendanceDAO();
                var (tongNV, tongNCtb, OTtong) = dao.GetAttendanceSummary(selectedDate);

                txtTongNV.Text = tongNV.ToString("0");
                txtNCtb.Text = tongNCtb.ToString("0.0");
                txtOT.Text = OTtong.ToString("0.0");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày hợp lệ!");
            }
        }
        void LoadDate()
        {
            var dao = new AttendanceDAO();
            var dates = dao.GetWorkDates();

            cbSelectDate.Items.Clear();
            DateFilter.Items.Clear();
            foreach (var d in dates)
            {
                cbSelectDate.Items.Add(d.ToString("yyyy-MM-dd"));
                DateFilter.Items.Add(d.ToString("yyyy-MM-dd"));
            }

            if (cbSelectDate.Items.Count > 0)
                cbSelectDate.SelectedIndex = 0;
        }
        private void FilterAttendanceData()
        {
            if (Attendance == null) return;

            string filter = "";

            if (!string.IsNullOrWhiteSpace(txtEmployeeID.Text))
            {
                if (int.TryParse(txtEmployeeID.Text.Trim(), out int empID))
                {
                    filter += $"EmployeeID = {empID}";
                }
                else
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ!");
                    return;
                }
            }

            if (DateFilter.SelectedItem != null)
            {
                if (DateTime.TryParse(DateFilter.SelectedItem.ToString(), out DateTime date))
                {
                    if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                    filter += $"WorkDate = '#{date:yyyy-MM-dd}#'"; // dùng dấu # nếu dùng DataView, hoặc đổi format tùy loại
                }
            }

            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                string nameFilter = txtTimKiem.Text.Trim().Replace("'", "''"); // escape dấu nháy đơn
                if (!string.IsNullOrEmpty(filter)) filter += " AND ";
                filter += $"EmployeeName LIKE '%{nameFilter}%'";
            }

            DataView dv = Attendance.DefaultView;
            dv.RowFilter = filter;

            dgv_Attendance.DataSource = dv;
        }

        private void dgv_Leaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_Leaves.CurrentCell.RowIndex;

            txtID.Text = dgv_Leaves.Rows[r].Cells[0].Value?.ToString();
            txtTenNV.Text = dgv_Leaves.Rows[r].Cells[2].Value?.ToString();
            txtStartDate.Text = dgv_Leaves.Rows[r].Cells[3].Value?.ToString();
            txtEndDate.Text = dgv_Leaves.Rows[r].Cells[4].Value?.ToString();
            txtReason.Text = dgv_Leaves.Rows[r].Cells[5].Value?.ToString();

            btnPheDuyet.Enabled = true;
            btnTuChoi.Enabled = true;
        }

        private void Panel_ChamCong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDate();
            CalculateAndDisplaySummary();
        }

        private void cbSelectDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateAndDisplaySummary();
        }

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null) return;

            int leaveID = Convert.ToInt32(txtID.Text);
            int employeeID = Convert.ToInt32(dgv_Leaves.CurrentRow.Cells["EmployeeID"].Value);

            if (dbLeave.UpdateLeaveStatus(leaveID, "Chấp nhận"))
            {
                SendNotificationToEmployee(
                    senderId: 12, // ID của quản lý đang đăng nhập
                    receiverId: employeeID,
                    messageContent: "Đơn nghỉ phép của bạn đã được phê duyệt"
                );

                MessageBox.Show("Đã phê duyệt đơn nghỉ phép!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi phê duyệt đơn!");
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null) return;

            int leaveID = Convert.ToInt32(txtID.Text);
            int employeeID = Convert.ToInt32(dgv_Leaves.CurrentRow.Cells["EmployeeID"].Value);

            if (dbLeave.UpdateLeaveStatus(leaveID, "Từ chối"))
            {
                SendNotificationToEmployee(
                    senderId: 12, // ID của quản lý đang đăng nhập
                    receiverId: employeeID,
                    messageContent: "Đơn nghỉ phép của bạn đã bị từ chối"
                );

                MessageBox.Show("Đã từ chối đơn nghỉ phép!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Có lỗi khi từ chối đơn!");
            }
        }
        private void SendNotificationToEmployee(int senderId, int receiverId, string messageContent)
        {
            try
            {
                var messageDAO = new MessageDAO();
                string formattedContent = $"[HỆ THỐNG] {messageContent} - {DateTime.Now:dd/MM/yyyy HH:mm}";

                bool success = messageDAO.GuiTin(
                    senderId: senderId,
                    receiverId: receiverId,
                    content: formattedContent
                );

                if (!success)
                {
                    Console.WriteLine("Không thể gửi thông báo qua hệ thống tin nhắn");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi thông báo: {ex.Message}");
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            isEdit = !isEdit;

            // Update button states
            btnChinhSua.Text = isEdit ? "Dừng chỉnh sửa" : "Chỉnh sửa";
            btnLuu.Enabled = isEdit;
            btnXoa.Enabled = isEdit;

            dgv_Attendance.ReadOnly = !isEdit;

            if (!isEdit)
            {
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // End any current edit
                dgv_Attendance.EndEdit();

                // Get changes
                DataTable changes = Attendance.GetChanges();

                if (changes != null && changes.Rows.Count > 0)
                {
                    // Update database
                    bool success = dbAttendance.UpdateAttendance(changes);

                    if (success)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công!");
                        Attendance.AcceptChanges();
                        LoadData(); // Refresh data
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi lưu dữ liệu!");
                        Attendance.RejectChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Không có thay đổi nào để lưu!");
                }
                // Exit edit mode
                isEdit = false;
                btnChinhSua.Text = "Chỉnh sửa";
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                dgv_Attendance.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_Attendance.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn bản ghi cần xóa!");
                return;
            }

            int attendanceID = Convert.ToInt32(dgv_Attendance.CurrentRow.Cells["AttendanceID"].Value);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dbAttendance.DeleteAttendance(attendanceID))
                {
                    MessageBox.Show("Xóa bản ghi thành công!");
                    LoadData(); // Refresh data
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa bản ghi!");
                }
            }
        }

        private void btnXoaNP_Click(object sender, EventArgs e)
        {
            if (dgv_Leaves.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn nghỉ phép cần xóa!");
                return;
            }

            int leaveID = Convert.ToInt32(txtID.Text);

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa đơn nghỉ phép này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (dbLeave.XoaNghiPhep(leaveID))
                    {
                        MessageBox.Show("Xóa đơn nghỉ phép thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn nghỉ phép không thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa đơn nghỉ phép: {ex.Message}");
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterAttendanceData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
