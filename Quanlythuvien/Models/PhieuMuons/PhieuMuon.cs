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
    public class PhieuMuon : Model    
    {
        [Key]
        [Required, StringLength(12, MinimumLength = 3)]
        public string MaPhieuMuon { get; set; }

        [Required(ErrorMessage = "Phải chọn quyển sách muốn mượn")]
        [ForeignKey(nameof(DocGia))]
        public string MaDocGia { get; set; }
        public DocGia? DocGia { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime NgayMuon { get; set; }
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();
        public List<PhieuTra>? PhieuTras { get; set; }
        public DateTime? NgayPhaiTra { get; set; }
    }
}
