using Quanlythuvien.Models.PhieuTras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Controllers
{
    internal class PhieuTraController:Controller<PhieuTra>
    {
        public PhieuTraController()
        {
            this.dao = new PhieuTraDAO();
        }
        public override bool Insert(PhieuTra model)
        {
            foreach (var ct in model.ChiTietPhieuTras)
            {
                new ChiTietPhieuMuonController().TraSach(model.MaPhieuMuon, ct.MaSach);
            }
            return base.Insert(model);
        }

    }
}
