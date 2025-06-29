using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Admins
{
    internal class AdminDAO
    {
        private readonly DataContext kn = new DataContext();
        public List<Admin> Get_Admin()
        {
            return kn.Admins.ToList();
        }
        public void Insert_Admin(Admin admin)
        {
            kn.Admins!.Add(admin);
            kn.SaveChanges();
        }
        public void Update_Admin(Admin adm)
        {

            var ad = kn.Admins.Find(adm.id);
            if (ad != null)
            {
                ad.username = adm.username;
                ad.password = adm.password;
                kn.SaveChanges();
            }
        }
        public void Delete_Admin(int ma)
        {
            var ad = kn.Admins.Find(ma);
            if (ad != null)
            {
                kn.Admins.Remove(ad);
                kn.SaveChanges();
            }
        }
        public List<Admin> Search_User_Admin(string tim)
        {
            List<Admin> ds = kn.Admins.Where(s => s.username == tim).ToList();
            return ds;
        }
    }
}
