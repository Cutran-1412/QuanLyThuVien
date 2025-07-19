using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Controllers
{
    internal class AdminController
    {
        private readonly AdminDAO addao = new AdminDAO();
        public List<Admin> Get_Admin()
        {
            return addao.Get_All();
        }
        public bool Check_TaiKhoan_Admin(Admin ad)
        {
            if(addao.Get_Admin(ad) != null)
            {
                return true;
            }
            return false;
        }
        public void Insert_Admin(Admin ad)
        {
            addao.Insert(ad);
        }
        public void Update_Admin(Admin ad)
        {
            addao.Update(ad);
        }
        public void Delete_Admin(int id)
        {
            addao.Delete(id);
        }
        public List<Admin> Search_Admin(string keyword)
        {
            return addao.Search(keyword);
        }
        public bool CheckUser(string user)
        {
            return addao.Check(user);
        }
    }
}
