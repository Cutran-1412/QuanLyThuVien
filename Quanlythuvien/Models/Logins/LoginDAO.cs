using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Login;

namespace Quanlythuvien.Models.Logins
{
    internal class LoginDAO
    {
        private readonly DataContext kn = new DataContext();
        public List<Admin> Get_Admin()
        {
            List<Admin> list = new List<Admin>();
            var ds = kn.Admins.Select(s=>new Admin { 
                id=s.id,
                username=s.username, 
                password=s.password 
            }).ToList();
            list = ds;
            return list;
        }
        public void Insert(Admin admin)
        {
            kn.Admins!.Add(admin);
            kn.SaveChanges();
        }
        public void Update(int ma, TextBox txtuser, TextBox txtpass)
        {

            var ad = kn.Admins.Find(ma);
            if (ad != null)
            {
                ad.username = txtuser.Text;
                ad.password = txtpass.Text;
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
    }
}
