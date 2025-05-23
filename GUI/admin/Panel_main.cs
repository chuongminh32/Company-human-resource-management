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

namespace CompanyHRManagement.GUI.admin
{
    public partial class Panel_main : UserControl
    {
        public Panel_main()
        {
            InitializeComponent();
        }

        // Giả sử lblSoPhongBan là Label trên Form của bạn

        public void LoadDashBoard_Count()
        {
            DashBoard_adminBUS bus = new DashBoard_adminBUS();
            int countDepartment = bus.GetDepartmentCount();  // Lấy số lượng phòng ban
            int countEmployees = bus.GetAllEmployeeCount();
            int countProbation = bus.GetProbationEmployeeCount();
            int countPosition = bus.GetPositionCount();
            decimal totalReward = bus.GetTotalRewardAmount()/1000000;
            int countInsurance = bus.GetValidInsuranceCount();

            // Hiển thị lên label
            lblSoPhongBan.Text = countDepartment.ToString(); 
            lblTongNhanVien.Text = countEmployees.ToString();
            lblNhanVienThuViec.Text = countProbation.ToString();
            lblRole.Text = countPosition.ToString();
            lblTongLuongThuong.Text = totalReward.ToString();
            lblSoBaoHiemConHan.Text = countInsurance.ToString();
        }


    }
}
