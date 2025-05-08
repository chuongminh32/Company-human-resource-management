using CompanyHRManagement.Models;
using System.Data.SqlClient;

namespace CompanyHRManagement.DAL_ADO
{

    public class UserDAO
    {
        private DBConnection dbConnection = new DBConnection();

        // Hàm trả về thông tin user thông qua username 
        public User GetUserByUsername(string username)
        {

            string query = "SELECT * FROM Users WHERE Username = @Username";
            using (var conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return new User()
                        {
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                            FullName = reader.GetString(reader.GetOrdinal("FullName")),
                            Role = reader.GetString(reader.GetOrdinal("Role")),
                            CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
                            IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
                        };
                    }
                }
            }
            return null;
        }
    }
}

