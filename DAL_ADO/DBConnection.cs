using System;
using System.Data.SqlClient;

public class DBConnection
{
    string connectionString = "Server=MINH-CHUONG;Database=CompanyHRManagement;Trusted_Connection=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
