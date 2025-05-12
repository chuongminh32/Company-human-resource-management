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

    public static object ExecuteScalar(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result ?? 0; // Trả về 0 nếu NULL trong DB
            }
        }
    }

    public static DataTable ExecuteQuery(string query)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }


    // Nếu muốn có hàm overload hỗ trợ tham số
    public static object ExecuteScalar(string query, SqlParameter[] parameters)
    {
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result ?? 0;
            }
        }
    }
}
