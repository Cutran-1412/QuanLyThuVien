using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models.PhieuMuons
{
    public class ChiTietPhieuTraDAO: DAO<ChiTietPhieuTra>
    {
        public override bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override ChiTietPhieuTra FindByKey(string key)
        {
            throw new NotImplementedException();
        }

        public override int GetCount()
        {
            using (DataContext context = new DataContext())
            {
                return context.ChiTietPhieuTras.Count();
            }
        }

        public override List<ChiTietPhieuTra> GetData()
        {
            using(DataContext context = new DataContext())
            {
                return context.ChiTietPhieuTras.ToList();
            } 
        }

        public override bool Insert(ChiTietPhieuTra model)
        {
            using (DataContext context = new DataContext())
            {
                context.ChiTietPhieuTras.Add(model);
                context.SaveChanges();
                return true;
            }
        }
    }   
}
