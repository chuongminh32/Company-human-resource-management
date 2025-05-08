using System.Collections.Generic;

public class EmployeeBUS
{
    private EmployeeDAO employeeDAO = new EmployeeDAO();

    public List<Employee> GetAllEmployees()
    {
        return employeeDAO.GetAllEmployees();
    }

    public Employee GetEmployeeById(int employeeID)
    {
        return employeeDAO.GetEmployeeById(employeeID);
    }
}
