using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using Quanlythuvien.Models.Admins;
using Quanlythuvien.Models.Sachs;
using Quanlythuvien.Models.PhieuTras;
using Quanlythuvien.Models.PhieuMuons;
using Quanlythuvien.Models.DocGias;
using System.Reflection.Emit;

namespace Quanlythuvien.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<PhieuTra> PhieuTras { get; set; }
        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }
        public DbSet<ChiTietPhieuTra> ChiTietPhieuTras { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            String sqlcu = "Data Source=ADMIN-PC\\SQLEXPRESS;Initial Catalog=Quanlythuvien;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            String sqlCuong = "";
            String sqlChien = "Data Source=MSI\\SQLSERVER;Initial Catalog=qlthuvien;Integrated Security=True";
            optionsBuilder.UseSqlServer(sqlChien);
        }
        private void Seed_Admin(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(
                new Admin { Id = 1,Username = "Admin1",Password = "2004"},
                new Admin { Id = 2, Username = "Admin2", Password = "2004" },
                new Admin { Id = 3, Username = "Admin3", Password = "2004" },
                new Admin { Id = 4, Username = "Admin4", Password = "2004" },
                new Admin { Id = 5, Username = "Admin5", Password = "2004" },
                new Admin { Id = 6, Username = "Admin6", Password = "2004" },
                new Admin { Id = 7, Username = "Admin7", Password = "2004" },
                new Admin { Id = 8, Username = "Admin8", Password = "2004" },
                new Admin { Id = 9, Username = "Admin9", Password = "2004" },
                new Admin { Id = 10, Username = "Admin10", Password = "2004" }
            );
        }
        public void Seed_DocGia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>().HasData(
              new DocGia
              {
                  MaDocGia = "DG001",
                  HoTen = "Nguyễn Văn Anh",
                  GioiTinh = "Nam",
                  NgaySinh = new DateTime(1995, 3, 15),
                  SoDienThoai = "0912345678",
                  Email = "nguyenvananh@gmail.com",
                  DiaChi = "123 Đường Láng, Đống Đa, Hà Nội",
                  NgayDangKy = new DateTime(2024, 1, 10),
                  SoSachMuonToiDa = 10
              },
            new DocGia
            {
                MaDocGia = "DG002",
                HoTen = "Trần Thị Bình",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1992, 8, 22),
                SoDienThoai = "0987654321",
                Email = "tranthibinh@yahoo.com",
                DiaChi = "456 Nguyễn Trãi, Thanh Xuân, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 12),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG003",
                HoTen = "Lê Minh Cường",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1988, 12, 5),
                SoDienThoai = "0901234567",
                Email = "leminhcuong@hotmail.com",
                DiaChi = "789 Cầu Giấy, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 15),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG004",
                HoTen = "Phạm Thị Dung",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1990, 6, 18),
                SoDienThoai = "0976543210",
                Email = "phamthidung@gmail.com",
                DiaChi = "321 Hoàng Quốc Việt, Bắc Từ Liêm, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 18),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG005",
                HoTen = "Hoàng Văn Em",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1993, 4, 30),
                SoDienThoai = "0965432109",
                Email = "hoangvanem@yahoo.com",
                DiaChi = "654 Kim Mã, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 20),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG006",
                HoTen = "Vũ Thị Giang",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1996, 11, 12),
                SoDienThoai = "0954321098",
                Email = "vuthigiang@gmail.com",
                DiaChi = "987 Giải Phóng, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 22),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG007",
                HoTen = "Đỗ Minh Hải",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1985, 9, 8),
                SoDienThoai = "0943210987",
                Email = "dominhhei@hotmail.com",
                DiaChi = "147 Xã Đàn, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 25),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG008",
                HoTen = "Bùi Thị Hoa",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1991, 2, 14),
                SoDienThoai = "0932109876",
                Email = "buithihoa@gmail.com",
                DiaChi = "258 Thái Hà, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 28),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG009",
                HoTen = "Ngô Văn Ích",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1994, 7, 25),
                SoDienThoai = "0921098765",
                Email = "ngovanych@yahoo.com",
                DiaChi = "369 Láng Hạ, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 1, 30),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG010",
                HoTen = "Đinh Thị Kim",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1987, 5, 3),
                SoDienThoai = "0910987654",
                Email = "dinhthikim@gmail.com",
                DiaChi = "741 Nguyễn Chí Thanh, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 1),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG011",
                HoTen = "Lý Minh Long",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1989, 10, 17),
                SoDienThoai = "0908765432",
                Email = "lyminhlong@hotmail.com",
                DiaChi = "852 Tô Hiệu, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 3),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG012",
                HoTen = "Trịnh Thị Mai",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1992, 1, 28),
                SoDienThoai = "0897654321",
                Email = "trinhthimai@gmail.com",
                DiaChi = "963 Phạm Hùng, Nam Từ Liêm, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 5),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG013",
                HoTen = "Cao Văn Nam",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1986, 8, 11),
                SoDienThoai = "0886543210",
                Email = "caovannam@yahoo.com",
                DiaChi = "159 Mễ Trì, Nam Từ Liêm, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 8),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG014",
                HoTen = "Phan Thị Oanh",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1995, 12, 7),
                SoDienThoai = "0875432109",
                Email = "phanthioanh@gmail.com",
                DiaChi = "357 Lê Văn Lương, Thanh Xuân, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 10),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG015",
                HoTen = "Dương Minh Phúc",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1988, 3, 20),
                SoDienThoai = "0864321098",
                Email = "duongminhphuc@hotmail.com",
                DiaChi = "468 Khuất Duy Tiến, Thanh Xuân, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 12),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG016",
                HoTen = "Lại Thị Quỳnh",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1993, 6, 15),
                SoDienThoai = "0853210987",
                Email = "laithiquynh@gmail.com",
                DiaChi = "579 Nguyễn Xiển, Thanh Xuân, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 15),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG017",
                HoTen = "Tạ Văn Rồng",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1990, 9, 2),
                SoDienThoai = "0842109876",
                Email = "tavanrong@yahoo.com",
                DiaChi = "681 Tân Triều, Thanh Trì, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 18),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG018",
                HoTen = "Vương Thị Sương",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1991, 4, 9),
                SoDienThoai = "0831098765",
                Email = "vuongthisuong@gmail.com",
                DiaChi = "792 Minh Khai, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 20),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG019",
                HoTen = "Hồ Minh Tuấn",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1987, 11, 24),
                SoDienThoai = "0820987654",
                Email = "hominhtuan@hotmail.com",
                DiaChi = "103 Bạch Mai, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 22),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG020",
                HoTen = "Kiều Thị Uyên",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1994, 7, 6),
                SoDienThoai = "0809876543",
                Email = "kieuthiuyen@gmail.com",
                DiaChi = "214 Trần Khát Chân, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 25),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG021",
                HoTen = "Mạc Văn Việt",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1985, 2, 19),
                SoDienThoai = "0798765432",
                Email = "macvanviet@yahoo.com",
                DiaChi = "325 Trương Định, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 2, 28),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG022",
                HoTen = "Ông Thị Xuân",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1992, 12, 31),
                SoDienThoai = "0787654321",
                Email = "ongthixuan@gmail.com",
                DiaChi = "436 Vĩnh Tuy, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 1),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG023",
                HoTen = "Quách Minh Yên",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1989, 5, 14),
                SoDienThoai = "0776543210",
                Email = "quachminhyen@hotmail.com",
                DiaChi = "547 Đại Cồ Việt, Hai Bà Trưng, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 3),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG024",
                HoTen = "Điều Thị Ánh",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1996, 8, 27),
                SoDienThoai = "0765432109",
                Email = "dieuthianh@gmail.com",
                DiaChi = "658 Lê Duẩn, Hoàn Kiếm, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 5),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG025",
                HoTen = "Phùng Văn Bảo",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1986, 1, 10),
                SoDienThoai = "0754321098",
                Email = "phungvanbao@yahoo.com",
                DiaChi = "769 Điện Biên Phủ, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 8),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG026",
                HoTen = "Từ Thị Cẩm",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1993, 10, 4),
                SoDienThoai = "0743210987",
                Email = "tuthicam@gmail.com",
                DiaChi = "871 Ngọc Khánh, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 10),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG027",
                HoTen = "Lương Minh Đức",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1988, 6, 21),
                SoDienThoai = "0732109876",
                Email = "luongminhduc@hotmail.com",
                DiaChi = "982 Đội Cấn, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 12),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG028",
                HoTen = "Mai Thị Én",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1991, 3, 16),
                SoDienThoai = "0721098765",
                Email = "maithien@gmail.com",
                DiaChi = "193 Liễu Giai, Ba Đình, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 15),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG029",
                HoTen = "Châu Văn Phong",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1995, 11, 29),
                SoDienThoai = "0710987654",
                Email = "chauvanphong@yahoo.com",
                DiaChi = "304 Cát Linh, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 18),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG030",
                HoTen = "Đặng Thị Giang",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1987, 4, 12),
                SoDienThoai = "0909876543",
                Email = "dangthigiang@gmail.com",
                DiaChi = "415 Thái Thịnh, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 20),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG031",
                HoTen = "Võ Minh Hiếu",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1990, 9, 7),
                SoDienThoai = "0698765432",
                Email = "vominhhieu@hotmail.com",
                DiaChi = "526 Tôn Đức Thắng, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 22),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG032",
                HoTen = "Huỳnh Thị Lan",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1994, 12, 23),
                SoDienThoai = "0687654321",
                Email = "huynhthilan@gmail.com",
                DiaChi = "637 Ô Chợ Dừa, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 25),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG033",
                HoTen = "Tôn Văn Minh",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1985, 7, 18),
                SoDienThoai = "0676543210",
                Email = "tonvanminh@yahoo.com",
                DiaChi = "748 Khương Thượng, Đống Đa, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 28),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG034",
                HoTen = "Lò Thị Nga",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1992, 2, 5),
                SoDienThoai = "0665432109",
                Email = "lothinga@gmail.com",
                DiaChi = "859 Trần Cung, Nam Từ Liêm, Hà Nội",
                NgayDangKy = new DateTime(2024, 3, 30),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG035",
                HoTen = "Thái Minh Ổn",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1989, 8, 13),
                SoDienThoai = "0654321098",
                Email = "thaiminhon@hotmail.com",
                DiaChi = "961 Xuân Thủy, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 1),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG036",
                HoTen = "Ứng Thị Phương",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1996, 5, 26),
                SoDienThoai = "0643210987",
                Email = "ungthiphuong@gmail.com",
                DiaChi = "172 Dương Quảng Hàm, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 3),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG037",
                HoTen = "Ấu Văn Quân",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1986, 12, 9),
                SoDienThoai = "0632109876",
                Email = "auvanquan@yahoo.com",
                DiaChi = "283 Nguyễn Khánh Toàn, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 5),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG038",
                HoTen = "Ôn Thị Rượu",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1993, 1, 22),
                SoDienThoai = "0621098765",
                Email = "onthiruou@gmail.com",
                DiaChi = "394 Trần Thái Tông, Cầu Giấy, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 8),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG039",
                HoTen = "Âu Minh Sơn",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1988, 10, 1),
                SoDienThoai = "0610987654",
                Email = "auminhson@hotmail.com",
                DiaChi = "505 Trịnh Công Sơn, Tây Hồ, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 10),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG040",
                HoTen = "Ê Thị Tuyết",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1991, 6, 14),
                SoDienThoai = "0609876543",
                Email = "ethituyet@gmail.com",
                DiaChi = "616 Âu Cơ, Tây Hồ, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 12),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG041",
                HoTen = "Y Văn Uyên",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1995, 3, 8),
                SoDienThoai = "0598765432",
                Email = "yvanuyen@yahoo.com",
                DiaChi = "727 Lạc Long Quân, Tây Hồ, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 15),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG042",
                HoTen = "Ỷ Thị Vân",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1987, 11, 17),
                SoDienThoai = "0587654321",
                Email = "ythivan@gmail.com",
                DiaChi = "838 Thụy Khuê, Tây Hồ, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 18),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG043",
                HoTen = "Ư Minh Xuân",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1990, 7, 30),
                SoDienThoai = "0576543210",
                Email = "uminhxuan@hotmail.com",
                DiaChi = "949 Nghi Tàm, Tây Hồ, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 20),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG044",
                HoTen = "Ươ Thị Yến",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1994, 4, 11),
                SoDienThoai = "0565432109",
                Email = "uothiyen@gmail.com",
                DiaChi = "150 Quang Trung, Hà Đông, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 22),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG045",
                HoTen = "Ả Văn Ánh",
                GioiTinh = "Nam",
                NgaySinh = new DateTime(1985, 9, 25),
                SoDienThoai = "0554321098",
                Email = "avananh@yahoo.com",
                DiaChi = "261 Lê Trọng Tấn, Hà Đông, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 25),
                SoSachMuonToiDa = 10
            },
            new DocGia
            {
                MaDocGia = "DG046",
                HoTen = "Ẻ Thị Bạch",
                GioiTinh = "Nữ",
                NgaySinh = new DateTime(1992, 12, 4),
                SoDienThoai = "0543210987",
                Email = "ethibach@gmail.com",
                DiaChi = "372 Tô Hiệu, Hà Đông, Hà Nội",
                NgayDangKy = new DateTime(2024, 4, 28),
                SoSachMuonToiDa = 10
            },
                new DocGia
                {
                    MaDocGia = "DG047",
                    HoTen = "Ỳ Minh Cảnh",
                    GioiTinh = "Nam",
                    NgaySinh = new DateTime(1989, 8, 19),
                    SoDienThoai = "0532109876",
                    Email = "yminhcanh@hotmail.com",
                    DiaChi = "483 Nguyễn Trãi, Hà Đông, Hà Nội",
                    NgayDangKy = new DateTime(2024, 5, 1),
                    SoSachMuonToiDa = 10
                },
                new DocGia
                {
                    MaDocGia = "DG048",
                    HoTen = "Ỹ Thị Diệu",
                    GioiTinh = "Nữ",
                    NgaySinh = new DateTime(1996, 2, 28),
                    SoDienThoai = "0521098765",
                    Email = "ythidieu@gmail.com",
                    DiaChi = "594 Văn Phú, Hà Đông, Hà Nội",
                    NgayDangKy = new DateTime(2024, 5, 3),
                    SoSachMuonToiDa = 10
                },
                new DocGia
                {
                    MaDocGia = "DG049",
                    HoTen = "Ỷ Văn Ê",
                    GioiTinh = "Nam",
                    NgaySinh = new DateTime(1986, 5, 13),
                    SoDienThoai = "0510987654",
                    Email = "yvane@yahoo.com",
                    DiaChi = "605 Kiến Hưng, Hà Đông, Hà Nội",
                    NgayDangKy = new DateTime(2024, 5, 5),
                    SoSachMuonToiDa = 10
                },
                new DocGia
                {
                    MaDocGia = "DG050",
                    HoTen = "Ỵ Thị Phượng",
                    GioiTinh = "Nữ",
                    NgaySinh = new DateTime(1993, 11, 6),
                    SoDienThoai = "0509876543",
                    Email = "ythiphuong@gmail.com",
                    DiaChi = "716 La Khê, Hà Đông, Hà Nội",
                    NgayDangKy = new DateTime(2024, 5, 8),
                    SoSachMuonToiDa = 10
                });
        }
        public void SeedSach(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sach>().HasData(
                new Sach
                {
                    MaSach = "S001",
                    TenSach = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                    TenTacGia = "Nguyễn Nhật Ánh",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 89000m,
                    NgayNhap = new DateTime(2024, 1, 15),
                    NamPhatHanh = 2010,
                    NhaXuatBan = "NXB Trẻ",
                    SoLuong = 25
                },
                new Sach
                {
                    MaSach = "S002",
                    TenSach = "Số Đỏ",
                    TenTacGia = "Vũ Trọng Phụng",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 95000m,
                    NgayNhap = new DateTime(2024, 1, 16),
                    NamPhatHanh = 2015,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 30
                },
                new Sach
                {
                    MaSach = "S003",
                    TenSach = "Dế Mèn Phiêu Lưu Ký",
                    TenTacGia = "Tô Hoài",
                    TheLoai = "Thiếu nhi",
                    DonGia = 65000m,
                    NgayNhap = new DateTime(2024, 1, 17),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Kim Đồng",
                    SoLuong = 40
                },
                new Sach
                {
                    MaSach = "S004",
                    TenSach = "Truyện Kiều",
                    TenTacGia = "Nguyễn Du",
                    TheLoai = "Thơ ca",
                    DonGia = 120000m,
                    NgayNhap = new DateTime(2024, 1, 18),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 15
                },
                new Sach
                {
                    MaSach = "S005",
                    TenSach = "Chí Phèo",
                    TenTacGia = "Nam Cao",
                    TheLoai = "Truyện ngắn",
                    DonGia = 75000m,
                    NgayNhap = new DateTime(2024, 1, 19),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 35
                },
                new Sach
                {
                    MaSach = "S006",
                    TenSach = "Những Ngày Thơ Ấu",
                    TenTacGia = "Nguyễn Tuân",
                    TheLoai = "Hồi ký",
                    DonGia = 82000m,
                    NgayNhap = new DateTime(2024, 1, 20),
                    NamPhatHanh = 2017,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 20
                },
                new Sach
                {
                    MaSach = "S007",
                    TenSach = "Lão Hạc",
                    TenTacGia = "Nam Cao",
                    TheLoai = "Truyện ngắn",
                    DonGia = 68000m,
                    NgayNhap = new DateTime(2024, 1, 21),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Giáo Dục",
                    SoLuong = 45
                },
                new Sach
                {
                    MaSach = "S008",
                    TenSach = "Tắt Đèn",
                    TenTacGia = "Ngô Tất Tố",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 92000m,
                    NgayNhap = new DateTime(2024, 1, 22),
                    NamPhatHanh = 2016,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 28
                },
                new Sach
                {
                    MaSach = "S009",
                    TenSach = "Vợ Nhặt",
                    TenTacGia = "Kim Lân",
                    TheLoai = "Truyện ngắn",
                    DonGia = 58000m,
                    NgayNhap = new DateTime(2024, 1, 23),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 50
                },
                new Sach
                {
                    MaSach = "S010",
                    TenSach = "Những Người Khốn Khổ",
                    TenTacGia = "Victor Hugo",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 180000m,
                    NgayNhap = new DateTime(2024, 1, 24),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Hội Nhà Văn",
                    SoLuong = 12
                },
                new Sach
                {
                    MaSach = "S011",
                    TenSach = "Đắc Nhân Tâm",
                    TenTacGia = "Dale Carnegie",
                    TheLoai = "Kỹ năng sống",
                    DonGia = 125000m,
                    NgayNhap = new DateTime(2024, 1, 25),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Tổng Hợp TP.HCM",
                    SoLuong = 60
                },
                new Sach
                {
                    MaSach = "S012",
                    TenSach = "Sherlock Holmes",
                    TenTacGia = "Arthur Conan Doyle",
                    TheLoai = "Trinh thám",
                    DonGia = 145000m,
                    NgayNhap = new DateTime(2024, 1, 26),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 32
                },
                new Sach
                {
                    MaSach = "S013",
                    TenSach = "Nhà Giả Kim",
                    TenTacGia = "Paulo Coelho",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 98000m,
                    NgayNhap = new DateTime(2024, 1, 27),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Hội Nhà Văn",
                    SoLuong = 38
                },
                new Sach
                {
                    MaSach = "S014",
                    TenSach = "Hạt Giống Tâm Hồn",
                    TenTacGia = "Jack Canfield",
                    TheLoai = "Tâm lý",
                    DonGia = 115000m,
                    NgayNhap = new DateTime(2024, 1, 28),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Lao Động",
                    SoLuong = 42
                },
                new Sach
                {
                    MaSach = "S015",
                    TenSach = "Cuốn Theo Chiều Gió",
                    TenTacGia = "Margaret Mitchell",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 165000m,
                    NgayNhap = new DateTime(2024, 1, 29),
                    NamPhatHanh = 2017,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 18
                },
                new Sach
                {
                    MaSach = "S016",
                    TenSach = "Mắt Biếc",
                    TenTacGia = "Nguyễn Nhật Ánh",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 78000m,
                    NgayNhap = new DateTime(2024, 1, 30),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Trẻ",
                    SoLuong = 55
                },
                new Sach
                {
                    MaSach = "S017",
                    TenSach = "Cây Cam Ngọt Của Tôi",
                    TenTacGia = "José Mauro de Vasconcelos",
                    TheLoai = "Thiếu nhi",
                    DonGia = 88000m,
                    NgayNhap = new DateTime(2024, 1, 31),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Hội Nhà Văn",
                    SoLuong = 35
                },
                new Sach
                {
                    MaSach = "S018",
                    TenSach = "Tuổi Thơ Dữ Dội",
                    TenTacGia = "Phùng Quán",
                    TheLoai = "Hồi ký",
                    DonGia = 92000m,
                    NgayNhap = new DateTime(2024, 2, 1),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 28
                },
                new Sach
                {
                    MaSach = "S019",
                    TenSach = "Doraemon Tập 1",
                    TenTacGia = "Fujiko F. Fujio",
                    TheLoai = "Truyện tranh",
                    DonGia = 25000m,
                    NgayNhap = new DateTime(2024, 2, 2),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Kim Đồng",
                    SoLuong = 80
                },
                new Sach
                {
                    MaSach = "S020",
                    TenSach = "Harry Potter Và Hòn Đá Phù Thủy",
                    TenTacGia = "J.K. Rowling",
                    TheLoai = "Fantasy",
                    DonGia = 155000m,
                    NgayNhap = new DateTime(2024, 2, 3),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Trẻ",
                    SoLuong = 45
                },
                new Sach
                {
                    MaSach = "S021",
                    TenSach = "Chiến Tranh Và Hòa Bình",
                    TenTacGia = "Leo Tolstoy",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 220000m,
                    NgayNhap = new DateTime(2024, 2, 4),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 8
                },
                new Sach
                {
                    MaSach = "S022",
                    TenSach = "Thép Đã Tôi Thế Đấy",
                    TenTacGia = "Nikolai Ostrovsky",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 135000m,
                    NgayNhap = new DateTime(2024, 2, 5),
                    NamPhatHanh = 2017,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 22
                },
                new Sach
                {
                    MaSach = "S023",
                    TenSach = "Tôi Là Bêtô",
                    TenTacGia = "Nguyễn Tuân",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 85000m,
                    NgayNhap = new DateTime(2024, 2, 6),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 30
                },
                new Sach
                {
                    MaSach = "S024",
                    TenSach = "Sapiens: Lược Sử Loài Người",
                    TenTacGia = "Yuval Noah Harari",
                    TheLoai = "Khoa học",
                    DonGia = 195000m,
                    NgayNhap = new DateTime(2024, 2, 7),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Thế Giới",
                    SoLuong = 25
                },
                new Sach
                {
                    MaSach = "S025",
                    TenSach = "Cho Tôi Xin Một Vé Đi Tuổi Thơ",
                    TenTacGia = "Nguyễn Nhật Ánh",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 72000m,
                    NgayNhap = new DateTime(2024, 2, 8),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Trẻ",
                    SoLuong = 48
                },
                new Sach
                {
                    MaSach = "S026",
                    TenSach = "Tuyển Tập Truyện Ngắn Hay",
                    TenTacGia = "Nhiều tác giả",
                    TheLoai = "Truyện ngắn",
                    DonGia = 105000m,
                    NgayNhap = new DateTime(2024, 2, 9),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 33
                },
                new Sach
                {
                    MaSach = "S027",
                    TenSach = "Đời Thừa",
                    TenTacGia = "Nam Cao",
                    TheLoai = "Tiểu thuyết",
                    DonGia = 78000m,
                    NgayNhap = new DateTime(2024, 2, 10),
                    NamPhatHanh = 2018,
                    NhaXuatBan = "NXB Văn Học",
                    SoLuong = 26
                },
                new Sach
                {
                    MaSach = "S028",
                    TenSach = "Conan Tập 50",
                    TenTacGia = "Gosho Aoyama",
                    TheLoai = "Truyện tranh",
                    DonGia = 35000m,
                    NgayNhap = new DateTime(2024, 2, 11),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Kim Đồng",
                    SoLuong = 65
                },
                new Sach
                {
                    MaSach = "S029",
                    TenSach = "One Piece Tập 100",
                    TenTacGia = "Eiichiro Oda",
                    TheLoai = "Truyện tranh",
                    DonGia = 38000m,
                    NgayNhap = new DateTime(2024, 2, 12),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Kim Đồng",
                    SoLuong = 70
                },
                new Sach
                {
                    MaSach = "S030",
                    TenSach = "Dragon Ball Tập 42",
                    TenTacGia = "Akira Toriyama",
                    TheLoai = "Truyện tranh",
                    DonGia = 32000m,
                    NgayNhap = new DateTime(2024, 2, 13),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Kim Đồng",
                    SoLuong = 55
                },
                new Sach
                {
                    MaSach = "S031",
                    TenSach = "Luyện Thi THPT Quốc Gia Toán",
                    TenTacGia = "Đỗ Đức Thái",
                    TheLoai = "Giáo khoa",
                    DonGia = 185000m,
                    NgayNhap = new DateTime(2024, 2, 14),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Giáo Dục",
                    SoLuong = 40
                },
                new Sach
                {
                    MaSach = "S032",
                    TenSach = "Luyện Thi THPT Quốc Gia Văn",
                    TenTacGia = "Lê Anh Xuân",
                    TheLoai = "Giáo khoa",
                    DonGia = 175000m,
                    NgayNhap = new DateTime(2024, 2, 15),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Giáo Dục",
                    SoLuong = 35
                },
                new Sach
                {
                    MaSach = "S033",
                    TenSach = "Từ Điển Tiếng Việt",
                    TenTacGia = "Hoàng Phê",
                    TheLoai = "Từ điển",
                    DonGia = 250000m,
                    NgayNhap = new DateTime(2024, 2, 16),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Đà Nẵng",
                    SoLuong = 15
                },
                new Sach
                {
                    MaSach = "S034",
                    TenSach = "English Grammar In Use",
                    TenTacGia = "Raymond Murphy",
                    TheLoai = "Ngoại ngữ",
                    DonGia = 320000m,
                    NgayNhap = new DateTime(2024, 2, 17),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Đại Học Quốc Gia",
                    SoLuong = 28
                },
                new Sach
                {
                    MaSach = "S035",
                    TenSach = "Tiếng Anh Giao Tiếp Hàng Ngày",
                    TenTacGia = "Phạm Thị Hồng",
                    TheLoai = "Ngoại ngữ",
                    DonGia = 145000m,
                    NgayNhap = new DateTime(2024, 2, 18),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Thông Tin Truyền Thông",
                    SoLuong = 50
                },
                new Sach
                {
                    MaSach = "S036",
                    TenSach = "Lịch Sử Việt Nam",
                    TenTacGia = "Trần Quốc Vượng",
                    TheLoai = "Lịch sử",
                    DonGia = 165000m,
                    NgayNhap = new DateTime(2024, 2, 19),
                    NamPhatHanh = 2019,
                    NhaXuatBan = "NXB Khoa Học Xã Hội",
                    SoLuong = 22
                },
                new Sach
                {
                    MaSach = "S037",
                    TenSach = "Địa Lý Việt Nam",
                    TenTacGia = "Nguyễn Văn Thành",
                    TheLoai = "Địa lý",
                    DonGia = 125000m,
                    NgayNhap = new DateTime(2024, 2, 20),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Giáo Dục",
                    SoLuong = 30
                },
                new Sach
                {
                    MaSach = "S038",
                    TenSach = "Sinh Học Đại Cương",
                    TenTacGia = "Phạm Minh Thành",
                    TheLoai = "Khoa học",
                    DonGia = 195000m,
                    NgayNhap = new DateTime(2024, 2, 21),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Khoa Học Kỹ Thuật",
                    SoLuong = 18
                },
                new Sach
                {
                    MaSach = "S039",
                    TenSach = "Vật Lý Đại Cương",
                    TenTacGia = "Lê Văn Minh",
                    TheLoai = "Khoa học",
                    DonGia = 215000m,
                    NgayNhap = new DateTime(2024, 2, 22),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Khoa Học Kỹ Thuật",
                    SoLuong = 20
                },
                new Sach
                {
                    MaSach = "S040",
                    TenSach = "Hóa Học Hữu Cơ",
                    TenTacGia = "Nguyễn Thị Lan",
                    TheLoai = "Khoa học",
                    DonGia = 185000m,
                    NgayNhap = new DateTime(2024, 2, 23),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Khoa Học Kỹ Thuật",
                    SoLuong = 25
                },
                new Sach
                {
                    MaSach = "S041",
                    TenSach = "Lập Trình C++ Căn Bản",
                    TenTacGia = "Phạm Văn Ất",
                    TheLoai = "Công nghệ",
                    DonGia = 165000m,
                    NgayNhap = new DateTime(2024, 2, 24),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Thông Tin Truyền Thông",
                    SoLuong = 32
                },
                new Sach
                {
                    MaSach = "S042",
                    TenSach = "Java Từ Cơ Bản Đến Nâng Cao",
                    TenTacGia = "Lê Thanh Hải",
                    TheLoai = "Công nghệ",
                    DonGia = 195000m,
                    NgayNhap = new DateTime(2024, 2, 25),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Bách Khoa Hà Nội",
                    SoLuong = 28
                },
                new Sach
                {
                    MaSach = "S043",
                    TenSach = "Python Programming",
                    TenTacGia = "Nguyễn Minh Đức",
                    TheLoai = "Công nghệ",
                    DonGia = 175000m,
                    NgayNhap = new DateTime(2024, 2, 26),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Thông Tin Truyền Thông",
                    SoLuong = 35
                },
                new Sach
                {
                    MaSach = "S044",
                    TenSach = "Cấu Trúc Dữ Liệu Và Giải Thuật",
                    TenTacGia = "Trần Đan Thư",
                    TheLoai = "Công nghệ",
                    DonGia = 225000m,
                    NgayNhap = new DateTime(2024, 2, 27),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Bách Khoa Hà Nội",
                    SoLuong = 24
                },
                new Sach
                {
                    MaSach = "S045",
                    TenSach = "Mạng Máy Tính",
                    TenTacGia = "Võ Thanh Tùng",
                    TheLoai = "Công nghệ",
                    DonGia = 185000m,
                    NgayNhap = new DateTime(2024, 2, 28),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Thông Tin Truyền Thông",
                    SoLuong = 22
                },
                new Sach
                {
                    MaSach = "S046",
                    TenSach = "Cơ Sở Dữ Liệu",
                    TenTacGia = "Phạm Thế Bảo",
                    TheLoai = "Công nghệ",
                    DonGia = 205000m,
                    NgayNhap = new DateTime(2024, 3, 1),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Bách Khoa Hà Nội",
                    SoLuong = 18
                },
                new Sach
                {
                    MaSach = "S047",
                    TenSach = "Kinh Tế Học Vi Mô",
                    TenTacGia = "Nguyễn Văn Công",
                    TheLoai = "Kinh tế",
                    DonGia = 155000m,
                    NgayNhap = new DateTime(2024, 3, 2),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Kinh Tế Quốc Dân",
                    SoLuong = 30
                },
                new Sach
                {
                    MaSach = "S048",
                    TenSach = "Kinh Tế Học Vĩ Mô",
                    TenTacGia = "Lê Thị Hồng Minh",
                    TheLoai = "Kinh tế",
                    DonGia = 165000m,
                    NgayNhap = new DateTime(2024, 3, 3),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Kinh Tế Quốc Dân",
                    SoLuong = 25
                },
                new Sach
                {
                    MaSach = "S049",
                    TenSach = "Marketing Căn Bản",
                    TenTacGia = "Phạm Xuân Hòa",
                    TheLoai = "Kinh tế",
                    DonGia = 145000m,
                    NgayNhap = new DateTime(2024, 3, 4),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Lao Động",
                    SoLuong = 38
                },
                new Sach
                {
                    MaSach = "S050",
                    TenSach = "Quản Trị Học",
                    TenTacGia = "Trần Minh Đạt",
                    TheLoai = "Kinh tế",
                    DonGia = 175000m,
                    NgayNhap = new DateTime(2024, 3, 5),
                    NamPhatHanh = 2020,
                    NhaXuatBan = "NXB Lao Động",
                    SoLuong = 33
                },
                new Sach
                {
                    MaSach = "S051",
                    TenSach = "Kế Toán Tài Chính",
                    TenTacGia = "Nguyễn Thị Phương",
                    TheLoai = "Kinh tế",
                    DonGia = 195000m,
                    NgayNhap = new DateTime(2024, 3, 6),
                    NamPhatHanh = 2022,
                    NhaXuatBan = "NXB Tài Chính",
                    SoLuong = 20
                },
                new Sach
                {
                    MaSach = "S052",
                    TenSach = "Luật Dân Sự",
                    TenTacGia = "Bộ Tư Pháp",
                    TheLoai = "Pháp luật",
                    DonGia = 125000m,
                    NgayNhap = new DateTime(2024, 3, 7),
                    NamPhatHanh = 2021,
                    NhaXuatBan = "NXB Chính Trị Quốc Gia",
                    SoLuong = 15
                },
            new Sach
            {
                MaSach = "S053",
                TenSach = "Luật Hình Sự",
                TenTacGia = "Bộ Tư Pháp",
                TheLoai = "Pháp luật",
                DonGia = 135000m,
                NgayNhap = new DateTime(2024, 3, 8),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 12
            },
            new Sach
            {
                MaSach = "S054",
                TenSach = "Tâm Lý Học Đại Cương",
                TenTacGia = "Nguyễn Quang Uẩn",
                TheLoai = "Tâm lý",
                DonGia = 165000m,
                NgayNhap = new DateTime(2024, 3, 9),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Giáo Dục",
                SoLuong = 28
            },
            new Sach
            {
                MaSach = "S055",
                TenSach = "Tâm Lý Học Trẻ Em",
                TenTacGia = "Phạm Minh Hạc",
                TheLoai = "Tâm lý",
                DonGia = 145000m,
                NgayNhap = new DateTime(2024, 3, 10),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Giáo Dục",
                SoLuong = 32
            },
            new Sach
            {
                MaSach = "S056",
                TenSach = "Giáo Dục Học",
                TenTacGia = "Nguyễn Văn Cư",
                TheLoai = "Giáo dục",
                DonGia = 155000m,
                NgayNhap = new DateTime(2024, 3, 11),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Giáo Dục",
                SoLuong = 25
            },
            new Sach
            {
                MaSach = "S057",
                TenSach = "Phương Pháp Nghiên Cứu Khoa Học",
                TenTacGia = "Hoàng Trọng",
                TheLoai = "Khoa học",
                DonGia = 175000m,
                NgayNhap = new DateTime(2024, 3, 12),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thống Kê",
                SoLuong = 20
            },
            new Sach
            {
                MaSach = "S058",
                TenSach = "Thống Kê Ứng Dụng",
                TenTacGia = "Chu Nguyễn Mộng Ngọc",
                TheLoai = "Toán học",
                DonGia = 185000m,
                NgayNhap = new DateTime(2024, 3, 13),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thống Kê",
                SoLuong = 22
            },
            new Sach
            {
                MaSach = "S059",
                TenSach = "Giải Tích I",
                TenTacGia = "Nguyễn Đình Trí",
                TheLoai = "Toán học",
                DonGia = 195000m,
                NgayNhap = new DateTime(2024, 3, 14),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Giáo Dục",
                SoLuong = 18
            },
            new Sach
            {
                MaSach = "S060",
                TenSach = "Đại Số Tuyến Tính",
                TenTacGia = "Lê Tuấn Hoa",
                TheLoai = "Toán học",
                DonGia = 175000m,
                NgayNhap = new DateTime(2024, 3, 15),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Giáo Dục",
                SoLuong = 24
            },
            new Sach
            {
                MaSach = "S061",
                TenSach = "Xác Suất Thống Kê",
                TenTacGia = "Nguyễn Cao Văn",
                TheLoai = "Toán học",
                DonGia = 165000m,
                NgayNhap = new DateTime(2024, 3, 16),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thống Kê",
                SoLuong = 30
            },
            new Sach
            {
                MaSach = "S062",
                TenSach = "Triết Học Mác - Lênin",
                TenTacGia = "Bộ Giáo Dục",
                TheLoai = "Triết học",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 3, 17),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 40
            },
            new Sach
            {
                MaSach = "S063",
                TenSach = "Kinh Tế Chính Trị Mác - Lênin",
                TenTacGia = "Bộ Giáo Dục",
                TheLoai = "Chính trị",
                DonGia = 135000m,
                NgayNhap = new DateTime(2024, 3, 18),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 35
            },
            new Sach
            {
                MaSach = "S064",
                TenSach = "Chủ Nghĩa Xã Hội Khoa Học",
                TenTacGia = "Bộ Giáo Dục",
                TheLoai = "Chính trị",
                DonGia = 115000m,
                NgayNhap = new DateTime(2024, 3, 19),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 38
            },
            new Sach
            {
                MaSach = "S065",
                TenSach = "Lịch Sử Đảng Cộng Sản Việt Nam",
                TenTacGia = "Bộ Giáo Dục",
                TheLoai = "Lịch sử",
                DonGia = 145000m,
                NgayNhap = new DateTime(2024, 3, 20),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 30
            },
            new Sach
            {
                MaSach = "S066",
                TenSach = "Tư Tưởng Hồ Chí Minh",
                TenTacGia = "Bộ Giáo Dục",
                TheLoai = "Chính trị",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 3, 21),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Chính Trị Quốc Gia",
                SoLuong = 42
            },
            new Sach
            {
                MaSach = "S067",
                TenSach = "Y Học Cổ Truyền Việt Nam",
                TenTacGia = "Hoàng Bão Châu",
                TheLoai = "Y học",
                DonGia = 225000m,
                NgayNhap = new DateTime(2024, 3, 22),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 15
            },
            new Sach
            {
                MaSach = "S068",
                TenSach = "Nội Khoa Học",
                TenTacGia = "Đỗ Đoàn Lợi",
                TheLoai = "Y học",
                DonGia = 350000m,
                NgayNhap = new DateTime(2024, 3, 23),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 8
            },
            new Sach
            {
                MaSach = "S069",
                TenSach = "Ngoại Khoa Học",
                TenTacGia = "Lê Văn Thành",
                TheLoai = "Y học",
                DonGia = 385000m,
                NgayNhap = new DateTime(2024, 3, 24),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 6
            },
            new Sach
            {
                MaSach = "S070",
                TenSach = "Dược Lý Học",
                TenTacGia = "Nguyễn Thị Kim Anh",
                TheLoai = "Y học",
                DonGia = 295000m,
                NgayNhap = new DateTime(2024, 3, 25),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 10
            },
            new Sach
            {
                MaSach = "S071",
                TenSach = "Kiến Trúc Việt Nam",
                TenTacGia = "Nguyễn Quốc Thông",
                TheLoai = "Kiến trúc",
                DonGia = 275000m,
                NgayNhap = new DateTime(2024, 3, 26),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Xây Dựng",
                SoLuong = 12
            },
            new Sach
            {
                MaSach = "S072",
                TenSach = "Kỹ Thuật Xây Dựng",
                TenTacGia = "Phạm Văn Đồng",
                TheLoai = "Kỹ thuật",
                DonGia = 245000m,
                NgayNhap = new DateTime(2024, 3, 27),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Xây Dựng",
                SoLuong = 18
            },
            new Sach
            {
                MaSach = "S073",
                TenSach = "Cơ Học Kết Cấu",
                TenTacGia = "Lê Anh Thơ",
                TheLoai = "Kỹ thuật",
                DonGia = 265000m,
                NgayNhap = new DateTime(2024, 3, 28),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Xây Dựng",
                SoLuong = 14
            },
            new Sach
            {
                MaSach = "S074",
                TenSach = "Vật Liệu Xây Dựng",
                TenTacGia = "Trần Minh Tú",
                TheLoai = "Kỹ thuật",
                DonGia = 185000m,
                NgayNhap = new DateTime(2024, 3, 29),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Xây Dựng",
                SoLuong = 25
            },
            new Sach
            {
                MaSach = "S075",
                TenSach = "Nghệ Thuật Vẽ",
                TenTacGia = "Lê Bá Đảng",
                TheLoai = "Nghệ thuật",
                DonGia = 155000m,
                NgayNhap = new DateTime(2024, 3, 30),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Mỹ Thuật",
                SoLuong = 28
            },
            new Sach
            {
                MaSach = "S076",
                TenSach = "Lịch Sử Mỹ Thuật Việt Nam",
                TenTacGia = "Phạm Huy Thông",
                TheLoai = "Nghệ thuật",
                DonGia = 195000m,
                NgayNhap = new DateTime(2024, 3, 31),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Mỹ Thuật",
                SoLuong = 20
            },
            new Sach
            {
                MaSach = "S077",
                TenSach = "Lý Thuyết Âm Nhạc",
                TenTacGia = "Đỗ Hồng Quân",
                TheLoai = "Âm nhạc",
                DonGia = 165000m,
                NgayNhap = new DateTime(2024, 4, 1),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Âm Nhạc",
                SoLuong = 22
            },
            new Sach
            {
                MaSach = "S078",
                TenSach = "Piano Cơ Bản",
                TenTacGia = "Nguyễn Thị Thanh Huyền",
                TheLoai = "Âm nhạc",
                DonGia = 145000m,
                NgayNhap = new DateTime(2024, 4, 2),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Âm Nhạc",
                SoLuong = 35
            },
            new Sach
            {
                MaSach = "S079",
                TenSach = "Guitar Tự Học",
                TenTacGia = "Lê Minh Sơn",
                TheLoai = "Âm nhạc",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 4, 3),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Âm Nhạc",
                SoLuong = 45
            },
            new Sach
            {
                MaSach = "S080",
                TenSach = "Thể Dục Thể Thao",
                TenTacGia = "Phạm Xuân Tùng",
                TheLoai = "Thể thao",
                DonGia = 115000m,
                NgayNhap = new DateTime(2024, 4, 4),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Thể Dục Thể Thao",
                SoLuong = 40
            },
            new Sach
            {
                MaSach = "S081",
                TenSach = "Bóng Đá Việt Nam",
                TenTacGia = "Nguyễn Văn Toàn",
                TheLoai = "Thể thao",
                DonGia = 95000m,
                NgayNhap = new DateTime(2024, 4, 5),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thể Dục Thể Thao",
                SoLuong = 38
            },
            new Sach
            {
                MaSach = "S082",
                TenSach = "Yoga Cơ Bản",
                TenTacGia = "Trần Thị Hồng Nhung",
                TheLoai = "Sức khỏe",
                DonGia = 135000m,
                NgayNhap = new DateTime(2024, 4, 6),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 42
            },
            new Sach
            {
                MaSach = "S083",
                TenSach = "Dinh Dưỡng Hợp Lý",
                TenTacGia = "Lê Thị Hạnh",
                TheLoai = "Sức khỏe",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 4, 7),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 35
            },
            new Sach
            {
                MaSach = "S084",
                TenSach = "Massage Trị Liệu",
                TenTacGia = "Nguyễn Văn Khang",
                TheLoai = "Sức khỏe",
                DonGia = 155000m,
                NgayNhap = new DateTime(2024, 4, 8),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Y Học",
                SoLuong = 28
            },
            new Sach
            {
                MaSach = "S085",
                TenSach = "Nấu Ăn Gia Đình",
                TenTacGia = "Bùi Thị Suốt",
                TheLoai = "Gia đình",
                DonGia = 115000m,
                NgayNhap = new DateTime(2024, 4, 9),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Phụ Nữ",
                SoLuong = 50
            },
            new Sach
            {
                MaSach = "S086",
                TenSach = "Chăm Sóc Trẻ Em",
                TenTacGia = "Nguyễn Thị Mai",
                TheLoai = "Gia đình",
                DonGia = 145000m,
                NgayNhap = new DateTime(2024, 4, 10),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Phụ Nữ",
                SoLuong = 32
            },
            new Sach
            {
                MaSach = "S087",
                TenSach = "Làm Vườn Tại Nhà",
                TenTacGia = "Trần Văn Mười",
                TheLoai = "Làm vườn",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 4, 11),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Nông Nghiệp",
                SoLuong = 38
            },
            new Sach
            {
                MaSach = "S088",
                TenSach = "Kỹ Thuật Trồng Hoa",
                TenTacGia = "Lê Thị Hoa",
                TheLoai = "Làm vườn",
                DonGia = 105000m,
                NgayNhap = new DateTime(2024, 4, 12),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Nông Nghiệp",
                SoLuong = 45
            },
            new Sach
            {
                MaSach = "S089",
                TenSach = "Chăn Nuôi Gia Cầm",
                TenTacGia = "Phạm Văn Năm",
                TheLoai = "Nông nghiệp",
                DonGia = 135000m,
                NgayNhap = new DateTime(2024, 4, 13),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Nông Nghiệp",
                SoLuong = 30
            },
            new Sach
            {
                MaSach = "S090",
                TenSach = "Kỹ Thuật Trồng Lúa",
                TenTacGia = "Nguyễn Văn Lúa",
                TheLoai = "Nông nghiệp",
                DonGia = 155000m,
                NgayNhap = new DateTime(2024, 4, 14),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Nông Nghiệp",
                SoLuong = 25
            },
            new Sach
            {
                MaSach = "S091",
                TenSach = "Du Lịch Việt Nam",
                TenTacGia = "Lê Hoàng",
                TheLoai = "Du lịch",
                DonGia = 175000m,
                NgayNhap = new DateTime(2024, 4, 15),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 35
            },
            new Sach
            {
                MaSach = "S092",
                TenSach = "Cẩm Nang Du Lịch Châu Á",
                TenTacGia = "Trần Minh Hải",
                TheLoai = "Du lịch",
                DonGia = 195000m,
                NgayNhap = new DateTime(2024, 4, 16),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 28
            },
            new Sach
            {
                MaSach = "S093",
                TenSach = "Phong Thủy Trong Nhà",
                TenTacGia = "Nguyễn Văn Phong",
                TheLoai = "Phong thủy",
                DonGia = 145000m,
                NgayNhap = new DateTime(2024, 4, 17),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Văn Hóa - Thông Tin",
                SoLuong = 22
            },
            new Sach
            {
                MaSach = "S094",
                TenSach = "Tử Vi Và Cuộc Sống",
                TenTacGia = "Lê Văn Tử",
                TheLoai = "Tâm linh",
                DonGia = 125000m,
                NgayNhap = new DateTime(2024, 4, 18),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Văn Hóa - Thông Tin",
                SoLuong = 18
            },
            new Sach
            {
                MaSach = "S095",
                TenSach = "Thiền Và Cuộc Sống",
                TenTacGia = "Thích Nhất Hạnh",
                TheLoai = "Tâm linh",
                DonGia = 165000m,
                NgayNhap = new DateTime(2024, 4, 19),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Tôn Giáo",
                SoLuong = 30
            },
            new Sach
            {
                MaSach = "S096",
                TenSach = "Lịch Sử Phật Giáo Việt Nam",
                TenTacGia = "Thích Minh Châu",
                TheLoai = "Tôn giáo",
                DonGia = 185000m,
                NgayNhap = new DateTime(2024, 4, 20),
                NamPhatHanh = 2019,
                NhaXuatBan = "NXB Tôn Giáo",
                SoLuong = 20
            },
            new Sach
            {
                MaSach = "S097",
                TenSach = "Nghệ Thuật Sống",
                TenTacGia = "Epictetus",
                TheLoai = "Triết học",
                DonGia = 155000m,
                NgayNhap = new DateTime(2024, 4, 21),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 25
            },
            new Sach
            {
                MaSach = "S098",
                TenSach = "21 Bài Học Cho Thế Kỷ 21",
                TenTacGia = "Yuval Noah Harari",
                TheLoai = "Khoa học",
                DonGia = 215000m,
                NgayNhap = new DateTime(2024, 4, 22),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 32
            },
            new Sach
            {
                MaSach = "S099",
                TenSach = "Homo Deus",
                TenTacGia = "Yuval Noah Harari",
                TheLoai = "Khoa học",
                DonGia = 205000m,
                NgayNhap = new DateTime(2024, 4, 23),
                NamPhatHanh = 2020,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 28
            },
            new Sach
            {
                MaSach = "S100",
                TenSach = "Thuật Toán Cuộc Sống",
                TenTacGia = "Brian Christian",
                TheLoai = "Khoa học",
                DonGia = 195000m,
                NgayNhap = new DateTime(2024, 4, 24),
                NamPhatHanh = 2021,
                NhaXuatBan = "NXB Thế Giới",
                SoLuong = 24
            });
         }
                
        private void Seed_PhieuMuon(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuMuon>().HasData(
              new PhieuMuon { MaPhieuMuon = "PM001", MaDocGia = "DG001", NgayMuon = new DateTime(2025, 7, 1), NgayPhaiTra = new DateTime(2025, 7, 15) },
              new PhieuMuon { MaPhieuMuon = "PM002", MaDocGia = "DG002", NgayMuon = new DateTime(2025, 7, 2), NgayPhaiTra = new DateTime(2025, 7, 16) },
              new PhieuMuon { MaPhieuMuon = "PM003", MaDocGia = "DG003", NgayMuon = new DateTime(2025, 7, 3), NgayPhaiTra = new DateTime(2025, 7, 17) },
              new PhieuMuon { MaPhieuMuon = "PM004", MaDocGia = "DG004", NgayMuon = new DateTime(2025, 7, 4), NgayPhaiTra = new DateTime(2025, 7, 18) },
              new PhieuMuon { MaPhieuMuon = "PM005", MaDocGia = "DG005", NgayMuon = new DateTime(2025, 7, 5), NgayPhaiTra = new DateTime(2025, 7, 19) },
              new PhieuMuon { MaPhieuMuon = "PM006", MaDocGia = "DG006", NgayMuon = new DateTime(2025, 7, 6), NgayPhaiTra = new DateTime(2025, 7, 20) },
              new PhieuMuon { MaPhieuMuon = "PM007", MaDocGia = "DG007", NgayMuon = new DateTime(2025, 7, 7), NgayPhaiTra = new DateTime(2025, 7, 21) },
              new PhieuMuon { MaPhieuMuon = "PM008", MaDocGia = "DG008", NgayMuon = new DateTime(2025, 7, 8), NgayPhaiTra = new DateTime(2025, 7, 22) },
              new PhieuMuon { MaPhieuMuon = "PM009", MaDocGia = "DG009", NgayMuon = new DateTime(2025, 7, 9), NgayPhaiTra = new DateTime(2025, 7, 23) },
              new PhieuMuon { MaPhieuMuon = "PM010", MaDocGia = "DG010", NgayMuon = new DateTime(2025, 7, 10), NgayPhaiTra = new DateTime(2025, 7, 24) },
              new PhieuMuon { MaPhieuMuon = "PM011", MaDocGia = "DG001", NgayMuon = new DateTime(2025, 7, 12), NgayPhaiTra = new DateTime(2025, 7, 26) },
              new PhieuMuon { MaPhieuMuon = "PM012", MaDocGia = "DG002", NgayMuon = new DateTime(2025, 7, 13), NgayPhaiTra = new DateTime(2025, 7, 27) }
          );
        }
        private void Seed_ChiTietPhieuMuon(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuon>().HasData(
                new { MaPhieuMuon = "PM001", MaSach = "S001", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM002", MaSach = "S002", SoLuongMuon = 2, DaTra = false },
                new { MaPhieuMuon = "PM003", MaSach = "S003", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM004", MaSach = "S004", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM005", MaSach = "S005", SoLuongMuon = 2, DaTra = false },
                new { MaPhieuMuon = "PM006", MaSach = "S006", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM007", MaSach = "S007", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM008", MaSach = "S008", SoLuongMuon = 2, DaTra = false },
                new { MaPhieuMuon = "PM009", MaSach = "S009", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM010", MaSach = "S010", SoLuongMuon = 2, DaTra = false },
                new { MaPhieuMuon = "PM011", MaSach = "S001", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM011", MaSach = "S002", SoLuongMuon = 1, DaTra = false },
                new { MaPhieuMuon = "PM012", MaSach = "S003", SoLuongMuon = 2, DaTra = false },
                new { MaPhieuMuon = "PM012", MaSach = "S004", SoLuongMuon = 1, DaTra = false }
            );
        }
        private void Seed_PhieuTra(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuTra>().HasData(
                new PhieuTra { MaPhieuTra = "PT001", MaPhieuMuon = "PM001", NgayTra = new DateTime(2025, 7, 17) },
                new PhieuTra { MaPhieuTra = "PT002", MaPhieuMuon = "PM002", NgayTra = new DateTime(2025, 7, 19) },
                new PhieuTra { MaPhieuTra = "PT003", MaPhieuMuon = "PM003", NgayTra = new DateTime(2025, 7, 20) },
                new PhieuTra { MaPhieuTra = "PT004", MaPhieuMuon = "PM004", NgayTra = new DateTime(2025, 7, 21) },
                new PhieuTra { MaPhieuTra = "PT005", MaPhieuMuon = "PM005", NgayTra = new DateTime(2025, 7, 19) },
                new PhieuTra { MaPhieuTra = "PT006", MaPhieuMuon = "PM006", NgayTra = new DateTime(2025, 7, 22) },
                new PhieuTra { MaPhieuTra = "PT007", MaPhieuMuon = "PM007", NgayTra = new DateTime(2025, 7, 23) },
                new PhieuTra { MaPhieuTra = "PT008", MaPhieuMuon = "PM008", NgayTra = new DateTime(2025, 7, 25) },
                new PhieuTra { MaPhieuTra = "PT009", MaPhieuMuon = "PM009", NgayTra = new DateTime(2025, 7, 24) },
                new PhieuTra { MaPhieuTra = "PT010", MaPhieuMuon = "PM010", NgayTra = new DateTime(2025, 7, 27) }
            );
        }
        private void Seed_ChiTietPhieuTra(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuTra>().HasData(
                 new ChiTietPhieuTra { MaPhieuTra = "PT001", MaSach = "S001", soLuongTra = 1, TienPhat = 2 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT002", MaSach = "S002", soLuongTra = 1, TienPhat = 3 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT003", MaSach = "S003", soLuongTra = 2, TienPhat = 4 * 2 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT004", MaSach = "S004", soLuongTra = 1, TienPhat = 5 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT005", MaSach = "S005", soLuongTra = 1, TienPhat = 3 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT006", MaSach = "S006", soLuongTra = 2, TienPhat = 4 * 2 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT007", MaSach = "S007", soLuongTra = 1, TienPhat = 5 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT008", MaSach = "S008", soLuongTra = 2, TienPhat = 6 * 2 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT009", MaSach = "S009", soLuongTra = 1, TienPhat = 4 * 1 * 1000 },
                 new ChiTietPhieuTra { MaPhieuTra = "PT010", MaSach = "S010", soLuongTra = 2, TienPhat = 5 * 2 * 1000 }
             );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed_Admin(modelBuilder);
            Seed_DocGia(modelBuilder);
            SeedSach(modelBuilder);
            Seed_PhieuMuon(modelBuilder);
            Seed_ChiTietPhieuMuon(modelBuilder);
            Seed_PhieuTra(modelBuilder);
            Seed_ChiTietPhieuTra(modelBuilder);
            modelBuilder.Entity<ChiTietPhieuMuon>().HasKey(c => new { c.MaPhieuMuon, c.MaSach });
            modelBuilder.Entity<ChiTietPhieuTra>().HasKey(c => new { c.MaPhieuTra, c.MaSach});
        }
    }
}