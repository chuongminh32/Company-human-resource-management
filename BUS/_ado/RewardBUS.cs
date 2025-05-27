using System.Collections.Generic;

public class RewardBUS
{
    private RewardDAO rewardDAO = new RewardDAO();

    public List<Reward> LayDanhSachThuongTheoNhanVien(int employeeId)
    {
        return rewardDAO.GetRewardsByEmployeeId(employeeId);
    }

    public List<Reward> LayDanhSachKhenThuong()
    {
        return rewardDAO.GetRewardsWithEmployeeName();
    }
    public List<Reward> TimKiemThuong(
        string rewardID, string fullName, string reason,
        string day, string month, string year, string amount)
    {
        return rewardDAO.SearchRewards(rewardID, fullName, reason, day, month, year, amount);
    }
}
