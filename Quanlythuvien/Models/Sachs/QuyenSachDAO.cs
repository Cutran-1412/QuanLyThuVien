using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Sachs
{
    internal class QuyenSachDAO
    {
        private readonly DataContext kn = new DataContext();

        public List<QuyenSach> Get_QuyenSach()
        {
            return kn.QuyenSachs.ToList();
        }

        public void Insert_QuyenSach(QuyenSach quyenSach)
        {
            kn.QuyenSachs!.Add(quyenSach);
            kn.SaveChanges();
        }

        public void Update_QuyenSach(QuyenSach quyenSach)
        {
            var qs = kn.QuyenSachs.Find(quyenSach.QuyenSachId);
            if (qs != null)
            {
                qs.MaSach = quyenSach.MaSach;
                qs.TinhTrang = quyenSach.TinhTrang;
                qs.ViTriKe = quyenSach.ViTriKe;
                qs.NgayNhap = quyenSach.NgayNhap;
                qs.CoSan = quyenSach.CoSan;
                kn.SaveChanges();
            }
        }

        public void Delete_QuyenSach(int quyenSachId)
        {
            var qs = kn.QuyenSachs.Find(quyenSachId);
            if (qs != null)
            {
                kn.QuyenSachs.Remove(qs);
                kn.SaveChanges();
            }
        }
    }
}
