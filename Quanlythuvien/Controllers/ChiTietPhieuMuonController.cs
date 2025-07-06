using Quanlythuvien.Models.PhieuMuons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    public class ChiTietPhieuMuonController : Controller<ChiTietPhieuMuon>
    {
        public ChiTietPhieuMuonController()
        {
            this.dao = new ChiTietPhieuMuonDAO ();
        }
        public bool TraSach(string chiTietId)
        {
           return ((ChiTietPhieuMuonDAO)dao).TraSach(chiTietId);
        }
    }
}
