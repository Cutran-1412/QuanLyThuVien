
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quanlythuvien.Models.PhieuMuons;

namespace Quanlythuvien.Models.PhieuTras
{
    internal class PhieuTraDAO : DAO<PhieuTra>
    {
        public override bool Delete(string key)
        {
            using (var context = new DataContext())
            {
                var pt = context.PhieuTras.Find(key);
                if (pt != null)
                {

                    context.PhieuTras.Remove(pt);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        
        }
        public override List<PhieuTra> Search(string luachon, string value)
        {
            using(var context = new DataContext())
            {
                if (value == "Tất cả") return this.GetData();
                switch (luachon)
                {
                    case "MaPhieuMuon":
                        return context.PhieuTras
                            .Where(pt => pt.MaPhieuMuon.Equals(value))
                              .OrderBy(pm => Convert.ToInt32(pm.MaPhieuTra.Substring(2)))
                            .ToList();
                    default: return null; 
                }
            }
           
        }

        public override PhieuTra FindByKey(string key)
        {

            using (DataContext context = new DataContext())
            {
                return context.PhieuTras
                    .Include(pt=>pt.ChiTietPhieuTras)
                    .Include(pt=>pt.PhieuMuon)
                    .ThenInclude(pm=>pm.ChiTietPhieuMuons)
                    .ThenInclude(ct=>ct.Sach)
                    .FirstOrDefault(p => p.MaPhieuTra == key);

            }
        }

        public override int GetCount()
        {
            using(DataContext context = new DataContext()) 
            {
                return context.PhieuTras.Count();
            }
        }

        public override List<PhieuTra> GetData()
        {
            using (DataContext context = new DataContext())
            {
                return context.PhieuTras
                      .OrderBy(pm => Convert.ToInt32(pm.MaPhieuTra.Substring(2)))
                    .ToList();

            }
        }

        public override bool Insert(PhieuTra model)
        {
            using (DataContext context = new DataContext())
            {
                context.PhieuTras.Add(model);
                model.ChiTietPhieuTras.ForEach(ct=>context.Attach(ct.Sach));
                context.SaveChanges();
                return true;
            }
        }
        public override PhieuTra? GetLast()
        {
            using (DataContext context = new DataContext())
            {
                return context.PhieuTras
                    .OrderByDescending(pm => Convert.ToInt32(pm.MaPhieuTra.Substring(2)))
                    .FirstOrDefault();
            }

        }
    }
}