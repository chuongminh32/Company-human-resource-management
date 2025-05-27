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
using CompanyHRManagement.Models;

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_Message : UserControl
    {
        public int CurrentUserId { get; set; }
        DataTable TNMoi = null;
        String err = null;

        MessageDAO dbMess = new MessageDAO();

        public Panel_Message()
        {
            InitializeComponent();
        }

        private void LoadSent()
        {
            try
            {
                TNMoi = new DataTable();
                TNMoi.Clear();
                DataSet ds = dbMess.GetMessage();

                TNMoi = ds.Tables[0];

                dgvMess.DataSource = TNMoi;

                dgvMess.AutoResizeColumns();
                dgvMess.ReadOnly = true;

                dgvMess.Columns["MessageID"].HeaderText = "Mã tin";
                dgvMess.Columns["SenderID"].HeaderText = "Mã ngưởi gửi";
                dgvMess.Columns["ReceiverID"].HeaderText = "Mã người nhận";
                dgvMess.Columns["ReceiverName"].HeaderText = "Tên người nhận";
                dgvMess.Columns["Content"].HeaderText = "Nội dung";
                dgvMess.Columns["SentAt"].HeaderText = "Thời gian";

                dgvMess.DefaultCellStyle.Font = new Font("Segoe UI", 11);
                dgvMess.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);

                if (!dgvMess.Columns.Contains("colEdit"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
                    {
                        Name = "colEdit",
                        HeaderText = "",
                        Text = "✏️",
                        UseColumnTextForButtonValue = true,
                        Width = 40
                    };
                    dgvMess.Columns.Add(btnEdit);
                }

                if (!dgvMess.Columns.Contains("colDelete"))
                {
                    DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                    {
                        Name = "colDelete",
                        HeaderText = "",
                        Text = "❌",
                        UseColumnTextForButtonValue = true,
                        Width = 40
                    };
                    dgvMess.Columns.Add(btnDelete);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Message. Lỗi rồi!!!");
            }

        }

        private void LoadReceiverList()
        {
            var dt = new EmployeeDAO().GetAllEmployees();

            cbReceiver.DataSource = dt;
            cbReceiver.DisplayMember = "FullName";
            cbReceiver.ValueMember = "EmployeeID";
            cbReceiver.SelectedIndex = -1;
        }

        private void btnGuiTN_Click(object sender, EventArgs e)
        {
            if (cbReceiver.SelectedValue == null || string.IsNullOrWhiteSpace(txtND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var dao = new MessageDAO();
            bool result = dao.GuiTin(CurrentUserId, (int)cbReceiver.SelectedValue, txtND.Text);
            if (result)
            {
                MessageBox.Show("Gửi thành công!");
                txtND.Clear();
                LoadSent();
            }
            else
            {
                MessageBox.Show("Gửi thất bại!");
            }
        }

        private void dgvLSTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object val = dgvMess.CurrentRow.Cells["MessageID"].Value;
            int messageId = val != DBNull.Value ? Convert.ToInt32(val) : -1; // hoặc xử lý khác tùy logic


            if (dgvMess.Columns[e.ColumnIndex].Name == "colEdit")
            {
                string oldContent = dgvMess.Rows[e.RowIndex].Cells["Content"].Value.ToString();
                string newContent = ShowDialog("Sửa nội dung:", oldContent);
                if (!string.IsNullOrWhiteSpace(newContent))
                {
                    var dao = new MessageDAO();
                    dao.UpdateTinNhanMoi(messageId, newContent);
                    LoadSent();
                }
            }
            else if (dgvMess.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (MessageBox.Show("Xác nhận xóa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new MessageDAO().XoaTin(messageId);
                    LoadSent();
                }
            }
        }

        private void Panel_Message_Load(object sender, EventArgs e)
        {
            LoadSent();
            LoadReceiverList();
        }
        private static string ShowDialog(string title, string defaultValue)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                Text = title,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MinimizeBox = false,
                MaximizeBox = false
            };

            Label lbl = new Label() { Left = 20, Top = 20, Text = title, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 270, Width = 90, Top = 90, DialogResult = DialogResult.OK };

            prompt.Controls.Add(lbl);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

    }
}
