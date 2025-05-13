using System;
using System.Data;
using System.Data.SqlClient;

public class DBConnection
{
    private static string connectionString = "Server=MINH-CHUONG;Database=CompanyHRManagement;Trusted_Connection=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result ?? 0; // Trả về 0 nếu DB trả về NULL
            }
        }
    }

    public static SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
    {
        SqlConnection conn = GetConnection();
        SqlCommand cmd = new SqlCommand(query, conn);

        if (parameters != null)
        {
            cmd.Parameters.AddRange(parameters);
        }

        conn.Open();
        // Sử dụng CommandBehavior.CloseConnection để khi reader bị đóng thì connection cũng tự đóng
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }




}
