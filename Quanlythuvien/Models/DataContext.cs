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

namespace Quanlythuvien.Models
{
    internal class DataContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<QuyenSach> QuyenSachs { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }
        public DbSet<PhieuTra> PhieuTras { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            String sqlcu = "Data Source=ADMIN-PC;Initial Catalog=Quanlythuvien;Integrated Security=True;Trust Server Certificate=True";
            String sqlCuong = "";
            String sqlChien = "";
            optionsBuilder.UseSqlServer(sqlcu);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PhieuMuon>()
            .HasOne(pm => pm.PhieuTra)
            .WithOne(pt => pt.PhieuMuon)
            .HasForeignKey<PhieuTra>(pt => pt.PhieuTraId) 
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuMuon>()
            .HasOne(pm => pm.DocGia)
            .WithMany(dg => dg.PhieuMuon)
            .HasForeignKey(pm => pm.MaDocGia)
            .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Admin>().HasData(
                new Admin { id = 1, username = "Admin1", password = "2004"},
                new Admin { id = 2, username = "Admin2", password = "2004" },
                new Admin { id = 3, username = "Admin3", password = "2004" },
                new Admin { id = 4, username = "Admin4", password = "2004" },
                new Admin { id = 5, username = "Admin5", password = "2004" },
                new Admin { id = 6, username = "Admin6", password = "2004" },
                new Admin { id = 7, username = "Admin7", password = "2004" },
                new Admin { id = 8, username = "Admin8", password = "2004" },
                new Admin { id = 9, username = "Admin9", password = "2004" },
                new Admin { id = 10, username = "Admin110", password = "2004" }
            );
            modelBuilder.Entity<DocGia>().HasData(
                new DocGia { MaDocGia = "DG001", HoTen = "Nguyễn Văn An", GioiTinh = "Nam", NgaySinh = new DateTime(1995, 3, 15), SoDienThoai = "0912345678", Email = "nguyenvana@example.com", DiaChi = "12 Tràng Tiền, Hà Nội", NgayDangKy = new DateTime(2025, 1, 5), SoSachMuonToiDa = 5, TienDangKy = 50000m },
                new DocGia { MaDocGia = "DG002", HoTen = "Trần Thị Bình", GioiTinh = "Nữ", NgaySinh = new DateTime(1998, 9, 20), SoDienThoai = "0934567890", Email = "tranthib@example.com", DiaChi = "45 Lê Lợi, TP.HCM", NgayDangKy = new DateTime(2025, 2, 10), SoSachMuonToiDa = 6, TienDangKy = 60000m },
                new DocGia { MaDocGia = "DG003", HoTen = "Lê Hoàng Cường", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 7, 7), SoDienThoai = "0971122334", Email = "lehoangc@example.com", DiaChi = "99 Phạm Văn Đồng, TP.HCM", NgayDangKy = new DateTime(2025, 3, 2), SoSachMuonToiDa = 4, TienDangKy = 55000m },
                new DocGia { MaDocGia = "DG004", HoTen = "Phạm Minh Duy", GioiTinh = "Nam", NgaySinh = new DateTime(1988, 12, 30), SoDienThoai = "0908123456", Email = "phaminhd@example.com", DiaChi = "18 Điện Biên Phủ, Hà Nội", NgayDangKy = new DateTime(2025, 3, 18), SoSachMuonToiDa = 5, TienDangKy = 100000m },
                new DocGia { MaDocGia = "DG005", HoTen = "Đặng Thùy Huyền", GioiTinh = "Nữ", NgaySinh = new DateTime(2000, 1, 11), SoDienThoai = "0369988776", Email = "dangthuye@example.com", DiaChi = "6 Nguyễn Trãi, Hà Nội", NgayDangKy = new DateTime(2025, 4, 1), SoSachMuonToiDa = 5, TienDangKy = 45000m },
                new DocGia { MaDocGia = "DG006", HoTen = "Võ Quốc Toàn", GioiTinh = "Nam", NgaySinh = new DateTime(1993, 4, 4), SoDienThoai = "0924455667", Email = "voquocf@example.com", DiaChi = "150 Hai Bà Trưng, TP.HCM", NgayDangKy = new DateTime(2025, 4, 20), SoSachMuonToiDa = 7, TienDangKy = 70000m },
                new DocGia { MaDocGia = "DG007", HoTen = "Ngô Đức Duy", GioiTinh = "Nam", NgaySinh = new DateTime(1979, 11, 5), SoDienThoai = "0919988775", Email = "ngoducg@example.com", DiaChi = "210 Nguyễn Huệ, Huế", NgayDangKy = new DateTime(2025, 5, 2), SoSachMuonToiDa = 3, TienDangKy = 120000m },
                new DocGia { MaDocGia = "DG008", HoTen = "Bùi Thị Hằng", GioiTinh = "Nữ", NgaySinh = new DateTime(2005, 6, 14), SoDienThoai = "0988112233", Email = "buithih@example.com", DiaChi = "34 Trần Hưng Đạo, Nam Định", NgayDangKy = new DateTime(2025, 5, 28), SoSachMuonToiDa = 5, TienDangKy = 40000m },
                new DocGia { MaDocGia = "DG009", HoTen = "Trịnh Gia Bảo", GioiTinh = "Nam", NgaySinh = new DateTime(1991, 2, 22), SoDienThoai = "0955667788", Email = "trinhgiai@example.com", DiaChi = "8 Lý Thường Kiệt, Đà Nẵng", NgayDangKy = new DateTime(2025, 6, 10), SoSachMuonToiDa = 6, TienDangKy = 80000m },
                new DocGia { MaDocGia = "DG010", HoTen = "Hoàng Mỹ Khánh", GioiTinh = "Nữ", NgaySinh = new DateTime(1985, 8, 18), SoDienThoai = "0965123456", Email = "hoangmyk@example.com", DiaChi = "35 Nguyễn Văn Cừ, Nha Trang", NgayDangKy = new DateTime(2025, 6, 25), SoSachMuonToiDa = 5, TienDangKy = 65000m }
            );

            modelBuilder.Entity<Sach>().HasData(
                new Sach { MaSach = "S001", TenSach = "Dế Mèn Phiêu Lưu Ký", TenTacGia = "Tô Hoài", TheLoai = "Thiếu nhi", DonGia = 90000m, NgayNhap = new DateTime(2025, 6, 10), NamPhatHanh = 2007, NhaXuatBan = "NXB Kim Đồng", SoLuong = 5 },
                new Sach { MaSach = "S002", TenSach = "Lão Hạc", TenTacGia = "Nam Cao", TheLoai = "Văn học", DonGia = 75000m, NgayNhap = new DateTime(2025, 6, 11), NamPhatHanh = 1950, NhaXuatBan = "NXB Văn Học", SoLuong = 4 },
                new Sach { MaSach = "S003", TenSach = "Sapiens", TenTacGia = "Yuval N. Harari", TheLoai = "Khoa học", DonGia = 150000m, NgayNhap = new DateTime(2025, 6, 11), NamPhatHanh = 2011, NhaXuatBan = "NXB Tri Thức", SoLuong = 6 },
                new Sach { MaSach = "S004", TenSach = "Totto‑Chan Bên Cửa Sổ", TenTacGia = "Tetsuko Kuroyanagi", TheLoai = "Thiếu nhi", DonGia = 95000m, NgayNhap = new DateTime(2025, 6, 12), NamPhatHanh = 1981, NhaXuatBan = "NXB Trẻ", SoLuong = 3 },
                new Sach { MaSach = "S005", TenSach = "Đắc Nhân Tâm", TenTacGia = "Dale Carnegie", TheLoai = "Kỹ năng", DonGia = 120000m, NgayNhap = new DateTime(2025, 6, 12), NamPhatHanh = 1936, NhaXuatBan = "NXB Tổng Hợp", SoLuong = 7 },
                new Sach { MaSach = "S006", TenSach = "Nhà Giả Kim", TenTacGia = "Paulo Coelho", TheLoai = "Tiểu thuyết", DonGia = 110000m, NgayNhap = new DateTime(2025, 6, 13), NamPhatHanh = 1988, NhaXuatBan = "NXB Trẻ", SoLuong = 4 },
                new Sach { MaSach = "S007", TenSach = "Tư Duy Nhanh Và Chậm", TenTacGia = "Daniel Kahneman", TheLoai = "Khoa học", DonGia = 135000m, NgayNhap = new DateTime(2025, 6, 13), NamPhatHanh = 2011, NhaXuatBan = "NXB Tri Thức", SoLuong = 6 },
                new Sach { MaSach = "S008", TenSach = "Mắt Biếc", TenTacGia = "Nguyễn Nhật Ánh", TheLoai = "Tiểu thuyết", DonGia = 85000m, NgayNhap = new DateTime(2025, 6, 13), NamPhatHanh = 1990, NhaXuatBan = "NXB Trẻ", SoLuong = 5 },
                new Sach { MaSach = "S009", TenSach = "Bí Mật Của Nước", TenTacGia = "Masaru Emoto", TheLoai = "Khoa học", DonGia = 99000m, NgayNhap = new DateTime(2025, 6, 14), NamPhatHanh = 2004, NhaXuatBan = "NXB Lao Động", SoLuong = 4 },
                new Sach { MaSach = "S010", TenSach = "Đi Tìm Lẽ Sống", TenTacGia = "Viktor E. Frankl", TheLoai = "Tâm lý", DonGia = 125000m, NgayNhap = new DateTime(2025, 6, 14), NamPhatHanh = 1946, NhaXuatBan = "NXB Lao Động", SoLuong = 4 },
                new Sach { MaSach = "S011", TenSach = "7 Thói Quen Hiệu Quả", TenTacGia = "Stephen R. Covey", TheLoai = "Kỹ năng", DonGia = 118000m, NgayNhap = new DateTime(2025, 6, 15), NamPhatHanh = 1989, NhaXuatBan = "NXB Tổng Hợp", SoLuong = 6 },
                new Sach { MaSach = "S012", TenSach = "Cuộc Cách Mạng 4.0", TenTacGia = "Klaus Schwab", TheLoai = "Kinh tế", DonGia = 105000m, NgayNhap = new DateTime(2025, 6, 15), NamPhatHanh = 2016, NhaXuatBan = "NXB Tri Thức", SoLuong = 5 },
                new Sach { MaSach = "S013", TenSach = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", TenTacGia = "Nguyễn Nhật Ánh", TheLoai = "Tiểu thuyết", DonGia = 89000m, NgayNhap = new DateTime(2025, 6, 15), NamPhatHanh = 2010, NhaXuatBan = "NXB Trẻ", SoLuong = 3 },
                new Sach { MaSach = "S014", TenSach = "Khéo Ăn Nói...", TenTacGia = "Trác Nhã", TheLoai = "Kỹ năng", DonGia = 95000m, NgayNhap = new DateTime(2025, 6, 16), NamPhatHanh = 2014, NhaXuatBan = "NXB Lao Động", SoLuong = 5 },
                new Sach { MaSach = "S015", TenSach = "Kiêu Hãnh & Định Kiến", TenTacGia = "Jane Austen", TheLoai = "Tiểu thuyết", DonGia = 99000m, NgayNhap = new DateTime(2025, 6, 16), NamPhatHanh = 1813, NhaXuatBan = "NXB Văn Học", SoLuong = 4 },
                new Sach { MaSach = "S016", TenSach = "Sherlock Holmes Tuyển Tập", TenTacGia = "Arthur C. Doyle", TheLoai = "Trinh thám", DonGia = 140000m, NgayNhap = new DateTime(2025, 6, 16), NamPhatHanh = 1892, NhaXuatBan = "NXB Trẻ", SoLuong = 7 },
                new Sach { MaSach = "S017", TenSach = "Harry Potter 1: Hòn Đá Phù Thủy", TenTacGia = "J.K. Rowling", TheLoai = "Fantasy", DonGia = 135000m, NgayNhap = new DateTime(2025, 6, 17), NamPhatHanh = 1997, NhaXuatBan = "NXB Trẻ", SoLuong = 6 },
                new Sach { MaSach = "S018", TenSach = "Khi Hơi Thở Hóa Thinh Không", TenTacGia = "Paul Kalanithi", TheLoai = "Tự truyện", DonGia = 108000m, NgayNhap = new DateTime(2025, 6, 17), NamPhatHanh = 2016, NhaXuatBan = "NXB Tri Thức", SoLuong = 3 },
                new Sach { MaSach = "S019", TenSach = "Cà Phê Cùng Tony", TenTacGia = "Tony Buổi Sáng", TheLoai = "Kỹ năng", DonGia = 78000m, NgayNhap = new DateTime(2025, 6, 17), NamPhatHanh = 2015, NhaXuatBan = "NXB Trẻ", SoLuong = 4 },
                new Sach { MaSach = "S020", TenSach = "Suối Nguồn", TenTacGia = "Ayn Rand", TheLoai = "Tiểu thuyết", DonGia = 145000m, NgayNhap = new DateTime(2025, 6, 18), NamPhatHanh = 1943, NhaXuatBan = "NXB Văn Học", SoLuong = 3 },
                new Sach { MaSach = "S021", TenSach = "Kỷ Luật Tự Giác", TenTacGia = "Stephen R. Covey", TheLoai = "Kỹ năng", DonGia = 112000m, NgayNhap = new DateTime(2025, 6, 18), NamPhatHanh = 2004, NhaXuatBan = "NXB Tổng Hợp", SoLuong = 5 },
                new Sach { MaSach = "S022", TenSach = "Cha Giàu Cha Nghèo", TenTacGia = "R. T. Kiyosaki", TheLoai = "Kinh tế", DonGia = 130000m, NgayNhap = new DateTime(2025, 6, 18), NamPhatHanh = 1997, NhaXuatBan = "NXB Trẻ", SoLuong = 6 },
                new Sach { MaSach = "S023", TenSach = "Người Bán Hàng Vĩ Đại", TenTacGia = "Og Mandino", TheLoai = "Kỹ năng", DonGia = 88000m, NgayNhap = new DateTime(2025, 6, 19), NamPhatHanh = 1968, NhaXuatBan = "NXB Lao Động", SoLuong = 4 },
                new Sach { MaSach = "S024", TenSach = "Bố Già", TenTacGia = "Mario Puzo", TheLoai = "Tiểu thuyết", DonGia = 118000m, NgayNhap = new DateTime(2025, 6, 19), NamPhatHanh = 1969, NhaXuatBan = "NXB Văn Học", SoLuong = 7 },
                new Sach { MaSach = "S025", TenSach = "Trăm Năm Cô Đơn", TenTacGia = "G. G. Márquez", TheLoai = "Tiểu thuyết", DonGia = 128000m, NgayNhap = new DateTime(2025, 6, 19), NamPhatHanh = 1967, NhaXuatBan = "NXB Văn Học", SoLuong = 5 },
                new Sach { MaSach = "S026", TenSach = "Ông Già Và Biển Cả", TenTacGia = "Ernest Hemingway", TheLoai = "Tiểu thuyết", DonGia = 92000m, NgayNhap = new DateTime(2025, 6, 20), NamPhatHanh = 1952, NhaXuatBan = "NXB Văn Học", SoLuong = 3 },
                new Sach { MaSach = "S027", TenSach = "Hoa Nhẫn Thạch", TenTacGia = "Yasunari Kawabata", TheLoai = "Tiểu thuyết", DonGia = 104000m, NgayNhap = new DateTime(2025, 6, 20), NamPhatHanh = 1949, NhaXuatBan = "NXB Văn Học", SoLuong = 4 },
                new Sach { MaSach = "S028", TenSach = "The Lean Startup", TenTacGia = "Eric Ries", TheLoai = "Kinh tế", DonGia = 132000m, NgayNhap = new DateTime(2025, 6, 20), NamPhatHanh = 2011, NhaXuatBan = "NXB Tri Thức", SoLuong = 5 },
                new Sach { MaSach = "S029", TenSach = "Thiên Tài Bên Trái...", TenTacGia = "Eric B. T. Lin", TheLoai = "Khoa học", DonGia = 119000m, NgayNhap = new DateTime(2025, 6, 21), NamPhatHanh = 2014, NhaXuatBan = "NXB Lao Động", SoLuong = 4 },
                new Sach { MaSach = "S030", TenSach = "Nhật Ký Anne Frank", TenTacGia = "Anne Frank", TheLoai = "Tự truyện", DonGia = 103000m, NgayNhap = new DateTime(2025, 6, 21), NamPhatHanh = 1947, NhaXuatBan = "NXB Văn Học", SoLuong = 6 }
            );
            modelBuilder.Entity<QuyenSach>().HasData(
                /* ------------ S001 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 1, MaSach = "S001", TinhTrang = "Mới", ViTriKe = "A1-01", NgayNhap = new DateTime(2025, 6, 10), CoSan = true },
                new QuyenSach { QuyenSachId = 2, MaSach = "S001", TinhTrang = "Mới", ViTriKe = "A1-02", NgayNhap = new DateTime(2025, 6, 10), CoSan = true },
                new QuyenSach { QuyenSachId = 3, MaSach = "S001", TinhTrang = "Mới", ViTriKe = "A1-03", NgayNhap = new DateTime(2025, 6, 10), CoSan = true },
                new QuyenSach { QuyenSachId = 4, MaSach = "S001", TinhTrang = "Mới", ViTriKe = "A1-04", NgayNhap = new DateTime(2025, 6, 10), CoSan = true },
                new QuyenSach { QuyenSachId = 5, MaSach = "S001", TinhTrang = "Mới", ViTriKe = "A1-05", NgayNhap = new DateTime(2025, 6, 10), CoSan = true },

                /* ------------ S002 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 6, MaSach = "S002", TinhTrang = "Mới", ViTriKe = "A2-01", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 7, MaSach = "S002", TinhTrang = "Mới", ViTriKe = "A2-02", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 8, MaSach = "S002", TinhTrang = "Mới", ViTriKe = "A2-03", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 9, MaSach = "S002", TinhTrang = "Mới", ViTriKe = "A2-04", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },

                /* ------------ S003 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 10, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-01", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 11, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-02", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 12, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-03", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 13, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-04", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 14, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-05", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },
                new QuyenSach { QuyenSachId = 15, MaSach = "S003", TinhTrang = "Mới", ViTriKe = "A3-06", NgayNhap = new DateTime(2025, 6, 11), CoSan = true },

                /* ------------ S004 (3 bản) ------------ */
                new QuyenSach { QuyenSachId = 16, MaSach = "S004", TinhTrang = "Mới", ViTriKe = "A4-01", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 17, MaSach = "S004", TinhTrang = "Mới", ViTriKe = "A4-02", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 18, MaSach = "S004", TinhTrang = "Mới", ViTriKe = "A4-03", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },

                /* ------------ S005 (7 bản) ------------ */
                new QuyenSach { QuyenSachId = 19, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-01", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 20, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-02", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 21, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-03", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 22, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-04", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 23, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-05", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 24, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-06", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },
                new QuyenSach { QuyenSachId = 25, MaSach = "S005", TinhTrang = "Mới", ViTriKe = "A5-07", NgayNhap = new DateTime(2025, 6, 12), CoSan = true },

                /* ------------ S006 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 26, MaSach = "S006", TinhTrang = "Mới", ViTriKe = "B1-01", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 27, MaSach = "S006", TinhTrang = "Mới", ViTriKe = "B1-02", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 28, MaSach = "S006", TinhTrang = "Mới", ViTriKe = "B1-03", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 29, MaSach = "S006", TinhTrang = "Mới", ViTriKe = "B1-04", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },

                /* ------------ S007 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 30, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-01", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 31, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-02", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 32, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-03", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 33, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-04", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 34, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-05", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 35, MaSach = "S007", TinhTrang = "Mới", ViTriKe = "B2-06", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },

                /* ------------ S008 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 36, MaSach = "S008", TinhTrang = "Mới", ViTriKe = "B3-01", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 37, MaSach = "S008", TinhTrang = "Mới", ViTriKe = "B3-02", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 38, MaSach = "S008", TinhTrang = "Mới", ViTriKe = "B3-03", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 39, MaSach = "S008", TinhTrang = "Mới", ViTriKe = "B3-04", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },
                new QuyenSach { QuyenSachId = 40, MaSach = "S008", TinhTrang = "Mới", ViTriKe = "B3-05", NgayNhap = new DateTime(2025, 6, 13), CoSan = true },

                /* ------------ S009 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 41, MaSach = "S009", TinhTrang = "Mới", ViTriKe = "B4-01", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 42, MaSach = "S009", TinhTrang = "Mới", ViTriKe = "B4-02", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 43, MaSach = "S009", TinhTrang = "Mới", ViTriKe = "B4-03", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 44, MaSach = "S009", TinhTrang = "Mới", ViTriKe = "B4-04", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },

                /* ------------ S010 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 45, MaSach = "S010", TinhTrang = "Mới", ViTriKe = "B5-01", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 46, MaSach = "S010", TinhTrang = "Mới", ViTriKe = "B5-02", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 47, MaSach = "S010", TinhTrang = "Mới", ViTriKe = "B5-03", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },
                new QuyenSach { QuyenSachId = 48, MaSach = "S010", TinhTrang = "Mới", ViTriKe = "B5-04", NgayNhap = new DateTime(2025, 6, 14), CoSan = true },

                /* ------------ S011 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 49, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-01", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 50, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-02", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 51, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-03", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 52, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-04", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 53, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-05", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 54, MaSach = "S011", TinhTrang = "Mới", ViTriKe = "C1-06", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },

                /* ------------ S012 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 55, MaSach = "S012", TinhTrang = "Mới", ViTriKe = "C2-01", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 56, MaSach = "S012", TinhTrang = "Mới", ViTriKe = "C2-02", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 57, MaSach = "S012", TinhTrang = "Mới", ViTriKe = "C2-03", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 58, MaSach = "S012", TinhTrang = "Mới", ViTriKe = "C2-04", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 59, MaSach = "S012", TinhTrang = "Mới", ViTriKe = "C2-05", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },

                /* ------------ S013 (3 bản) ------------ */
                new QuyenSach { QuyenSachId = 60, MaSach = "S013", TinhTrang = "Mới", ViTriKe = "C3-01", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 61, MaSach = "S013", TinhTrang = "Mới", ViTriKe = "C3-02", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },
                new QuyenSach { QuyenSachId = 62, MaSach = "S013", TinhTrang = "Mới", ViTriKe = "C3-03", NgayNhap = new DateTime(2025, 6, 15), CoSan = true },

                /* ------------ S014 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 63, MaSach = "S014", TinhTrang = "Mới", ViTriKe = "C4-01", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 64, MaSach = "S014", TinhTrang = "Mới", ViTriKe = "C4-02", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 65, MaSach = "S014", TinhTrang = "Mới", ViTriKe = "C4-03", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 66, MaSach = "S014", TinhTrang = "Mới", ViTriKe = "C4-04", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 67, MaSach = "S014", TinhTrang = "Mới", ViTriKe = "C4-05", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },

                /* ------------ S015 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 68, MaSach = "S015", TinhTrang = "Mới", ViTriKe = "C5-01", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 69, MaSach = "S015", TinhTrang = "Mới", ViTriKe = "C5-02", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 70, MaSach = "S015", TinhTrang = "Mới", ViTriKe = "C5-03", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 71, MaSach = "S015", TinhTrang = "Mới", ViTriKe = "C5-04", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },

                /* ------------ S016 (7 bản) ------------ */
                new QuyenSach { QuyenSachId = 72, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-01", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 73, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-02", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 74, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-03", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 75, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-04", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 76, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-05", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 77, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-06", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },
                new QuyenSach { QuyenSachId = 78, MaSach = "S016", TinhTrang = "Mới", ViTriKe = "D1-07", NgayNhap = new DateTime(2025, 6, 16), CoSan = true },

                /* ------------ S017 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 79, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-01", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 80, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-02", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 81, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-03", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 82, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-04", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 83, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-05", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 84, MaSach = "S017", TinhTrang = "Mới", ViTriKe = "D2-06", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },

                /* ------------ S018 (3 bản) ------------ */
                new QuyenSach { QuyenSachId = 85, MaSach = "S018", TinhTrang = "Mới", ViTriKe = "D3-01", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 86, MaSach = "S018", TinhTrang = "Mới", ViTriKe = "D3-02", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 87, MaSach = "S018", TinhTrang = "Mới", ViTriKe = "D3-03", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },

                /* ------------ S019 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 88, MaSach = "S019", TinhTrang = "Mới", ViTriKe = "D4-01", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 89, MaSach = "S019", TinhTrang = "Mới", ViTriKe = "D4-02", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 90, MaSach = "S019", TinhTrang = "Mới", ViTriKe = "D4-03", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },
                new QuyenSach { QuyenSachId = 91, MaSach = "S019", TinhTrang = "Mới", ViTriKe = "D4-04", NgayNhap = new DateTime(2025, 6, 17), CoSan = true },

                /* ------------ S020 (3 bản) ------------ */
                new QuyenSach { QuyenSachId = 92, MaSach = "S020", TinhTrang = "Mới", ViTriKe = "D5-01", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 93, MaSach = "S020", TinhTrang = "Mới", ViTriKe = "D5-02", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 94, MaSach = "S020", TinhTrang = "Mới", ViTriKe = "D5-03", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },

                /* ------------ S021 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 95, MaSach = "S021", TinhTrang = "Mới", ViTriKe = "E1-01", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 96, MaSach = "S021", TinhTrang = "Mới", ViTriKe = "E1-02", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 97, MaSach = "S021", TinhTrang = "Mới", ViTriKe = "E1-03", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 98, MaSach = "S021", TinhTrang = "Mới", ViTriKe = "E1-04", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 99, MaSach = "S021", TinhTrang = "Mới", ViTriKe = "E1-05", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },

                /* ------------ S022 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 100, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-01", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 101, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-02", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 102, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-03", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 103, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-04", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 104, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-05", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },
                new QuyenSach { QuyenSachId = 105, MaSach = "S022", TinhTrang = "Mới", ViTriKe = "E2-06", NgayNhap = new DateTime(2025, 6, 18), CoSan = true },

                /* ------------ S023 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 106, MaSach = "S023", TinhTrang = "Mới", ViTriKe = "E3-01", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 107, MaSach = "S023", TinhTrang = "Mới", ViTriKe = "E3-02", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 108, MaSach = "S023", TinhTrang = "Mới", ViTriKe = "E3-03", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 109, MaSach = "S023", TinhTrang = "Mới", ViTriKe = "E3-04", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },

                /* ------------ S024 (7 bản) ------------ */
                new QuyenSach { QuyenSachId = 110, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-01", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 111, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-02", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 112, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-03", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 113, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-04", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 114, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-05", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 115, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-06", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 116, MaSach = "S024", TinhTrang = "Mới", ViTriKe = "E4-07", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },

                /* ------------ S025 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 117, MaSach = "S025", TinhTrang = "Mới", ViTriKe = "E5-01", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 118, MaSach = "S025", TinhTrang = "Mới", ViTriKe = "E5-02", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 119, MaSach = "S025", TinhTrang = "Mới", ViTriKe = "E5-03", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 120, MaSach = "S025", TinhTrang = "Mới", ViTriKe = "E5-04", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },
                new QuyenSach { QuyenSachId = 121, MaSach = "S025", TinhTrang = "Mới", ViTriKe = "E5-05", NgayNhap = new DateTime(2025, 6, 19), CoSan = true },

                /* ------------ S026 (3 bản) ------------ */
                new QuyenSach { QuyenSachId = 122, MaSach = "S026", TinhTrang = "Mới", ViTriKe = "F1-01", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 123, MaSach = "S026", TinhTrang = "Mới", ViTriKe = "F1-02", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 124, MaSach = "S026", TinhTrang = "Mới", ViTriKe = "F1-03", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },

                /* ------------ S027 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 125, MaSach = "S027", TinhTrang = "Mới", ViTriKe = "F2-01", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 126, MaSach = "S027", TinhTrang = "Mới", ViTriKe = "F2-02", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 127, MaSach = "S027", TinhTrang = "Mới", ViTriKe = "F2-03", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 128, MaSach = "S027", TinhTrang = "Mới", ViTriKe = "F2-04", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },

                /* ------------ S028 (5 bản) ------------ */
                new QuyenSach { QuyenSachId = 129, MaSach = "S028", TinhTrang = "Mới", ViTriKe = "F3-01", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 130, MaSach = "S028", TinhTrang = "Mới", ViTriKe = "F3-02", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 131, MaSach = "S028", TinhTrang = "Mới", ViTriKe = "F3-03", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 132, MaSach = "S028", TinhTrang = "Mới", ViTriKe = "F3-04", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },
                new QuyenSach { QuyenSachId = 133, MaSach = "S028", TinhTrang = "Mới", ViTriKe = "F3-05", NgayNhap = new DateTime(2025, 6, 20), CoSan = true },

                /* ------------ S029 (4 bản) ------------ */
                new QuyenSach { QuyenSachId = 134, MaSach = "S029", TinhTrang = "Mới", ViTriKe = "F4-01", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 135, MaSach = "S029", TinhTrang = "Mới", ViTriKe = "F4-02", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 136, MaSach = "S029", TinhTrang = "Mới", ViTriKe = "F4-03", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 137, MaSach = "S029", TinhTrang = "Mới", ViTriKe = "F4-04", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },

                /* ------------ S030 (6 bản) ------------ */
                new QuyenSach { QuyenSachId = 138, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-01", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 139, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-02", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 140, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-03", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 141, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-04", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 142, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-05", NgayNhap = new DateTime(2025, 6, 21), CoSan = true },
                new QuyenSach { QuyenSachId = 143, MaSach = "S030", TinhTrang = "Mới", ViTriKe = "F5-06", NgayNhap = new DateTime(2025, 6, 21), CoSan = true }
            );
            modelBuilder.Entity<PhieuMuon>().HasData(
                new PhieuMuon { PhieuMuonId = 1, MaPhieuMuon = "PM001", MaDocGia = "DG001", QuyenSachId = 1, NgayMuon = new DateTime(2025, 6, 1), NgayTra = new DateTime(2025, 6, 8), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 2, MaPhieuMuon = "PM002", MaDocGia = "DG001", QuyenSachId = 2, NgayMuon = new DateTime(2025, 6, 3), NgayTra = new DateTime(2025, 6, 11), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 3, MaPhieuMuon = "PM003", MaDocGia = "DG001", QuyenSachId = 3, NgayMuon = new DateTime(2025, 6, 6), NgayTra = new DateTime(2025, 6, 14), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 4, MaPhieuMuon = "PM004", MaDocGia = "DG002", QuyenSachId = 4, NgayMuon = new DateTime(2025, 6, 2), NgayTra = new DateTime(2025, 6, 9), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 5, MaPhieuMuon = "PM005", MaDocGia = "DG002", QuyenSachId = 5, NgayMuon = new DateTime(2025, 6, 8), NgayTra = new DateTime(2025, 6, 15), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 6, MaPhieuMuon = "PM006", MaDocGia = "DG002", QuyenSachId = 6, NgayMuon = new DateTime(2025, 6, 12), NgayTra = new DateTime(2025, 6, 20), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 7, MaPhieuMuon = "PM007", MaDocGia = "DG002", QuyenSachId = 7, NgayMuon = new DateTime(2025, 6, 18), NgayTra = new DateTime(2025, 6, 25), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 8, MaPhieuMuon = "PM008", MaDocGia = "DG003", QuyenSachId = 8, NgayMuon = new DateTime(2025, 6, 4), NgayTra = new DateTime(2025, 6, 11), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 9, MaPhieuMuon = "PM009", MaDocGia = "DG003", QuyenSachId = 9, NgayMuon = new DateTime(2025, 6, 16), NgayTra = new DateTime(2025, 6, 23), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 10, MaPhieuMuon = "PM010", MaDocGia = "DG004", QuyenSachId = 10, NgayMuon = new DateTime(2025, 6, 5), NgayTra = new DateTime(2025, 6, 12), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 11, MaPhieuMuon = "PM011", MaDocGia = "DG004", QuyenSachId = 11, NgayMuon = new DateTime(2025, 6, 9), NgayTra = new DateTime(2025, 6, 17), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 12, MaPhieuMuon = "PM012", MaDocGia = "DG004", QuyenSachId = 12, NgayMuon = new DateTime(2025, 6, 14), NgayTra = new DateTime(2025, 6, 22), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 13, MaPhieuMuon = "PM013", MaDocGia = "DG004", QuyenSachId = 13, NgayMuon = new DateTime(2025, 6, 18), NgayTra = new DateTime(2025, 6, 26), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 14, MaPhieuMuon = "PM014", MaDocGia = "DG004", QuyenSachId = 14, NgayMuon = new DateTime(2025, 6, 23), NgayTra = new DateTime(2025, 6, 30), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 15, MaPhieuMuon = "PM015", MaDocGia = "DG005", QuyenSachId = 15, NgayMuon = new DateTime(2025, 6, 7), NgayTra = new DateTime(2025, 6, 15), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 16, MaPhieuMuon = "PM016", MaDocGia = "DG005", QuyenSachId = 16, NgayMuon = new DateTime(2025, 6, 13), NgayTra = new DateTime(2025, 6, 20), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 17, MaPhieuMuon = "PM017", MaDocGia = "DG005", QuyenSachId = 17, NgayMuon = new DateTime(2025, 6, 20), NgayTra = new DateTime(2025, 6, 27), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 18, MaPhieuMuon = "PM018", MaDocGia = "DG006", QuyenSachId = 18, NgayMuon = new DateTime(2025, 6, 10), NgayTra = new DateTime(2025, 6, 18), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 19, MaPhieuMuon = "PM019", MaDocGia = "DG006", QuyenSachId = 19, NgayMuon = new DateTime(2025, 6, 22), NgayTra = new DateTime(2025, 6, 29), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 20, MaPhieuMuon = "PM020", MaDocGia = "DG007", QuyenSachId = 20, NgayMuon = new DateTime(2025, 6, 1), NgayTra = new DateTime(2025, 6, 8), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 21, MaPhieuMuon = "PM021", MaDocGia = "DG007", QuyenSachId = 21, NgayMuon = new DateTime(2025, 6, 6), NgayTra = new DateTime(2025, 6, 14), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 22, MaPhieuMuon = "PM022", MaDocGia = "DG007", QuyenSachId = 22, NgayMuon = new DateTime(2025, 6, 11), NgayTra = new DateTime(2025, 6, 19), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 23, MaPhieuMuon = "PM023", MaDocGia = "DG007", QuyenSachId = 23, NgayMuon = new DateTime(2025, 6, 17), NgayTra = new DateTime(2025, 6, 24), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 24, MaPhieuMuon = "PM024", MaDocGia = "DG007", QuyenSachId = 24, NgayMuon = new DateTime(2025, 6, 22), NgayTra = new DateTime(2025, 6, 29), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 25, MaPhieuMuon = "PM025", MaDocGia = "DG008", QuyenSachId = 25, NgayMuon = new DateTime(2025, 6, 3), NgayTra = new DateTime(2025, 6, 10), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 26, MaPhieuMuon = "PM026", MaDocGia = "DG008", QuyenSachId = 26, NgayMuon = new DateTime(2025, 6, 19), NgayTra = new DateTime(2025, 6, 27), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 27, MaPhieuMuon = "PM027", MaDocGia = "DG009", QuyenSachId = 27, NgayMuon = new DateTime(2025, 6, 5), NgayTra = new DateTime(2025, 6, 12), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 28, MaPhieuMuon = "PM028", MaDocGia = "DG009", QuyenSachId = 28, NgayMuon = new DateTime(2025, 6, 9), NgayTra = new DateTime(2025, 6, 16), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 29, MaPhieuMuon = "PM029", MaDocGia = "DG009", QuyenSachId = 29, NgayMuon = new DateTime(2025, 6, 15), NgayTra = new DateTime(2025, 6, 22), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 30, MaPhieuMuon = "PM030", MaDocGia = "DG009", QuyenSachId = 30, NgayMuon = new DateTime(2025, 6, 20), NgayTra = new DateTime(2025, 6, 28), TrangThai = "Đã trả" },

                new PhieuMuon { PhieuMuonId = 31, MaPhieuMuon = "PM031", MaDocGia = "DG010", QuyenSachId = 31, NgayMuon = new DateTime(2025, 6, 6), NgayTra = new DateTime(2025, 6, 13), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 32, MaPhieuMuon = "PM032", MaDocGia = "DG010", QuyenSachId = 32, NgayMuon = new DateTime(2025, 6, 12), NgayTra = new DateTime(2025, 6, 19), TrangThai = "Đã trả" },
                new PhieuMuon { PhieuMuonId = 33, MaPhieuMuon = "PM033", MaDocGia = "DG010", QuyenSachId = 33, NgayMuon = new DateTime(2025, 6, 22), NgayTra = new DateTime(2025, 6, 29), TrangThai = "Đã trả" }
            );
            modelBuilder.Entity<PhieuTra>().HasData(
                new PhieuTra { PhieuTraId = 1, MaPhieuTra = "PT001", MaDocGia = "DG001", QuyenSachId = 1, NgayTra = new DateTime(2025, 6, 8), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "Sách sạch sẽ, không hư hỏng" },
                new PhieuTra { PhieuTraId = 2, MaPhieuTra = "PT002", MaDocGia = "DG001", QuyenSachId = 2, NgayTra = new DateTime(2025, 6, 11), TinhTrangSauTra = "Cũ", TienPhat = 5000, GhiChu = "Trang bìa hơi quăn" },
                new PhieuTra { PhieuTraId = 3, MaPhieuTra = "PT003", MaDocGia = "DG001", QuyenSachId = 3, NgayTra = new DateTime(2025, 6, 14), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },

                new PhieuTra { PhieuTraId = 4, MaPhieuTra = "PT004", MaDocGia = "DG002", QuyenSachId = 4, NgayTra = new DateTime(2025, 6, 9), TinhTrangSauTra = "Cũ", TienPhat = 7000, GhiChu = "Rách nhẹ trang cuối" },
                new PhieuTra { PhieuTraId = 5, MaPhieuTra = "PT005", MaDocGia = "DG002", QuyenSachId = 5, NgayTra = new DateTime(2025, 6, 15), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 6, MaPhieuTra = "PT006", MaDocGia = "DG002", QuyenSachId = 6, NgayTra = new DateTime(2025, 6, 20), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 7, MaPhieuTra = "PT007", MaDocGia = "DG002", QuyenSachId = 7, NgayTra = new DateTime(2025, 6, 25), TinhTrangSauTra = "Cũ", TienPhat = 10000, GhiChu = "Sách ố màu nhẹ, xước gáy" },

                new PhieuTra { PhieuTraId = 8, MaPhieuTra = "PT008", MaDocGia = "DG003", QuyenSachId = 8, NgayTra = new DateTime(2025, 6, 11), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 9, MaPhieuTra = "PT009", MaDocGia = "DG003", QuyenSachId = 9, NgayTra = new DateTime(2025, 6, 23), TinhTrangSauTra = "Cũ", TienPhat = 5000, GhiChu = "Có vết bẩn ở trang giữa" },

                new PhieuTra { PhieuTraId = 10, MaPhieuTra = "PT010", MaDocGia = "DG004", QuyenSachId = 10, NgayTra = new DateTime(2025, 6, 12), TinhTrangSauTra = "Cũ", TienPhat = 4000, GhiChu = "Trang 12 bị gấp góc" },
                new PhieuTra { PhieuTraId = 11, MaPhieuTra = "PT011", MaDocGia = "DG004", QuyenSachId = 11, NgayTra = new DateTime(2025, 6, 17), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 12, MaPhieuTra = "PT012", MaDocGia = "DG004", QuyenSachId = 12, NgayTra = new DateTime(2025, 6, 22), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 13, MaPhieuTra = "PT013", MaDocGia = "DG004", QuyenSachId = 13, NgayTra = new DateTime(2025, 6, 26), TinhTrangSauTra = "Cũ", TienPhat = 6000, GhiChu = "Sách cũ nhiều chỗ" },
                new PhieuTra { PhieuTraId = 14, MaPhieuTra = "PT014", MaDocGia = "DG004", QuyenSachId = 14, NgayTra = new DateTime(2025, 6, 30), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },

                new PhieuTra { PhieuTraId = 15, MaPhieuTra = "PT015", MaDocGia = "DG005", QuyenSachId = 15, NgayTra = new DateTime(2025, 6, 15), TinhTrangSauTra = "Cũ", TienPhat = 3000, GhiChu = "Mực lem nhẹ" },
                new PhieuTra { PhieuTraId = 16, MaPhieuTra = "PT016", MaDocGia = "DG005", QuyenSachId = 16, NgayTra = new DateTime(2025, 6, 20), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 17, MaPhieuTra = "PT017", MaDocGia = "DG005", QuyenSachId = 17, NgayTra = new DateTime(2025, 6, 27), TinhTrangSauTra = "Cũ", TienPhat = 8000, GhiChu = "Sách bong gáy" },

                new PhieuTra { PhieuTraId = 18, MaPhieuTra = "PT018", MaDocGia = "DG006", QuyenSachId = 18, NgayTra = new DateTime(2025, 6, 18), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 19, MaPhieuTra = "PT019", MaDocGia = "DG006", QuyenSachId = 19, NgayTra = new DateTime(2025, 6, 29), TinhTrangSauTra = "Cũ", TienPhat = 3000, GhiChu = "Trang đầu có vết bút chì" },

                new PhieuTra { PhieuTraId = 20, MaPhieuTra = "PT020", MaDocGia = "DG007", QuyenSachId = 20, NgayTra = new DateTime(2025, 6, 8), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 21, MaPhieuTra = "PT021", MaDocGia = "DG007", QuyenSachId = 21, NgayTra = new DateTime(2025, 6, 14), TinhTrangSauTra = "Cũ", TienPhat = 4000, GhiChu = "Sách xước nhẹ gáy" },
                new PhieuTra { PhieuTraId = 22, MaPhieuTra = "PT022", MaDocGia = "DG007", QuyenSachId = 22, NgayTra = new DateTime(2025, 6, 19), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 23, MaPhieuTra = "PT023", MaDocGia = "DG007", QuyenSachId = 23, NgayTra = new DateTime(2025, 6, 24), TinhTrangSauTra = "Cũ", TienPhat = 3000, GhiChu = "Có vết gạch nhỏ ở trang giữa" },
                new PhieuTra { PhieuTraId = 24, MaPhieuTra = "PT024", MaDocGia = "DG007", QuyenSachId = 24, NgayTra = new DateTime(2025, 6, 29), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },

                new PhieuTra { PhieuTraId = 25, MaPhieuTra = "PT025", MaDocGia = "DG008", QuyenSachId = 25, NgayTra = new DateTime(2025, 6, 10), TinhTrangSauTra = "Cũ", TienPhat = 5000, GhiChu = "Màu trang bị ngả" },
                new PhieuTra { PhieuTraId = 26, MaPhieuTra = "PT026", MaDocGia = "DG008", QuyenSachId = 26, NgayTra = new DateTime(2025, 6, 27), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },

                new PhieuTra { PhieuTraId = 27, MaPhieuTra = "PT027", MaDocGia = "DG009", QuyenSachId = 27, NgayTra = new DateTime(2025, 6, 12), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 28, MaPhieuTra = "PT028", MaDocGia = "DG009", QuyenSachId = 28, NgayTra = new DateTime(2025, 6, 16), TinhTrangSauTra = "Cũ", TienPhat = 4000, GhiChu = "Góc sách bị gập" },
                new PhieuTra { PhieuTraId = 29, MaPhieuTra = "PT029", MaDocGia = "DG009", QuyenSachId = 29, NgayTra = new DateTime(2025, 6, 22), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 30, MaPhieuTra = "PT030", MaDocGia = "DG009", QuyenSachId = 30, NgayTra = new DateTime(2025, 6, 28), TinhTrangSauTra = "Cũ", TienPhat = 6000, GhiChu = "Sách bong gáy, rách nhẹ" },

                new PhieuTra { PhieuTraId = 31, MaPhieuTra = "PT031", MaDocGia = "DG010", QuyenSachId = 31, NgayTra = new DateTime(2025, 6, 13), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" },
                new PhieuTra { PhieuTraId = 32, MaPhieuTra = "PT032", MaDocGia = "DG010", QuyenSachId = 32, NgayTra = new DateTime(2025, 6, 19), TinhTrangSauTra = "Cũ", TienPhat = 4000, GhiChu = "Sách ngả màu" },
                new PhieuTra { PhieuTraId = 33, MaPhieuTra = "PT033", MaDocGia = "DG010", QuyenSachId = 33, NgayTra = new DateTime(2025, 6, 29), TinhTrangSauTra = "Mới", TienPhat = 0, GhiChu = "" }
            );
        }
    }
}
