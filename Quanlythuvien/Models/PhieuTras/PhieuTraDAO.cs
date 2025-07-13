
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;

namespace Quanlythuvien.Models.PhieuTras
{
    internal class PhieuTraDAO : DAO<PhieuTra>
    {
        public override bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override PhieuTra FindByKey(string key)
        {

            using (DataContext context = new DataContext())
            {
                return context.PhieuTras.FirstOrDefault(p => p.MaPhieuTra == key);

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
            throw new NotImplementedException();
        }

        public override bool Insert(PhieuTra model)
        {
            using (DataContext context = new DataContext())
            {
                context.PhieuTras.Add(model);
                      context.SaveChanges();
                return true;
            }
        }
    }
}