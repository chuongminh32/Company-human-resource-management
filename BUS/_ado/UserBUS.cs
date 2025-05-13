using CompanyHRManagement.DAL._ado;
using CompanyHRManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHRManagement.DAL._ado;


namespace CompanyHRManagement.BUS._ado
{
    class UserBUS
    {
        private UserDAO userDAO = new UserDAO();
        public User getInfoUser(string username) => userDAO.GetUserByUsername(username);

        // Hàm lấy tên phòng ban thông qua id phòng ban:

    }
}
