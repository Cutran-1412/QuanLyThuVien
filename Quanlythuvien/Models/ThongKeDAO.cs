using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models
{
    public class ThongKeDAO
    {
        public int sldausach()
        {
            using(DataContext db = new DataContext())
            {
                return db.Sachs.Count();
            }
        }
        public int slsach()
        {
            using (DataContext db = new DataContext())
            {
                return db.Sachs.Sum(s=>s.SoLuong);
            }
        }
        public int slsachmuon()
        {
            using (DataContext db = new DataContext()) 
            { 
                return db.ChiTietPhieuMuons.Sum(s=>s.SoLuongMuon);
            }
        }
        public Decimal ttiensach()
        {
            using (DataContext db = new DataContext()) 
            {
                return db.Sachs.Sum(s => s.DonGia);
            }
        }
        public int sldocgia()
        {
            using (DataContext db = new DataContext())
            {
                return db.DocGias.Count();
            }
        }
        public int sldgdangmuon()
        {
            using (DataContext db = new DataContext())
            {
                return db.DocGias.Count(s=>s.SoSachMuonToiDa <10);
            }
        }
        public decimal Ttienphat()
        {
            using (DataContext db = new DataContext())
            {
                return db.ChiTietPhieuTras.Sum(s=>s.TienPhat);
            }
        }
        public decimal Ttiendanop()
        {
            using (DataContext db = new DataContext())
            {
                return db.DocGias.Sum(s => s.TienPhat);
            }
        }
    }
}
