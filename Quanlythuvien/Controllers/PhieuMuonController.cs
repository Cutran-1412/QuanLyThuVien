using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
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
        public override bool Insert(PhieuMuon model)
        {
        //    List<ChiTietPhieuMuon> chiTietPhieuMuons = model.ChiTietPhieuMuons;
        //    foreach (var ct in chiTietPhieuMuons)
        //    {
        //        Sach sach = new SachDAO().FindByKey(ct.MaSach);
        //        sach.SoLuong -= ct.SoLuongMuon;
        //        new SachDAO().Update(sach);
        //    }
            return this.dao.Insert(model);

        }
        public virtual List<PhieuMuon> GetPhieuMuonChuaTra()
        {
            return ((PhieuMuonDAO)dao).GetPhieuMuonChuaTra();
        }
    }

}
