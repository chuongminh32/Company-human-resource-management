using System.Collections.Generic;

public class SalaryBUS
{
    // SalaryBUS.cs
    private SalaryDAO salaryDAO = new SalaryDAO();
    public List<Salary> LayLuongTheoNhanVien(int employeeId)
    {
        return salaryDAO.LayThongTinLuongTheoID(employeeId);
    }

    public decimal TinhTongLuongTheoThangNam(int emID, int month, int year)
    {
        return salaryDAO.TinhTongLuongTheoThangNam(emID, month, year);
    }

    public List<Salary> LayTatCaThongTinLuong_Admin() { 
        return salaryDAO.LayTatCaThongTinLuong_Admin();
    }

    public bool TaiLaiDataLuong(ref string error)
    {
        return salaryDAO.UpdateSalaries(ref error);
    }
}
