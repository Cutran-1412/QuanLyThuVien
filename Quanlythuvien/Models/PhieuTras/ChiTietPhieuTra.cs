using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.PhieuTras
{
    public class ChiTietPhieuTra
    {
        // Phiếu trả 
        [ForeignKey(nameof(PhieuTra))]
        public string MaPhieuTra { get; set; }
        public PhieuTra PhieuTra{ get; set; }
        
        // Sách
        [ForeignKey(nameof(Sach))]
        public string MaSach { get; set; }
        public Sach Sach { get; set; }
        public int SoLuong { get; set; }

    }
}
