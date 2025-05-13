using System.Collections.Generic;

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

    public Employee GetEmployeeByEmail(string email)
    {
        return employeeDAO.GetEmployeeByEmail(email);
    }
}
