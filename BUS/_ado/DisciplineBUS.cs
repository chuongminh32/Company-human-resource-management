using System.Collections.Generic;

public class DisciplineBUS
{
    private DisciplineDAO disciplineDAO = new DisciplineDAO();

    public List<Discipline> LayDanhSachPhatTheoNhanVien(int employeeId)
    {
        return disciplineDAO.GetDisciplinesByEmployeeId(employeeId);
    }

    public List<Discipline> LayDanhSachPhat() {
        return disciplineDAO.GetDisciplinesWithEmployeeName();
    }

    public List<Discipline> TimKiemPhat(
        string disciplineID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        return disciplineDAO.SearchDisciplines(disciplineID, fullName, reason, day, month, year, amount);
    }
}
