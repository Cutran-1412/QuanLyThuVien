using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;
using Quanlythuvien.Models.DocGias;

namespace Quanlythuvien.Controllers
{
<<<<<<< HEAD
    internal class DocGiaController
    {
        private readonly DocGiaDAO dgdao = new DocGiaDAO();

        public List<DocGia> Get_DocGia()
        {
            return dgdao.Get_All();
        }
        public DocGia? Get_DocGia_Ma(string ma)
        {
             return dgdao.Check(ma);
        }
        public void Insert_DocGia(DocGia dg)
        {
            dgdao.Insert(dg);
        }
=======
    internal class DocGiaController : Controller<DocGia>
<<<<<<< HEAD
    {
        public DocGiaController() {
            this.dao = new DocGiaDAO();

        }
=======
    {
        public DocGiaController() {
            this.dao = new DocGiaDAO();

        }
        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override List<DocGia> GetData()
        {
            return this.dao.GetData();
        }
>>>>>>> d7b609e91d416c009426a33e96e3610c3d612981
>>>>>>> 1374692c096744187acb23e1f074c3c169300f37
    }
}
