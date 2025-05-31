using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;
namespace CompanyHRManagement.BUS._ado
{
    public class DashBoard_adminBUS
    {
        private DashBoard_adminDAO dao = new DashBoard_adminDAO();
        public int GetDepartmentCount()
        {
            return dao.CountDepartments();
        }

        public int GetAllEmployeeCount()
        {
            return dao.CountAllEmployees();
        }

        public int GetProbationEmployeeCount()
        {
            return dao.CountProbationEmployees();
        }

        public int GetPositionCount()
        {
            return dao.CountPositions();
        }

        public decimal GetTotalRewardAmount()
        {
            return DashBoard_adminDAO.GetTotalRewards();
        }

<<<<<<< HEAD

=======
        //public int GetValidInsuranceCount()
        //{
        //    return DashBoard_adminDAO.CountValidInsurances(); 
        //}
>>>>>>> d09c4af458b029ad99460e97c0480e4c03094419
    }
}
