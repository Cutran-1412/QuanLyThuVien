using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models.PhieuMuons
{
    internal class PhieuMuonDAO
    {
        private readonly DataContext kn = new DataContext();

        public List<PhieuMuon> Get_PhieuMuon() => kn.PhieuMuons.ToList();

        public void Insert_PhieuMuon(PhieuMuon pm)
        {
            kn.PhieuMuons!.Add(pm);
            kn.SaveChanges();
        }

        public void Update_PhieuMuon(PhieuMuon pm)
        {
            var muon = kn.PhieuMuons.Find(pm.PhieuMuonId);
            if (muon != null)
            {
                muon.MaPhieuMuon = pm.MaPhieuMuon;
                muon.MaDocGia = pm.MaDocGia;
                muon.QuyenSachId = pm.QuyenSachId;
                muon.NgayMuon = pm.NgayMuon;
                muon.NgayTra = pm.NgayTra;
                muon.TrangThai = pm.TrangThai;
                kn.SaveChanges();
            }
        }

        public void Delete_PhieuMuon(int id)
        {
            var muon = kn.PhieuMuons.Find(id);
            if (muon != null)
            {
                kn.PhieuMuons.Remove(muon);
                kn.SaveChanges();
            }
        }
    }
}
