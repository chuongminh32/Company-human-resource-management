using System;
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

    public List<int> LayDanhSachNam()
    {
        return salaryDAO.GetDistinctSalaryYears();
    }
    public List<Salary> Loc_TimKiem(
        string salaryIDStr,
        string fullName,
        string baseSalaryStr,
        string allowanceStr,
        string bonusStr,
        string penaltyStr,
        string overtimeHoursStr,
        string salaryMonthStr,
        string salaryYearStr)
    {
        // Chuyển đổi string sang kiểu dữ liệu chuẩn
        int? salaryID = TryParseIntNullable(salaryIDStr);
        decimal? baseSalary = TryParseDecimalNullable(baseSalaryStr);
        decimal? allowance = TryParseDecimalNullable(allowanceStr);
        decimal? bonus = TryParseDecimalNullable(bonusStr);
        decimal? penalty = TryParseDecimalNullable(penaltyStr);
        int? overtimeHours = TryParseIntNullable(overtimeHoursStr);

        return salaryDAO.SearchSalaries(
            salaryID,
            fullName,
            baseSalary,
            allowance,
            bonus,
            penalty,
            overtimeHours,
            salaryMonthStr,
            salaryYearStr
        );
    }

    private int? TryParseIntNullable(string s)
    {
        if (int.TryParse(s, out int result))
            return result;
        return null;
    }

    private decimal? TryParseDecimalNullable(string s)
    {
        if (decimal.TryParse(s, out decimal result))
            return result;
        return null;
    }

    public bool ThemLuong(string fullName,
    string monthStr, string yearStr, string allowanceStr, ref string error)
    {
        // Kiểm tra thông tin bắt buộc
        if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(monthStr) || string.IsNullOrWhiteSpace(yearStr))
        {
            error = "Vui lòng nhập họ tên, tháng và năm.";
            return false;
        }

        // Kiểm tra tháng và năm là số
        if (!int.TryParse(monthStr, out int month) || !int.TryParse(yearStr, out int year))
        {
            error = "Tháng và năm phải là số hợp lệ.";
            return false;
        }

        // Kiểm tra allowance là số
        decimal allowance = 0;
        if (!string.IsNullOrWhiteSpace(allowanceStr) && !decimal.TryParse(allowanceStr, out allowance))
        {
            error = "Phụ cấp (Allowance) phải là số hợp lệ.";
            return false;
        }

        // Mặc định các giá trị khác là 0
        decimal bonus = 0;
        decimal penalty = 0;
        int overtime = 0;

        // Gọi DAO để thêm lương
        return salaryDAO.InsertSalary(fullName, month, year, allowance, bonus, penalty, overtime, ref error);
    }

    public bool XoaLuongtheoIDs(List<int> salaryIDs, ref string error)
    {
        return salaryDAO.DeleteSalariesByIDs(salaryIDs, ref error);
    }

    public bool SuaLuong(int salaryID, string fullName, string allowanceStr, string monthStr, string yearStr, ref string error)
    {
        if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(monthStr) || string.IsNullOrWhiteSpace(yearStr) || string.IsNullOrWhiteSpace(allowanceStr))
        {
            error = "Vui lòng nhập đầy đủ thông tin.";
            return false;
        }

        if (!int.TryParse(monthStr, out int month) || month < 1 || month > 12)
        {
            error = "Tháng không hợp lệ.";
            return false;
        }

        if (!int.TryParse(yearStr, out int year) || year < 1900)
        {
            error = "Năm không hợp lệ.";
            return false;
        }

        if (!decimal.TryParse(allowanceStr, out decimal allowance) || allowance < 0)
        {
            error = "Allowance phải là số không âm.";
            return false;
        }

        return salaryDAO.UpdateSalaryByID(salaryID, fullName, allowance, month, year, ref error);
    }


}
