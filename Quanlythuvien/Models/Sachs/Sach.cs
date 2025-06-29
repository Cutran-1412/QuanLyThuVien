using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Sachs
{
    internal class Sach
    {
        [Key]
        [Required(ErrorMessage = "Mã sách không được để trống")]
        [StringLength(10, MinimumLength = 3)]
        public string MaSach { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [StringLength(100)]
        public string TenSach { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [StringLength(60)]
        public string TenTacGia { get; set; }

        [StringLength(40)]
        public string TheLoai { get; set; }

        [Required]
        [Range(0, 5_000_000, ErrorMessage = "Đơn giá tối đa 5 triệu")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DonGia { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayNhap { get; set; }

        [Range(1900, 2100)]
        public int NamPhatHanh { get; set; }

        [StringLength(80)]
        public string NhaXuatBan { get; set; }

        [Range(0, 1000, ErrorMessage = "Số lượng phải >= 0")]
        public int SoLuong { get; set; }

        public ICollection<QuyenSach>? QuyenSachs { get; set; }
    }
}
