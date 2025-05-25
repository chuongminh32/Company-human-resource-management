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

}
