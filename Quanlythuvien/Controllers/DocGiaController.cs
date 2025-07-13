using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;
using Quanlythuvien.Models.DocGias;

namespace Quanlythuvien.Controllers
{

    public class DocGiaController 
    {
        public readonly DocGiaDAO dgdao = new DocGiaDAO();
        public List<DocGia> Get_DocGia()
        {
            return dgdao.Get_DocGia();
        }
        public DocGia? Get_DocGia_Ma(string ma)
        {
            return dgdao.Check(ma);
        }
        public void Insert_DocGia(DocGia dg)
        {
            dgdao.Insert(dg);
        }
        public void Update_Docgia(DocGia dg)
        {
            dgdao.Update(dg);
        }
        public List<DocGia> Search_Docgia(string luachon,string keyword)
        {
            return dgdao.Search(luachon, keyword);
        }
    }
}
