
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
    }
}
