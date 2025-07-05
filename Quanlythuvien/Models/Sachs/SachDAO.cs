using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Models.Sachs
{
    internal class SachDAO : DAO<Sach>
    {
        public override bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<Sach> GetData()
        {
           using(DataContext context = new DataContext())
            {
                return context.Sachs.ToList();
            }
        }

        public override bool Insert(Sach model)
        {
            throw new NotImplementedException();
        }
    }
}
