using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models;
using Quanlythuvien.Models.DocGias;

namespace Quanlythuvien.Controllers
{
    
    public class DocGiaController : Controller<DocGia>
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
    }
}
