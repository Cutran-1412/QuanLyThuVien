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
    internal class PhieuTra
    {
        [Key, ForeignKey(nameof(PhieuMuon))]
        public int PhieuTraId { get; set; }

        [Required, StringLength(12, MinimumLength = 3)]
        public string MaPhieuTra { get; set; }

        public PhieuMuon? PhieuMuon { get; set; }

        [Required]
        public string MaDocGia { get; set; }

        [ForeignKey(nameof(MaDocGia))]
        public DocGia? DocGia { get; set; }

        [Required] public int QuyenSachId { get; set; }
        public QuyenSach? QuyenSach { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }

        [Range(0, 1_000_000)] public decimal TienPhat { get; set; }

        [Required, StringLength(30)]
        public string TinhTrangSauTra { get; set; }

        [StringLength(200)] public string GhiChu { get; set; }

    }
}
