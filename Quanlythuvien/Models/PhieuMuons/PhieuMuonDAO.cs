using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models.PhieuMuons
{
    internal class PhieuMuonDAO :DAO<PhieuMuon>
    {
        public override bool Delete(string key)
        {
            using (DataContext context = new DataContext())
            {
                PhieuMuon temp = context.PhieuMuons.Find(key);
                if (temp == null) return false;
                context.PhieuMuons.Remove(temp);
                context.SaveChanges();
                return true;    
            }
        }

        public override int GetCount()
        {
            using (DataContext context = new DataContext())
            {
                return context.PhieuMuons.Count();
            }
        }

        public override List<PhieuMuon> GetData()
        {
            using(DataContext context = new DataContext())
            {
                return context.PhieuMuons.ToList();
            } 
        }

        public override bool Insert(PhieuMuon model)
        {
            using (DataContext context = new DataContext())
            {
                context.PhieuMuons.Add(model);
                context.SaveChanges();
                return true;
            }
        }
    }
}
