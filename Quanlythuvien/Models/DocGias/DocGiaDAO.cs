using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Views.ucFrom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quanlythuvien.Models.DocGias
{
    public class DocGiaDAO
    {
        private readonly DataContext kn = new DataContext();
        public List<DocGia> Get_DocGia()
        {
            return kn.DocGias.ToList();
        }
        public DocGia? Check(string ma)
        {
            return kn.DocGias.Find(ma);
        }
        public void Insert(DocGia docgia) 
        {
            kn.DocGias.Add(docgia);
            kn.SaveChanges();
        }
        public void Update(DocGia docgia)
        {
            var dg = kn.DocGias.Find(docgia.MaDocGia);
            if (dg != null) 
            {
                dg.HoTen = docgia.HoTen;
                dg.GioiTinh = docgia.GioiTinh;
                dg.NgaySinh = docgia.NgaySinh;
                dg.SoDienThoai = docgia.SoDienThoai;
                dg.Email = docgia.Email;
                dg.DiaChi = docgia.DiaChi;
                dg.NgayDangKy = docgia.NgayDangKy;
                dg.TienPhat = docgia.TienPhat;
                kn.SaveChanges();
            }
        }
    }
}