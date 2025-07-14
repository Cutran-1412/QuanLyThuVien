using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models.PhieuMuons
{
    internal class ChiTietPhieuMuonDAO : DAO<ChiTietPhieuMuon>
    {
        public override bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override ChiTietPhieuMuon FindByKey(string key)
        {
            throw new NotImplementedException();
        }

        public override int GetCount()
        {
            using (DataContext context = new())
            {
                return context.ChiTietPhieuMuons.Count();
            }
        }

        public override List<ChiTietPhieuMuon> GetData()
        {
            using(DataContext context = new DataContext())
            {
                return context.ChiTietPhieuMuons.ToList();
            } 
        }

        public override bool Insert(ChiTietPhieuMuon model)
        {
            using (DataContext context = new DataContext())
            {
                context.ChiTietPhieuMuons.Add(model);
                context.SaveChanges();
                return true;
            }
        }
        public virtual bool TraSach(string maPhieuMuon, string maSach)
        {
            using (DataContext context = new DataContext())
            {
                var ctPhieuMuon = context.ChiTietPhieuMuons.FirstOrDefault(ct =>ct.MaPhieuMuon== maPhieuMuon && ct.MaSach== maSach);
                if (ctPhieuMuon != null)
                {
                    ctPhieuMuon.DaTra = true;
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public virtual ChiTietPhieuMuon GetByKey(string maPhieuMuon, string maSach)
        {
            using (DataContext context = new DataContext())
            {            
                var  ctPhieuMuon = context.ChiTietPhieuMuons.FirstOrDefault(ct => ct.MaPhieuMuon == maPhieuMuon && ct.MaSach == maSach);
                return ctPhieuMuon;
            }
        }

    }
}
