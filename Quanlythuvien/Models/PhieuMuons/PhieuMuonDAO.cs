
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Models.PhieuTras;
using Quanlythuvien.Models.Sachs;

namespace Quanlythuvien.Models.PhieuMuons
{
    public class PhieuMuonDAO : DAO<PhieuMuon>
    {
        public override bool Delete(string key)
        {
            using (DataContext context = new DataContext())
            {
                var temp = context.PhieuMuons.Find(key);
                if (temp == null) return false;
                context.PhieuMuons.Remove(temp);
                context.SaveChanges();
                return true;
            }
        }

        public override PhieuMuon FindByKey(string key)
        {
            using (DataContext context = new DataContext())
            {
                var  phieuMuon = context.PhieuMuons
                    .Where(pm=>pm.MaPhieuMuon==key)
                    .Include(pm=>pm.ChiTietPhieuMuons)
                    .ThenInclude(ct =>ct.Sach)
                    .FirstOrDefault();
                return phieuMuon;
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
            using (DataContext context = new DataContext())
            {
                return context.PhieuMuons
                    .OrderBy(pm=>Convert.ToInt32(pm.MaPhieuMuon.Substring(2)))
                    .ToList();

            }
        }

        public override bool Insert(PhieuMuon model)
        {
            using (DataContext context = new DataContext())
            {
                context.PhieuMuons.Add(model);
                model.ChiTietPhieuMuons.ForEach(ct=>context.Attach(ct.Sach));
                context.SaveChanges();
                return true;
            }
        }
        public override PhieuMuon? GetLast()
        {
            using (DataContext context = new DataContext())
            {
                return context.PhieuMuons
                    .OrderByDescending(pm=>Convert.ToInt32(pm.MaPhieuMuon.Substring(2)))
                    .FirstOrDefault();
            }
        }
        public virtual List<PhieuMuon> GetPhieuMuonChuaTra()
        {
            using (DataContext context = new DataContext())
            {
                return context.PhieuMuons
                    .Include(pm => pm.ChiTietPhieuMuons)
                    .Where(pm=>pm.ChiTietPhieuMuons.Any(ct =>ct.DaTra == false))
                    .OrderBy(pm => Convert.ToInt32(pm.MaPhieuMuon.Substring(2)))
                    .ToList();
            }
        }
        public override List<PhieuMuon> Search(string luachon, string value)
        {
            using (DataContext context = new DataContext())
            {
                if (value.Equals("Tất cả"))
                {
                    return this.GetData();
                }
                switch (luachon)
                {
                    case "Mã phiếu mượn" :
                        
                        return context.PhieuMuons
                            .Where(s => s.MaPhieuMuon.ToLower().Contains(value.ToLower()))
                             .OrderBy(pm => Convert.ToInt32(pm.MaPhieuMuon.Substring(2)))
                            .ToList();

                    case "Mã độc giả":
                        return context.PhieuMuons
                            .Where(s => s.MaDocGia.ToLower().Contains(value.ToLower()))
                             .OrderBy(pm => Convert.ToInt32(pm.MaPhieuMuon.Substring(2)))
                            .ToList();
                    case "Chưa trả":
                        return context.PhieuMuons
                            .Include(pm => pm.ChiTietPhieuMuons.Where(ct => ct.DaTra == false))
                           .ToList();
                            
                    default: return null;
                }

               
            }
        }
    }
}