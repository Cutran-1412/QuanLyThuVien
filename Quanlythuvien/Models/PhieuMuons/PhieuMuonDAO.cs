﻿using System;
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
            var muon = kn.PhieuMuons.Find(pm.MaPhieuMuon);
            if (muon != null)
            {
                muon.MaDocGia = pm.MaDocGia;
                muon.QuyenSachId = pm.QuyenSachId;
                muon.NgayMuon = pm.NgayMuon;
                muon.NgayTra = pm.NgayTra;
                muon.TrangThai = pm.TrangThai;
                kn.SaveChanges();
            }
        }

        public void Delete_PhieuMuon(string maphieumuon)
        {
            var muon = kn.PhieuMuons.Find(maphieumuon);
            if (muon != null)
            {
                kn.PhieuMuons.Remove(muon);
                kn.SaveChanges();
            }
        }
    }
}
