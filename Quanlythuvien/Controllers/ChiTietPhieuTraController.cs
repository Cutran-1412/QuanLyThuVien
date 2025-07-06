using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    public class ChiTietPhieuTraController : Controller<ChiTietPhieuTra>
    {
        public ChiTietPhieuTraController()
        {
            this.dao = new ChiTietPhieuTraDAO();
        }
    }
}
