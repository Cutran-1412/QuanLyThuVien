using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.DocGias
{
    internal class DocGiaDAO
    {
        private readonly DataContext kn = new DataContext();
        public List<DocGia> Get_DocGia()
        {
            return kn.DocGias.Select(s=>s).ToList();
        }
        public void Insert_DocGia(DocGia dg)
        {
            kn.DocGias!.Add(dg);
            kn.SaveChanges();
        }
        public void Update_DocGia(DocGia dg)
        {
            var docgia = kn.DocGias.Find(dg.MaDocGia);
            if (docgia != null)
            {   
                docgia.HoTen = dg.HoTen;
                docgia.GioiTinh = dg.GioiTinh;
                docgia.NgaySinh = dg.NgaySinh;
                docgia.SoDienThoai = dg.SoDienThoai;
                docgia.Email = dg.Email;
                docgia.DiaChi = dg.DiaChi;
                docgia.NgayDangKy = dg.NgayDangKy;
                docgia.SoSachMuonToiDa = dg.SoSachMuonToiDa;
                docgia.TienDangKy = dg.TienDangKy;
                kn.SaveChanges();
            }
        }
        public void Delete_DocGia(String ma)
        {
            var dg = kn.DocGias.Find(ma);
            if (dg != null)
            {
                kn.DocGias.Remove(dg);
                kn.SaveChanges();
            }
        }
    }
}
