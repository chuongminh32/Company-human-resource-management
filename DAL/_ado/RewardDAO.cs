using System.Collections.Generic;
using System.Data.SqlClient;
using System;

public class RewardDAO
{

    public List<Reward> GetRewardsByEmployeeId(int employeeId)
    {
        List<Reward> rewards = new List<Reward>();

        string query = "SELECT RewardID, EmployeeID, Reason, RewardDate, Amount " +
                       "FROM Rewards WHERE EmployeeID = @EmployeeID";

        using (SqlConnection conn = DBConnection.GetConnection())
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Reward reward = new Reward
                    {
                        RewardID = (int)reader["RewardID"],
                        EmployeeID = (int)reader["EmployeeID"],
                        Reason = reader["Reason"].ToString(),
                        RewardDate = (DateTime)reader["RewardDate"],
                        Amount = (decimal)reader["Amount"]
                    };
                    rewards.Add(reward);
                }
            }
        }

        return rewards;
    }
}
