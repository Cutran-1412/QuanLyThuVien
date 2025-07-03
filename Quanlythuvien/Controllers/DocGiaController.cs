using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;
using Quanlythuvien.Models.DocGias;

namespace Quanlythuvien.Controllers
{
    internal class DocGiaController
    {
        private readonly DocGiaDAO dgdao = new DocGiaDAO();

        public List<DocGia> Get_DocGia()
        {
            return dgdao.Get_All();
        }
    }
}
