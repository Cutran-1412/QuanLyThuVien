using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;

namespace Quanlythuvien.Models.PhieuTras
{
    internal class PhieuTraDAO
    {
        private readonly DataContext kn = new DataContext();

        public List<PhieuTra> Get_PhieuTra()
        {
            return kn.PhieuTras.ToList();
        }
        public void Insert_PhieuTra(PhieuTra pt)
        {
            kn.PhieuTras!.Add(pt);
            kn.SaveChanges();
        }

        public void Update_PhieuTra(PhieuTra pt)
        {
            var tra = kn.PhieuTras.Find(pt.PhieuTraId);
            if (tra != null)
            {
                tra.MaPhieuTra = pt.MaPhieuTra;
                tra.MaDocGia = pt.MaDocGia;
                tra.QuyenSachId = pt.QuyenSachId;
                tra.NgayTra = pt.NgayTra;
                tra.TienPhat = pt.TienPhat;
                tra.TinhTrangSauTra = pt.TinhTrangSauTra;
                tra.GhiChu = pt.GhiChu;
                kn.SaveChanges();
            }
        }

        public void Delete_PhieuTra(int id)
        {
            var tra = kn.PhieuTras.Find(id);
            if (tra != null)
            {
                kn.PhieuTras.Remove(tra);
                kn.SaveChanges();
            }
        }
    }
}
