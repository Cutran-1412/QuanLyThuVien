using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quanlythuvien.Models.Sachs
{
<<<<<<< HEAD
    public class Sach
=======
    public class Sach : Model
>>>>>>> d7b609e91d416c009426a33e96e3610c3d612981
    {
        [Key]
        [Required(ErrorMessage = "Mã sách không được để trống")]
        [StringLength(10, MinimumLength = 3)]
        [DisplayName("Mã sách")]
        public string MaSach { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [StringLength(100)]
        [DisplayName("Tên sách")]
        public string TenSach { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [StringLength(60)]
        [DisplayName("Tên tác giả")]
        public string TenTacGia { get; set; }

        [StringLength(40)]
        [DisplayName("Thể loại")]
        public string TheLoai { get; set; }

        [Required]
        [Range(0, 5_000_000, ErrorMessage = "Đơn giá tối đa 5 triệu")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Đơn giá")]
        public decimal DonGia { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Ngày nhập")]
        public DateTime NgayNhap { get; set; }

        [Range(1900, 2100)]
        [DisplayName("Năm phát hành")]
        public int NamPhatHanh { get; set; }

        [StringLength(80)]
        [DisplayName("Năm xuất bản sách")]
        public string NhaXuatBan { get; set; }
        [DisplayName("Số lượng")]

        [Range(0, 1000, ErrorMessage = "Số lượng phải >= 0")]
        public int SoLuong { get; set; }
    }
}
