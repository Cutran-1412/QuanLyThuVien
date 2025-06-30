using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Controllers
{
    internal class AdminController
    {
        public bool Check_TaiKhoan_Admin(Admin ad)
        {

            if (new AdminDAO().Search_Admin(ad).Count > 0) 
            {
                return true;
            }
            return false;
        }
        public List<Admin> Get_All_Admin()
        {
            return new AdminDAO().Get_Admin();
        }
        public void Insert_TaiKhoan_Admin(Admin ad)
        {
            new AdminDAO().Insert_Admin(ad);
        }
        public void Update_TaiKhoan_Admin(Admin ad)
        {
            new AdminDAO().Update_Admin(ad);
        }
        public void Delete_TaiKhoan_Admin(int id)
        {
            new AdminDAO().Delete_Admin(id);
        }
        public List<Admin> Seach_User_Admin(string username)
        {
            return new AdminDAO().Search_User_Admin(username);
        }
    }
}
