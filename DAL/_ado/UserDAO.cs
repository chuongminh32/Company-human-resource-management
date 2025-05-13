using CompanyHRManagement.Models;
using System.Data.SqlClient;

namespace CompanyHRManagement.DAL._ado
{

    public class UserDAO
    {
        private DBConnection dbConnection = new DBConnection();

        // Hàm trả về thông tin user thông qua username 
        public User GetUserByUsername(string username)
        {

            string query = "SELECT * FROM Users WHERE Username = @Username";
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    var reader = cmd.ExecuteReader();
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

        // Hàm lấy tên phòng ban thông qua id phòng ban: 
        //public string GetDepartmentNameById(int departmentId)
        //{
        //    string query = "SELECT DepartmentName FROM Departments WHERE DepartmentID = @DepartmentID";
        //    using (var conn = DBConnection.GetConnection())
        //    {
        //        conn.Open();
        //        using (var cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@DepartmentID", departmentId);
        //            var reader = cmd.ExecuteReader();
        //            if (reader.Read())
        //            {
        //                return reader.GetString(reader.GetOrdinal("DepartmentName"));
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}

