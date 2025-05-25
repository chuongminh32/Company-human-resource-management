using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHRManagement.DAL._ado
{
    public class PositionDAO
    {
        //Lấy danh sách tên trả vào comboBox
        public List<string> GetPositionNames()
        {
            List<string> position = new List<string>();

            string query = "SELECT PositionName FROM Positions";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            position.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return position;
        }
    }
}
