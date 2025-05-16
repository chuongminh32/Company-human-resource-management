using System.Collections.Generic;
using System.Windows.Forms;

public class EmployeeBUS
{
    private EmployeeDAO employeeDAO = new EmployeeDAO();


    public Employee GetEmployeeById(int employeeID)
    {
        return employeeDAO.GetEmployeeById(employeeID);
    }

    public bool UpdateEmployee(Employee emp)
    {
        return employeeDAO.UpdateEmployee(emp);
    }

    public Employee LayDuLieuNhanVienQuaEmail(string email)
    {
        return employeeDAO.LayDuLieuNhanVienQuaEmail(email);
    }


    public List<Employee> GetAllEmployees()
    {
        return employeeDAO.GetAllEmployees();
    }
}
