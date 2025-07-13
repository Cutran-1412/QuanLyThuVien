
﻿using System;
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
            String sqlcu = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=Quanlythuvien;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
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
        private void Seed_DocGia(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocGia>().HasData(
                new DocGia { MaDocGia = "DG001", HoTen = "Nguyễn Văn An", GioiTinh = "Nam", NgaySinh = new DateTime(1995, 3, 15), SoDienThoai = "0912345678", Email = "nguyenvana@example.com", DiaChi = "12 Tràng Tiền, Hà Nội", NgayDangKy = new DateTime(2025, 1, 5) },
                new DocGia { MaDocGia = "DG002", HoTen = "Trần Thị Bình", GioiTinh = "Nữ", NgaySinh = new DateTime(1998, 9, 20), SoDienThoai = "0934567890", Email = "tranthib@example.com", DiaChi = "45 Lê Lợi, TP.HCM", NgayDangKy = new DateTime(2025, 2, 10)},
                new DocGia { MaDocGia = "DG003", HoTen = "Lê Hoàng Cường", GioiTinh = "Nam", NgaySinh = new DateTime(2002, 7, 7), SoDienThoai = "0971122334", Email = "lehoangc@example.com", DiaChi = "99 Phạm Văn Đồng, TP.HCM", NgayDangKy = new DateTime(2025, 3, 2)},
                new DocGia { MaDocGia = "DG004", HoTen = "Phạm Minh Duy", GioiTinh = "Nam", NgaySinh = new DateTime(1988, 12, 30), SoDienThoai = "0908123456", Email = "phaminhd@example.com", DiaChi = "18 Điện Biên Phủ, Hà Nội", NgayDangKy = new DateTime(2025, 3, 18) },
                new DocGia { MaDocGia = "DG005", HoTen = "Đặng Thùy Huyền", GioiTinh = "Nữ", NgaySinh = new DateTime(2000, 1, 11), SoDienThoai = "0369988776", Email = "dangthuye@example.com", DiaChi = "6 Nguyễn Trãi, Hà Nội", NgayDangKy = new DateTime(2025, 4, 1)},
                new DocGia { MaDocGia = "DG006", HoTen = "Võ Quốc Toàn", GioiTinh = "Nam", NgaySinh = new DateTime(1993, 4, 4), SoDienThoai = "0924455667", Email = "voquocf@example.com", DiaChi = "150 Hai Bà Trưng, TP.HCM", NgayDangKy = new DateTime(2025, 4, 20) },
                new DocGia { MaDocGia = "DG007", HoTen = "Ngô Đức Duy", GioiTinh = "Nam", NgaySinh = new DateTime(1979, 11, 5), SoDienThoai = "0919988775", Email = "ngoducg@example.com", DiaChi = "210 Nguyễn Huệ, Huế", NgayDangKy = new DateTime(2025, 5, 2)},
                new DocGia { MaDocGia = "DG008", HoTen = "Bùi Thị Hằng", GioiTinh = "Nữ", NgaySinh = new DateTime(2005, 6, 14), SoDienThoai = "0988112233", Email = "buithih@example.com", DiaChi = "34 Trần Hưng Đạo, Nam Định", NgayDangKy = new DateTime(2025, 5, 28)},
                new DocGia { MaDocGia = "DG009", HoTen = "Trịnh Gia Bảo", GioiTinh = "Nam", NgaySinh = new DateTime(1991, 2, 22), SoDienThoai = "0955667788", Email = "trinhgiai@example.com", DiaChi = "8 Lý Thường Kiệt, Đà Nẵng", NgayDangKy = new DateTime(2025, 6, 10) },
                new DocGia { MaDocGia = "DG010", HoTen = "Hoàng Mỹ Khánh", GioiTinh = "Nữ", NgaySinh = new DateTime(1985, 8, 18), SoDienThoai = "0965123456", Email = "hoangmyk@example.com", DiaChi = "35 Nguyễn Văn Cừ, Nha Trang", NgayDangKy = new DateTime(2025, 6, 25) }
            );
        }
        private void Seed_Sach(ModelBuilder modelBuilder)
        {
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
        }
        private void Seed_PhieuMuon(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuMuon>().HasData(
                new PhieuMuon { MaPhieuMuon = "PM001", MaDocGia = "DG001", NgayMuon = new DateTime(2025, 7, 1), NgayPhaiTra = new DateTime(2025, 7, 10) },
                new PhieuMuon { MaPhieuMuon = "PM002", MaDocGia = "DG002", NgayMuon = new DateTime(2025, 7, 2), NgayPhaiTra = new DateTime(2025, 7, 11) },
                new PhieuMuon { MaPhieuMuon = "PM003", MaDocGia = "DG003", NgayMuon = new DateTime(2025, 7, 3), NgayPhaiTra = new DateTime(2025, 7, 12) },
                new PhieuMuon { MaPhieuMuon = "PM004", MaDocGia = "DG004", NgayMuon = new DateTime(2025, 7, 4), NgayPhaiTra = new DateTime(2025, 7, 13) },
                new PhieuMuon { MaPhieuMuon = "PM005", MaDocGia = "DG005", NgayMuon = new DateTime(2025, 7, 5), NgayPhaiTra = new DateTime(2025, 7, 14) },
                new PhieuMuon { MaPhieuMuon = "PM006", MaDocGia = "DG006", NgayMuon = new DateTime(2025, 7, 6), NgayPhaiTra = new DateTime(2025, 7, 15) },
                new PhieuMuon { MaPhieuMuon = "PM007", MaDocGia = "DG007", NgayMuon = new DateTime(2025, 7, 7), NgayPhaiTra = new DateTime(2025, 7, 16) },
                new PhieuMuon { MaPhieuMuon = "PM008", MaDocGia = "DG008", NgayMuon = new DateTime(2025, 7, 8), NgayPhaiTra = new DateTime(2025, 7, 17) },
                new PhieuMuon { MaPhieuMuon = "PM009", MaDocGia = "DG009", NgayMuon = new DateTime(2025, 7, 9), NgayPhaiTra = new DateTime(2025, 7, 18) },
                new PhieuMuon { MaPhieuMuon = "PM010", MaDocGia = "DG010", NgayMuon = new DateTime(2025, 7, 10), NgayPhaiTra = new DateTime(2025, 7, 19) }
            );
        }
        private void Seed_ChiTietPhieuMuon(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuMuon>().HasData(
                // PM001
                new ChiTietPhieuMuon { MaPhieuMuon = "PM001", MaSach = "S003", SoLuongMuon = 2, SoLuongDaTra = 1 },
                new ChiTietPhieuMuon { MaPhieuMuon = "PM001", MaSach = "S015", SoLuongMuon = 1, SoLuongDaTra = 1 },

                // PM002
                new ChiTietPhieuMuon { MaPhieuMuon = "PM002", MaSach = "S001", SoLuongMuon = 3, SoLuongDaTra = 0 },

                // PM003
                new ChiTietPhieuMuon { MaPhieuMuon = "PM003", MaSach = "S020", SoLuongMuon = 1, SoLuongDaTra = 1 },
                new ChiTietPhieuMuon { MaPhieuMuon = "PM003", MaSach = "S018", SoLuongMuon = 2, SoLuongDaTra = 2 },

                // PM004
                new ChiTietPhieuMuon { MaPhieuMuon = "PM004", MaSach = "S006", SoLuongMuon = 1, SoLuongDaTra = 0 },

                // PM005
                new ChiTietPhieuMuon { MaPhieuMuon = "PM005", MaSach = "S011", SoLuongMuon = 2, SoLuongDaTra = 1 },

                // PM006
                new ChiTietPhieuMuon { MaPhieuMuon = "PM006", MaSach = "S005", SoLuongMuon = 1, SoLuongDaTra = 1 },
                new ChiTietPhieuMuon { MaPhieuMuon = "PM006", MaSach = "S014", SoLuongMuon = 2, SoLuongDaTra = 2 },

                // PM007
                new ChiTietPhieuMuon { MaPhieuMuon = "PM007", MaSach = "S009", SoLuongMuon = 3, SoLuongDaTra = 2 },

                // PM008
                new ChiTietPhieuMuon { MaPhieuMuon = "PM008", MaSach = "S025", SoLuongMuon = 2, SoLuongDaTra = 1 },

                // PM009
                new ChiTietPhieuMuon { MaPhieuMuon = "PM009", MaSach = "S013", SoLuongMuon = 1, SoLuongDaTra = 0 },
                new ChiTietPhieuMuon { MaPhieuMuon = "PM009", MaSach = "S002", SoLuongMuon = 2, SoLuongDaTra = 2 },

                // PM010
                new ChiTietPhieuMuon { MaPhieuMuon = "PM010", MaSach = "S030", SoLuongMuon = 1, SoLuongDaTra = 1 }
            );
        }
        private void Seed_PhieuTra(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhieuTra>().HasData(
                new PhieuTra { MaPhieuTra = "PT001", MaPhieuMuon = "PM001", NgayTra = new DateTime(2025, 7, 10), TienPhat = 0 },
                new PhieuTra { MaPhieuTra = "PT002", MaPhieuMuon = "PM002", NgayTra = new DateTime(2025, 7, 12), TienPhat = 0 },
                new PhieuTra { MaPhieuTra = "PT003", MaPhieuMuon = "PM003", NgayTra = new DateTime(2025, 7, 15), TienPhat = 10000 },
                new PhieuTra { MaPhieuTra = "PT004", MaPhieuMuon = "PM004", NgayTra = new DateTime(2025, 7, 14), TienPhat = 0 },
                new PhieuTra { MaPhieuTra = "PT005", MaPhieuMuon = "PM005", NgayTra = new DateTime(2025, 7, 16), TienPhat = 5000 },
                new PhieuTra { MaPhieuTra = "PT006", MaPhieuMuon = "PM006", NgayTra = new DateTime(2025, 7, 15), TienPhat = 0 },
                new PhieuTra { MaPhieuTra = "PT007", MaPhieuMuon = "PM007", NgayTra = new DateTime(2025, 7, 19), TienPhat = 15000 },
                new PhieuTra { MaPhieuTra = "PT008", MaPhieuMuon = "PM008", NgayTra = new DateTime(2025, 7, 18), TienPhat = 0 },
                new PhieuTra { MaPhieuTra = "PT009", MaPhieuMuon = "PM009", NgayTra = new DateTime(2025, 7, 21), TienPhat = 20000 },
                new PhieuTra { MaPhieuTra = "PT010", MaPhieuMuon = "PM010", NgayTra = new DateTime(2025, 7, 20), TienPhat = 0 }
            );
        }
        private void Seed_ChiTietPhieuTra(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietPhieuTra>().HasData(
                // PT001 → PM001 → S003 (1), S015 (1)
                new ChiTietPhieuTra { MaPhieuTra = "PT001", MaSach = "S003", SoLuong = 1 },
                new ChiTietPhieuTra { MaPhieuTra = "PT001", MaSach = "S015", SoLuong = 1 },

                // PT002 → PM002 → S001 (0) → không tạo

                // PT003 → PM003 → S020 (1), S018 (2)
                new ChiTietPhieuTra { MaPhieuTra = "PT003", MaSach = "S020", SoLuong = 1 },
                new ChiTietPhieuTra { MaPhieuTra = "PT003", MaSach = "S018", SoLuong = 2 },

                // PT004 → PM004 → S006 (0) → không tạo

                // PT005 → PM005 → S011 (1)
                new ChiTietPhieuTra { MaPhieuTra = "PT005", MaSach = "S011", SoLuong = 1 },

                // PT006 → PM006 → S005 (1), S014 (2)
                new ChiTietPhieuTra { MaPhieuTra = "PT006", MaSach = "S005", SoLuong = 1 },
                new ChiTietPhieuTra { MaPhieuTra = "PT006", MaSach = "S014", SoLuong = 2 },

                // PT007 → PM007 → S009 (2)
                new ChiTietPhieuTra { MaPhieuTra = "PT007", MaSach = "S009", SoLuong = 2 },

                // PT008 → PM008 → S025 (1)
                new ChiTietPhieuTra { MaPhieuTra = "PT008", MaSach = "S025", SoLuong = 1 },

                // PT009 → PM009 → S002 (2)
                new ChiTietPhieuTra { MaPhieuTra = "PT009", MaSach = "S002", SoLuong = 2 },

                // PT010 → PM010 → S030 (1)
                new ChiTietPhieuTra { MaPhieuTra = "PT010", MaSach = "S030", SoLuong = 1 }
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed_Admin(modelBuilder);
            Seed_DocGia(modelBuilder);
            Seed_Sach(modelBuilder);
            Seed_PhieuMuon(modelBuilder);
            Seed_ChiTietPhieuMuon(modelBuilder);
            Seed_PhieuTra(modelBuilder);
            Seed_ChiTietPhieuTra(modelBuilder);
            modelBuilder.Entity<ChiTietPhieuMuon>().HasKey(c => new { c.MaPhieuMuon, c.MaSach });
            modelBuilder.Entity<ChiTietPhieuTra>().HasKey(c => new { c.MaPhieuTra, c.MaSach});
        }
    }
}