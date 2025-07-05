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
        public List<DocGia> Get_All()
        {
            return kn.DocGias.Select(s => s).ToList();
        }
        public DocGia? Check(string ma)
        {
            return kn.DocGias.Find(ma);
        }
        public void Insert(DocGia dg)
        {
            kn.DocGias!.Add(dg);
            kn.SaveChanges();
        }
        public void Update_DocGia(DocGia dg)
        {
            //var docgia = kn.DocGias.Find(dg.MaDocGia);
            //if (docgia != null)
            //{   
            //    docgia.HoTen = dg.HoTen;
            //    docgia.GioiTinh = dg.GioiTinh;
            //    docgia.NgaySinh = dg.NgaySinh;
            //    docgia.SoDienThoai = dg.SoDienThoai;
            //    docgia.Email = dg.Email;
            //    docgia.DiaChi = dg.DiaChi;
            //    docgia.NgayDangKy = dg.NgayDangKy;
            //    kn.SaveChanges();
            //}
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
