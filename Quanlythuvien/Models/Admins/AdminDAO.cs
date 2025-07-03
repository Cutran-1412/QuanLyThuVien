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
        public List<Admin> Get_All()
        {
            return kn.Admins.ToList();
        }
        public Admin Get_Admin(Admin admin)
        {
            return kn.Admins.Where(s => s.Username == admin.Username && s.Password == admin.Password).FirstOrDefault();
        }
        public void Insert(Admin admin)
        {
            kn.Admins!.Add(admin);
            kn.SaveChanges();
        }
        public void Update(Admin adm)
        {

            var ad = kn.Admins.Find(adm.Id);
            if (ad != null)
            {
                ad.Username = adm.Username;
                ad.Password = adm.Password;
                kn.SaveChanges();
            }
        }
        public void Delete(int ma)
        {
            var ad = kn.Admins.Find(ma);
            if (ad != null)
            {
                kn.Admins.Remove(ad);
                kn.SaveChanges();
            }
        }
        public List<Admin> Search(string tim)
        {
            List<Admin> ds = kn.Admins.Where(s => s.Username == tim).ToList();
            return ds;
        }
    }
}
