using CompanyHRManagement.DAL._ado;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.BUS
{

    public class DashBoardBUS
    {
        private DashBoardDAO db_DAO = new DashBoardDAO();


        public string LayTenPhongBanQuaID(int idEm)
        {
            return db_DAO.LayTenPhongBanQuaEmployeeID(idEm);
        }
        public string LayTenViTriChucVu(int userID)
        {
            return db_DAO.LayVitriChucVuTheoID(userID);
        }


        //  Dashboard  - USER
        //  lương theo tháng 
        public List<(string MonthYear, decimal TotalSalary)> LayDuLieuLuong(int employeeId)
        {
            var raw = db_DAO.TongLuongTheoThang(employeeId);
            return raw.Select(r => ($"{r.Month}/{r.Year}", r.TotalSalary)).ToList();
        }

        // công theo tháng
        public List<(string MonthYear, int WorkDays)> LayDuLieuChamCong(int employeeId)
        {
            var raw = db_DAO.SoNgayCongTheoThang(employeeId);
            return raw.Select(r => ($"{r.Month}/{r.Year}", r.WorkDays)).ToList();
        }
    }
}
