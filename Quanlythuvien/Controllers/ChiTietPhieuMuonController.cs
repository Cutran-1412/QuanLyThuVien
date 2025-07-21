using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
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
        public bool TraSach(string maPhieuMuon, string maSach)
        {
            var ctPhieuMuon = this.GetByKey(maPhieuMuon, maSach);
            var sach = new SachController().FindByKey(maSach);
            sach.SoLuong += ctPhieuMuon.SoLuongMuon;
            new SachController().Update(sach);
           return ((ChiTietPhieuMuonDAO)dao).TraSach(maPhieuMuon,maSach);
        }
        public ChiTietPhieuMuon GetByKey(string maPhieuMuon,string maSach)
        {
            return ((ChiTietPhieuMuonDAO)dao).GetByKey(maPhieuMuon, maSach);
        }
        public override bool Insert(ChiTietPhieuMuon model)
        {
            SachController ctrl = new SachController();
            Sach sach = ctrl.FindByKey(model.MaSach);
            sach.SoLuong -= model.SoLuongMuon;
            if (sach.SoLuong < 0)
            {
                return false;
            }
            else
            {
                ctrl.Update(sach);
                return base.Insert(model);

            }

        }
        public int GetTongSoLuongDaMuon(string maDocGia)
        {
           return ((ChiTietPhieuMuonDAO)this.dao).GetSoLuongDaMuon(maDocGia);
        }
    }
}
