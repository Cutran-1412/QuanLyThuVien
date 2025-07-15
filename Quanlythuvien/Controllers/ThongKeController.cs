using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quanlythuvien.Models;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Quanlythuvien.Controllers
{
    public class ThongKeController
    {
        private ThongKeDAO tkDao = new ThongKeDAO();
        public int Soluongdausach()
        {
            return tkDao.sldausach();
        }
        public int Soluongsach()
        {
            return tkDao.slsach();
        }
        public int Soluongsachmuon()
        {
            return tkDao.slsachmuon();
        }
        public int Soluongsachcon()
        {
            return Soluongsach() - Soluongsachmuon();
        }
        public decimal Tongtiensach()
        {
            return tkDao.ttiensach();
        }
        public int Soluongdocgia()
        {
            return tkDao.sldocgia();
        }
        public int Soluongdocgiadangmuon()
        {
            return tkDao.sldgdangmuon();
        }
        public decimal Tongtienphat()
        {
            return tkDao.Ttienphat();
        }

        public decimal Tongtienphatdanop()
        {
            return tkDao.Ttiendanop();
        }
    }
}
