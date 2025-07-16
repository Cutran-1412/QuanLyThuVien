using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;
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
                kn.SaveChanges();
            }
        }
        public List<DocGia> Search(string luachon,string keyword)
        {
            switch (luachon)
            {
                case "Mã độc giả":
                    return kn.DocGias.Where(a => a.MaDocGia.ToLower().Contains(keyword)).ToList();
                case "Họ tên":
                    return kn.DocGias.Where(a => a.HoTen.ToLower().Contains(keyword)).ToList();
                case "Số điện thoại":
                    return kn.DocGias.Where(a => a.SoDienThoai.ToLower().Contains(keyword)).ToList();
                case "Email":
                    return kn.DocGias.Where(a => a.Email.ToLower().Contains(keyword)).ToList();
                case "Địa chỉ":
                    return kn.DocGias.Where(a => a.DiaChi.ToLower().Contains(keyword)).ToList();
                case "Giới tính":
                    return kn.DocGias.Where(a => a.GioiTinh.ToLower().Contains(keyword)).ToList();
            }
            return null;
        }
        public void Delete(string ma)
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