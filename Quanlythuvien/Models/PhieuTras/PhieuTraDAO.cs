<<<<<<< HEAD
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
            throw new NotImplementedException();
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
=======
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

        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<PhieuTra> GetData()
        {
            throw new NotImplementedException();
        }

        public override bool Insert(PhieuTra model)
        {
            throw new NotImplementedException();
        }
    }
}
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
