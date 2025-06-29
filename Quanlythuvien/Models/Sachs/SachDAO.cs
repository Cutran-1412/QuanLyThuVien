using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;

namespace Quanlythuvien.Models.Sachs
{
    internal class SachDAO
    {
        private readonly DataContext kn = new DataContext();
        public List<Sach> Get_Sach()
        {
            return kn.Sachs.ToList();
        }
        public void Insert_Sach(Sach sach)
        {
            kn.Sachs!.Add(sach);
            kn.SaveChanges();
        }
        public void Update_Sach(Sach sach)
        {
            var S = kn.Sachs.Find(sach.MaSach);
            if (S != null)
            {
                S.TenSach = sach.TenSach;
                S.TenTacGia = sach.TenTacGia;
                S.TheLoai = sach.TheLoai;
                S.DonGia = sach.DonGia;
                S.NgayNhap = sach.NgayNhap;
                S.NamPhatHanh = sach.NamPhatHanh;
                S.NhaXuatBan = sach.NhaXuatBan;
                S.SoLuong = sach.SoLuong;
                kn.SaveChanges();
            }
        }
        public void Delete_Sach(String ma)
        {
            var sach = kn.Sachs.Find(ma);
            if (sach != null)
            {
                kn.Sachs.Remove(sach);
                kn.SaveChanges();
            }
        }
    }
}
