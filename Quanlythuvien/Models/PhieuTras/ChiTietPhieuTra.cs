using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Mã phiếu trả")]
        public string MaPhieuTra { get; set; }
        public PhieuTra PhieuTra{ get; set; }
        
        // Sách
        [ForeignKey(nameof(Sach))]

        [DisplayName("Mã sách")]
        public string MaSach { get; set; }
        public Sach Sach { get; set; }
        [DisplayName("Tiền phạt")]
        public decimal TienPhat { get; set; }

    }
}
