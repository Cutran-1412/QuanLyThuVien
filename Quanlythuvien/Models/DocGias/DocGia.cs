using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.PhieuTras;

namespace Quanlythuvien.Models
{
    internal class DocGia
    {
        [Key]
        [Required(ErrorMessage = "Mã độc giả không được để trống")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Mã độc giả phải từ 3 đến 10 ký tự.")]
        public string MaDocGia { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(50, ErrorMessage = "Họ tên tối đa 50 ký tự.")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string SoDienThoai { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Địa chỉ tối đa 100 ký tự.")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Ngày đăng ký không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NgayDangKy { get; set; }

        [Range(0, 10, ErrorMessage = "Số sách mượn tối đa từ 0 đến 10 cuốn")]
        public int SoSachMuonToiDa { get; set; } = 5;

        [Required(ErrorMessage = "Tiền đăng ký không được để trống")]
        [Range(10000, 1000000, ErrorMessage = "Tiền đăng ký phải từ 10.000đ đến 1.000.000đ")]
        public decimal TienDangKy { get; set; }

        // Hàm kiểm tra tuổi hợp lệ
        public bool KiemTraTuoiHopLe()
        {
            int tuoi = DateTime.Today.Year - NgaySinh.Year;
            if (NgaySinh > DateTime.Today.AddYears(-tuoi)) tuoi--;
            return tuoi >= 6 && tuoi <= 100;
        }
        public virtual ICollection<PhieuMuon>? PhieuMuon { get; set; }

    }
}
