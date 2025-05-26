using System.Collections.Generic;
using System.Data.SqlClient;
using System;

public class DisciplineDAO
{

    public List<Discipline> GetDisciplinesByEmployeeId(int employeeId)
    {
        List<Discipline> disciplines = new List<Discipline>();

        string query = "SELECT DisciplineID, EmployeeID, Reason, DisciplineDate, Amount " +
                       "FROM Disciplines WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Discipline discipline = new Discipline
                    {
                        DisciplineID = (int)reader["DisciplineID"],
                        EmployeeID = (int)reader["EmployeeID"],
                        Reason = reader["Reason"].ToString(),
                        DisciplineDate = (DateTime)reader["DisciplineDate"],
                        Amount = (decimal)reader["Amount"]
                    };
                    disciplines.Add(discipline);
                }
            }
        }

        return disciplines;
    }
}
