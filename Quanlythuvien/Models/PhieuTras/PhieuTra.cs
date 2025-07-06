using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.Sachs;

namespace Quanlythuvien.Models.PhieuTras
{

    public class PhieuTra :Model
    {
        [Key]
        [Required, StringLength(12, MinimumLength = 3)]
        public string MaPhieuTra { get; set; }

        [ForeignKey(nameof(PhieuMuon))]
        public string MaPhieuMuon { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }

        [Range(0, double.MaxValue)] 
        public decimal TienPhat { get; set; }
        public List<ChiTietPhieuTra> ChiTietPhieuTras { get; set; } = new List<ChiTietPhieuTra>();

    }
}
