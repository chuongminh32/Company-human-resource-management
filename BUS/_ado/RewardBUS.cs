using System.Collections.Generic;

public class RewardBUS
{
    private RewardDAO rewardDAO = new RewardDAO();

    public List<Reward> LayDanhSachThuongTheoNhanVien(int employeeId)
    {
        return rewardDAO.GetRewardsByEmployeeId(employeeId);
    }
}
