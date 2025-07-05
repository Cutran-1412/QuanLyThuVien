using Quanlythuvien.Models.PhieuMuons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    internal class PhieuMuonController : Controller<PhieuMuon>
    {
       public PhieuMuonController() {
            this.dao = new PhieuMuonDAO();
        }

        public override int GetCount()
        {
            return this.dao.GetCount();
        }

        public override List<PhieuMuon> GetData()
        {
            return this.dao.GetData();
        }
    }
}
