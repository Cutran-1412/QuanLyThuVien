using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Sachs
{
    internal class QuyenSach
    {
        [Key]
        public int QuyenSachId { get; set; }

        [Required]
        public string MaSach { get; set; }

        [ForeignKey(nameof(MaSach))]
        public Sach? Sach { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }


        [StringLength(15)]
        public string ViTriKe { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayNhap { get; set; }

        public bool CoSan { get; set; } = true;
    }
}
