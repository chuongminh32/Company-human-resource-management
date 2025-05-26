using System.Collections.Generic;

public class DisciplineBUS
{
    private DisciplineDAO disciplineDAO = new DisciplineDAO();

    public List<Discipline> LayDanhSachPhatTheoNhanVien(int employeeId)
    {
        return disciplineDAO.GetDisciplinesByEmployeeId(employeeId);
    }
}
