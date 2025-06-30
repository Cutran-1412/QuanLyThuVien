using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Quanlythuvien.Models.Sachs;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models.PhieuMuons
{
    internal class PhieuMuon
    {
        [Key]
        [Required, StringLength(12, MinimumLength = 3)]
        public string MaPhieuMuon { get; set; }

        [Required(ErrorMessage = "Phải chọn quyển sách muốn mượn")]
        public int QuyenSachId { get; set; }

        [ForeignKey(nameof(QuyenSachId))]
        public QuyenSach? QuyenSach { get; set; }
        [Required]
        public string MaDocGia { get; set; }

        [ForeignKey(nameof(MaDocGia))]
        public DocGia? DocGia { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime NgayMuon { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime NgayTra { get; set; }

        [StringLength(40)]
        public string TrangThai { get; set; } = "Đang mượn";
    }
}
