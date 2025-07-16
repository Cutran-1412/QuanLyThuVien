using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.DocGias;
using System.ComponentModel;

namespace Quanlythuvien.Models.DocGias
{
    public class DocGia
    {
        [Key]
        [Required]
        [DisplayName("Mã độc giả")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Mã độc giả phải từ 3 đến 10 ký tự.")]
        public string MaDocGia { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(50, ErrorMessage = "Họ tên tối đa 50 ký tự.")]
        [DisplayName("Họ tên")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống")]
        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        [DisplayName("Ngày sinh")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [DisplayName("Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Địa chỉ tối đa 100 ký tự.")]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Ngày đăng ký không được để trống")]
        [DataType(DataType.Date)]
        [DisplayName("Ngày đăng ký")]
        public DateTime NgayDangKy { get; set; }

        [Range(0, 10, ErrorMessage = "Số sách mượn tối đa từ 0 đến 10 cuốn")]
        [DisplayName("Số sách muon tối đa")]
        public int SoSachMuonToiDa { get; set; } = 10;

        public virtual ICollection<PhieuMuon>? PhieuMuon { get; set; }
    }
}
