using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.DocGias
{
    internal class DocGiaDAO : DAO<DocGia>
    {
        public override bool Delete(string key)
        {
            throw new NotImplementedException();
        }

        public override DocGia FindByKey(string key)
        {
            throw new NotImplementedException();
        }

        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<DocGia> GetData()
        {
            using(DataContext context = new DataContext())
            {
                return context.DocGias.ToList();
            }
        }

        public override bool Insert(DocGia model)
        {
            throw new NotImplementedException();
        }
    }

}
