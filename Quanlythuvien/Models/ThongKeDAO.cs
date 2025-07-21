using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;

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
                return db.Sachs.Sum(s=>s.SoLuong) + slsachmuon();
            }
        }
        public int slsachmuon()
        {
            using (DataContext db = new DataContext()) 
            {
                return db.ChiTietPhieuMuons.Where(s => s.DaTra == false).Sum(s => s.SoLuongMuon);      
            }
        }
        public Decimal ttiensach()
        {
            using (DataContext db = new DataContext()) 
            {
                return db.Sachs.Sum(s => s.DonGia*s.SoLuong);
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
                return db.PhieuMuons.Include(p => p.ChiTietPhieuMuons).Count(p => p.ChiTietPhieuMuons.Any(ct => ct.DaTra==false));
            }
        }
        public decimal Ttienphat()
        {
            using (DataContext db = new DataContext())
            {
                return db.ChiTietPhieuTras.Sum(s=>s.TienPhat);
            }
        }
        public List<ChiTietPhieuMuon> Get_CTPM()
        {
            using (DataContext db = new DataContext())
            {
                return db.ChiTietPhieuMuons.Where(s => s.DaTra == false).Include(s=>s.Sach).ToList();
            }
        }
        public List<ChiTietPhieuTra> Get_CTPT()
        {
            using (DataContext db = new DataContext())
            {
                return db.ChiTietPhieuTras.Where(s => s.TienPhat >0).ToList();
            }
        }
        public int TraQuaHan()
        {
            using (DataContext db = new DataContext())
            {
                return db.ChiTietPhieuTras.Where(s => s.TienPhat > 0).Count();
            }
        }
    }
}
