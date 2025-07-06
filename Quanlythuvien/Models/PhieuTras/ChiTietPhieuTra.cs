using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.PhieuTras
{
    public class ChiTietPhieuTra
    {
        public string Id { get; set; }
        [ForeignKey(nameof(PhieuMuon))]
        public string MaPhieuTra { get; set; }
        public PhieuTra PhieuTra{ get; set; }
        [ForeignKey(nameof(Sach))]
        public string MaSach { get; set; }
        public Sach Sach { get; set; }
        
        public DateTime? NgayTra { get; set; }

    }
}
