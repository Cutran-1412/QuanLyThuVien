using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class qltv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DocGias",
                columns: table => new
                {
                    MaDocGia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayDangKy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoSachMuonToiDa = table.Column<int>(type: "int", nullable: false),
                    TienDangKy = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGias", x => x.MaDocGia);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    MaSach = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenSach = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenTacGia = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    TheLoai = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NamPhatHanh = table.Column<int>(type: "int", nullable: false),
                    NhaXuatBan = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.MaSach);
                });

            migrationBuilder.CreateTable(
                name: "QuyenSachs",
                columns: table => new
                {
                    QuyenSachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSach = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ViTriKe = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoSan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyenSachs", x => x.QuyenSachId);
                    table.ForeignKey(
                        name: "FK_QuyenSachs_Sachs_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sachs",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuons",
                columns: table => new
                {
                    PhieuMuonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPhieuMuon = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    QuyenSachId = table.Column<int>(type: "int", nullable: false),
                    MaDocGia = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuons", x => x.PhieuMuonId);
                    table.ForeignKey(
                        name: "FK_PhieuMuons_DocGias_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuMuons_QuyenSachs_QuyenSachId",
                        column: x => x.QuyenSachId,
                        principalTable: "QuyenSachs",
                        principalColumn: "QuyenSachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTras",
                columns: table => new
                {
                    PhieuTraId = table.Column<int>(type: "int", nullable: false),
                    MaPhieuTra = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MaDocGia = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    QuyenSachId = table.Column<int>(type: "int", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TinhTrangSauTra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTras", x => x.PhieuTraId);
                    table.ForeignKey(
                        name: "FK_PhieuTras_DocGias_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuTras_PhieuMuons_PhieuTraId",
                        column: x => x.PhieuTraId,
                        principalTable: "PhieuMuons",
                        principalColumn: "PhieuMuonId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuTras_QuyenSachs_QuyenSachId",
                        column: x => x.QuyenSachId,
                        principalTable: "QuyenSachs",
                        principalColumn: "QuyenSachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "id", "password", "username" },
                values: new object[,]
                {
                    { 1, "2004", "Admin1" },
                    { 2, "2004", "Admin2" },
                    { 3, "2004", "Admin3" },
                    { 4, "2004", "Admin4" },
                    { 5, "2004", "Admin5" },
                    { 6, "2004", "Admin6" },
                    { 7, "2004", "Admin7" },
                    { 8, "2004", "Admin8" },
                    { 9, "2004", "Admin9" },
                    { 10, "2004", "Admin110" }
                });

            migrationBuilder.InsertData(
                table: "DocGias",
                columns: new[] { "MaDocGia", "DiaChi", "Email", "GioiTinh", "HoTen", "NgayDangKy", "NgaySinh", "SoDienThoai", "SoSachMuonToiDa", "TienDangKy" },
                values: new object[,]
                {
                    { "DG001", "12 Tràng Tiền, Hà Nội", "nguyenvana@example.com", "Nam", "Nguyễn Văn An", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", 5, 50000m },
                    { "DG002", "45 Lê Lợi, TP.HCM", "tranthib@example.com", "Nữ", "Trần Thị Bình", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0934567890", 6, 60000m },
                    { "DG003", "99 Phạm Văn Đồng, TP.HCM", "lehoangc@example.com", "Nam", "Lê Hoàng Cường", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0971122334", 4, 55000m },
                    { "DG004", "18 Điện Biên Phủ, Hà Nội", "phaminhd@example.com", "Nam", "Phạm Minh Duy", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0908123456", 5, 100000m },
                    { "DG005", "6 Nguyễn Trãi, Hà Nội", "dangthuye@example.com", "Nữ", "Đặng Thùy Huyền", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0369988776", 5, 45000m },
                    { "DG006", "150 Hai Bà Trưng, TP.HCM", "voquocf@example.com", "Nam", "Võ Quốc Toàn", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0924455667", 7, 70000m },
                    { "DG007", "210 Nguyễn Huệ, Huế", "ngoducg@example.com", "Nam", "Ngô Đức Duy", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919988775", 3, 120000m },
                    { "DG008", "34 Trần Hưng Đạo, Nam Định", "buithih@example.com", "Nữ", "Bùi Thị Hằng", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0988112233", 5, 40000m },
                    { "DG009", "8 Lý Thường Kiệt, Đà Nẵng", "trinhgiai@example.com", "Nam", "Trịnh Gia Bảo", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0955667788", 6, 80000m },
                    { "DG010", "35 Nguyễn Văn Cừ, Nha Trang", "hoangmyk@example.com", "Nữ", "Hoàng Mỹ Khánh", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0965123456", 5, 65000m }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "DonGia", "NamPhatHanh", "NgayNhap", "NhaXuatBan", "SoLuong", "TenSach", "TenTacGia", "TheLoai" },
                values: new object[,]
                {
                    { "S001", 90000m, 2007, new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Kim Đồng", 5, "Dế Mèn Phiêu Lưu Ký", "Tô Hoài", "Thiếu nhi" },
                    { "S002", 75000m, 1950, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 4, "Lão Hạc", "Nam Cao", "Văn học" },
                    { "S003", 150000m, 2011, new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tri Thức", 6, "Sapiens", "Yuval N. Harari", "Khoa học" },
                    { "S004", 95000m, 1981, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 3, "Totto‑Chan Bên Cửa Sổ", "Tetsuko Kuroyanagi", "Thiếu nhi" },
                    { "S005", 120000m, 1936, new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tổng Hợp", 7, "Đắc Nhân Tâm", "Dale Carnegie", "Kỹ năng" },
                    { "S006", 110000m, 1988, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 4, "Nhà Giả Kim", "Paulo Coelho", "Tiểu thuyết" },
                    { "S007", 135000m, 2011, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tri Thức", 6, "Tư Duy Nhanh Và Chậm", "Daniel Kahneman", "Khoa học" },
                    { "S008", 85000m, 1990, new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 5, "Mắt Biếc", "Nguyễn Nhật Ánh", "Tiểu thuyết" },
                    { "S009", 99000m, 2004, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Lao Động", 4, "Bí Mật Của Nước", "Masaru Emoto", "Khoa học" },
                    { "S010", 125000m, 1946, new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Lao Động", 4, "Đi Tìm Lẽ Sống", "Viktor E. Frankl", "Tâm lý" },
                    { "S011", 118000m, 1989, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tổng Hợp", 6, "7 Thói Quen Hiệu Quả", "Stephen R. Covey", "Kỹ năng" },
                    { "S012", 105000m, 2016, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tri Thức", 5, "Cuộc Cách Mạng 4.0", "Klaus Schwab", "Kinh tế" },
                    { "S013", 89000m, 2010, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 3, "Tôi Thấy Hoa Vàng Trên Cỏ Xanh", "Nguyễn Nhật Ánh", "Tiểu thuyết" },
                    { "S014", 95000m, 2014, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Lao Động", 5, "Khéo Ăn Nói...", "Trác Nhã", "Kỹ năng" },
                    { "S015", 99000m, 1813, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 4, "Kiêu Hãnh & Định Kiến", "Jane Austen", "Tiểu thuyết" },
                    { "S016", 140000m, 1892, new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 7, "Sherlock Holmes Tuyển Tập", "Arthur C. Doyle", "Trinh thám" },
                    { "S017", 135000m, 1997, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 6, "Harry Potter 1: Hòn Đá Phù Thủy", "J.K. Rowling", "Fantasy" },
                    { "S018", 108000m, 2016, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tri Thức", 3, "Khi Hơi Thở Hóa Thinh Không", "Paul Kalanithi", "Tự truyện" },
                    { "S019", 78000m, 2015, new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 4, "Cà Phê Cùng Tony", "Tony Buổi Sáng", "Kỹ năng" },
                    { "S020", 145000m, 1943, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 3, "Suối Nguồn", "Ayn Rand", "Tiểu thuyết" },
                    { "S021", 112000m, 2004, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tổng Hợp", 5, "Kỷ Luật Tự Giác", "Stephen R. Covey", "Kỹ năng" },
                    { "S022", 130000m, 1997, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Trẻ", 6, "Cha Giàu Cha Nghèo", "R. T. Kiyosaki", "Kinh tế" }
                });

            migrationBuilder.InsertData(
                table: "Sachs",
                columns: new[] { "MaSach", "DonGia", "NamPhatHanh", "NgayNhap", "NhaXuatBan", "SoLuong", "TenSach", "TenTacGia", "TheLoai" },
                values: new object[,]
                {
                    { "S023", 88000m, 1968, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Lao Động", 4, "Người Bán Hàng Vĩ Đại", "Og Mandino", "Kỹ năng" },
                    { "S024", 118000m, 1969, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 7, "Bố Già", "Mario Puzo", "Tiểu thuyết" },
                    { "S025", 128000m, 1967, new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 5, "Trăm Năm Cô Đơn", "G. G. Márquez", "Tiểu thuyết" },
                    { "S026", 92000m, 1952, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 3, "Ông Già Và Biển Cả", "Ernest Hemingway", "Tiểu thuyết" },
                    { "S027", 104000m, 1949, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 4, "Hoa Nhẫn Thạch", "Yasunari Kawabata", "Tiểu thuyết" },
                    { "S028", 132000m, 2011, new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Tri Thức", 5, "The Lean Startup", "Eric Ries", "Kinh tế" },
                    { "S029", 119000m, 2014, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Lao Động", 4, "Thiên Tài Bên Trái...", "Eric B. T. Lin", "Khoa học" },
                    { "S030", 103000m, 1947, new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "NXB Văn Học", 6, "Nhật Ký Anne Frank", "Anne Frank", "Tự truyện" }
                });

            migrationBuilder.InsertData(
                table: "QuyenSachs",
                columns: new[] { "QuyenSachId", "CoSan", "MaSach", "NgayNhap", "TinhTrang", "ViTriKe" },
                values: new object[,]
                {
                    { 1, true, "S001", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A1-01" },
                    { 2, true, "S001", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A1-02" },
                    { 3, true, "S001", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A1-03" },
                    { 4, true, "S001", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A1-04" },
                    { 5, true, "S001", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A1-05" },
                    { 6, true, "S002", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A2-01" },
                    { 7, true, "S002", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A2-02" },
                    { 8, true, "S002", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A2-03" },
                    { 9, true, "S002", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A2-04" },
                    { 10, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-01" },
                    { 11, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-02" },
                    { 12, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-03" },
                    { 13, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-04" },
                    { 14, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-05" },
                    { 15, true, "S003", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A3-06" },
                    { 16, true, "S004", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A4-01" },
                    { 17, true, "S004", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A4-02" },
                    { 18, true, "S004", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A4-03" },
                    { 19, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-01" },
                    { 20, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-02" },
                    { 21, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-03" },
                    { 22, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-04" },
                    { 23, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-05" },
                    { 24, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-06" },
                    { 25, true, "S005", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "A5-07" },
                    { 26, true, "S006", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B1-01" },
                    { 27, true, "S006", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B1-02" },
                    { 28, true, "S006", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B1-03" },
                    { 29, true, "S006", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B1-04" },
                    { 30, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-01" },
                    { 31, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-02" },
                    { 32, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-03" },
                    { 33, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-04" },
                    { 34, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-05" },
                    { 35, true, "S007", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B2-06" },
                    { 36, true, "S008", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B3-01" },
                    { 37, true, "S008", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B3-02" },
                    { 38, true, "S008", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B3-03" },
                    { 39, true, "S008", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B3-04" },
                    { 40, true, "S008", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B3-05" },
                    { 41, true, "S009", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B4-01" },
                    { 42, true, "S009", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B4-02" }
                });

            migrationBuilder.InsertData(
                table: "QuyenSachs",
                columns: new[] { "QuyenSachId", "CoSan", "MaSach", "NgayNhap", "TinhTrang", "ViTriKe" },
                values: new object[,]
                {
                    { 43, true, "S009", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B4-03" },
                    { 44, true, "S009", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B4-04" },
                    { 45, true, "S010", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B5-01" },
                    { 46, true, "S010", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B5-02" },
                    { 47, true, "S010", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B5-03" },
                    { 48, true, "S010", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "B5-04" },
                    { 49, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-01" },
                    { 50, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-02" },
                    { 51, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-03" },
                    { 52, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-04" },
                    { 53, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-05" },
                    { 54, true, "S011", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C1-06" },
                    { 55, true, "S012", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C2-01" },
                    { 56, true, "S012", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C2-02" },
                    { 57, true, "S012", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C2-03" },
                    { 58, true, "S012", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C2-04" },
                    { 59, true, "S012", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C2-05" },
                    { 60, true, "S013", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C3-01" },
                    { 61, true, "S013", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C3-02" },
                    { 62, true, "S013", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C3-03" },
                    { 63, true, "S014", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C4-01" },
                    { 64, true, "S014", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C4-02" },
                    { 65, true, "S014", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C4-03" },
                    { 66, true, "S014", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C4-04" },
                    { 67, true, "S014", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C4-05" },
                    { 68, true, "S015", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C5-01" },
                    { 69, true, "S015", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C5-02" },
                    { 70, true, "S015", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C5-03" },
                    { 71, true, "S015", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "C5-04" },
                    { 72, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-01" },
                    { 73, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-02" },
                    { 74, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-03" },
                    { 75, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-04" },
                    { 76, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-05" },
                    { 77, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-06" },
                    { 78, true, "S016", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D1-07" },
                    { 79, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-01" },
                    { 80, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-02" },
                    { 81, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-03" },
                    { 82, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-04" },
                    { 83, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-05" },
                    { 84, true, "S017", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D2-06" }
                });

            migrationBuilder.InsertData(
                table: "QuyenSachs",
                columns: new[] { "QuyenSachId", "CoSan", "MaSach", "NgayNhap", "TinhTrang", "ViTriKe" },
                values: new object[,]
                {
                    { 85, true, "S018", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D3-01" },
                    { 86, true, "S018", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D3-02" },
                    { 87, true, "S018", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D3-03" },
                    { 88, true, "S019", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D4-01" },
                    { 89, true, "S019", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D4-02" },
                    { 90, true, "S019", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D4-03" },
                    { 91, true, "S019", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D4-04" },
                    { 92, true, "S020", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D5-01" },
                    { 93, true, "S020", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D5-02" },
                    { 94, true, "S020", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "D5-03" },
                    { 95, true, "S021", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E1-01" },
                    { 96, true, "S021", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E1-02" },
                    { 97, true, "S021", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E1-03" },
                    { 98, true, "S021", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E1-04" },
                    { 99, true, "S021", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E1-05" },
                    { 100, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-01" },
                    { 101, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-02" },
                    { 102, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-03" },
                    { 103, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-04" },
                    { 104, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-05" },
                    { 105, true, "S022", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E2-06" },
                    { 106, true, "S023", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E3-01" },
                    { 107, true, "S023", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E3-02" },
                    { 108, true, "S023", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E3-03" },
                    { 109, true, "S023", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E3-04" },
                    { 110, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-01" },
                    { 111, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-02" },
                    { 112, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-03" },
                    { 113, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-04" },
                    { 114, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-05" },
                    { 115, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-06" },
                    { 116, true, "S024", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E4-07" },
                    { 117, true, "S025", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E5-01" },
                    { 118, true, "S025", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E5-02" },
                    { 119, true, "S025", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E5-03" },
                    { 120, true, "S025", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E5-04" },
                    { 121, true, "S025", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "E5-05" },
                    { 122, true, "S026", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F1-01" },
                    { 123, true, "S026", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F1-02" },
                    { 124, true, "S026", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F1-03" },
                    { 125, true, "S027", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F2-01" },
                    { 126, true, "S027", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F2-02" }
                });

            migrationBuilder.InsertData(
                table: "QuyenSachs",
                columns: new[] { "QuyenSachId", "CoSan", "MaSach", "NgayNhap", "TinhTrang", "ViTriKe" },
                values: new object[,]
                {
                    { 127, true, "S027", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F2-03" },
                    { 128, true, "S027", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F2-04" },
                    { 129, true, "S028", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F3-01" },
                    { 130, true, "S028", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F3-02" },
                    { 131, true, "S028", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F3-03" },
                    { 132, true, "S028", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F3-04" },
                    { 133, true, "S028", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F3-05" },
                    { 134, true, "S029", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F4-01" },
                    { 135, true, "S029", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F4-02" },
                    { 136, true, "S029", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F4-03" },
                    { 137, true, "S029", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F4-04" },
                    { 138, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-01" },
                    { 139, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-02" },
                    { 140, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-03" },
                    { 141, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-04" },
                    { 142, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-05" },
                    { 143, true, "S030", new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mới", "F5-06" }
                });

            migrationBuilder.InsertData(
                table: "PhieuMuons",
                columns: new[] { "PhieuMuonId", "MaDocGia", "MaPhieuMuon", "NgayMuon", "NgayTra", "QuyenSachId", "TrangThai" },
                values: new object[,]
                {
                    { 1, "DG001", "PM001", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Đã trả" },
                    { 2, "DG001", "PM002", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Đã trả" },
                    { 3, "DG001", "PM003", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Đã trả" },
                    { 4, "DG002", "PM004", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Đã trả" },
                    { 5, "DG002", "PM005", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Đã trả" },
                    { 6, "DG002", "PM006", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Đã trả" },
                    { 7, "DG002", "PM007", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Đã trả" },
                    { 8, "DG003", "PM008", new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Đã trả" },
                    { 9, "DG003", "PM009", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Đã trả" },
                    { 10, "DG004", "PM010", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Đã trả" },
                    { 11, "DG004", "PM011", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Đã trả" },
                    { 12, "DG004", "PM012", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Đã trả" },
                    { 13, "DG004", "PM013", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Đã trả" },
                    { 14, "DG004", "PM014", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Đã trả" },
                    { 15, "DG005", "PM015", new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Đã trả" },
                    { 16, "DG005", "PM016", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Đã trả" },
                    { 17, "DG005", "PM017", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Đã trả" },
                    { 18, "DG006", "PM018", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Đã trả" },
                    { 19, "DG006", "PM019", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Đã trả" },
                    { 20, "DG007", "PM020", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Đã trả" },
                    { 21, "DG007", "PM021", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Đã trả" },
                    { 22, "DG007", "PM022", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Đã trả" },
                    { 23, "DG007", "PM023", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Đã trả" },
                    { 24, "DG007", "PM024", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Đã trả" },
                    { 25, "DG008", "PM025", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Đã trả" },
                    { 26, "DG008", "PM026", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "Đã trả" },
                    { 27, "DG009", "PM027", new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Đã trả" },
                    { 28, "DG009", "PM028", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Đã trả" },
                    { 29, "DG009", "PM029", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "Đã trả" },
                    { 30, "DG009", "PM030", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Đã trả" },
                    { 31, "DG010", "PM031", new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Đã trả" },
                    { 32, "DG010", "PM032", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Đã trả" },
                    { 33, "DG010", "PM033", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Đã trả" }
                });

            migrationBuilder.InsertData(
                table: "PhieuTras",
                columns: new[] { "PhieuTraId", "GhiChu", "MaDocGia", "MaPhieuTra", "NgayTra", "QuyenSachId", "TienPhat", "TinhTrangSauTra" },
                values: new object[,]
                {
                    { 1, "Sách sạch sẽ, không hư hỏng", "DG001", "PT001", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0m, "Mới" },
                    { 2, "Trang bìa hơi quăn", "DG001", "PT002", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5000m, "Cũ" },
                    { 3, "", "DG001", "PT003", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0m, "Mới" },
                    { 4, "Rách nhẹ trang cuối", "DG002", "PT004", new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7000m, "Cũ" },
                    { 5, "", "DG002", "PT005", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 0m, "Mới" },
                    { 6, "", "DG002", "PT006", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 0m, "Mới" },
                    { 7, "Sách ố màu nhẹ, xước gáy", "DG002", "PT007", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 10000m, "Cũ" },
                    { 8, "", "DG003", "PT008", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 0m, "Mới" },
                    { 9, "Có vết bẩn ở trang giữa", "DG003", "PT009", new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5000m, "Cũ" },
                    { 10, "Trang 12 bị gấp góc", "DG004", "PT010", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4000m, "Cũ" },
                    { 11, "", "DG004", "PT011", new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0m, "Mới" },
                    { 12, "", "DG004", "PT012", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 0m, "Mới" },
                    { 13, "Sách cũ nhiều chỗ", "DG004", "PT013", new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 6000m, "Cũ" },
                    { 14, "", "DG004", "PT014", new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 0m, "Mới" },
                    { 15, "Mực lem nhẹ", "DG005", "PT015", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3000m, "Cũ" },
                    { 16, "", "DG005", "PT016", new DateTime(2025, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 0m, "Mới" },
                    { 17, "Sách bong gáy", "DG005", "PT017", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 8000m, "Cũ" },
                    { 18, "", "DG006", "PT018", new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 0m, "Mới" },
                    { 19, "Trang đầu có vết bút chì", "DG006", "PT019", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 3000m, "Cũ" },
                    { 20, "", "DG007", "PT020", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 0m, "Mới" },
                    { 21, "Sách xước nhẹ gáy", "DG007", "PT021", new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 4000m, "Cũ" },
                    { 22, "", "DG007", "PT022", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 0m, "Mới" },
                    { 23, "Có vết gạch nhỏ ở trang giữa", "DG007", "PT023", new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 3000m, "Cũ" },
                    { 24, "", "DG007", "PT024", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 0m, "Mới" },
                    { 25, "Màu trang bị ngả", "DG008", "PT025", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 5000m, "Cũ" },
                    { 26, "", "DG008", "PT026", new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 0m, "Mới" },
                    { 27, "", "DG009", "PT027", new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 0m, "Mới" },
                    { 28, "Góc sách bị gập", "DG009", "PT028", new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 4000m, "Cũ" },
                    { 29, "", "DG009", "PT029", new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 0m, "Mới" },
                    { 30, "Sách bong gáy, rách nhẹ", "DG009", "PT030", new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 6000m, "Cũ" },
                    { 31, "", "DG010", "PT031", new DateTime(2025, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 0m, "Mới" },
                    { 32, "Sách ngả màu", "DG010", "PT032", new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 4000m, "Cũ" },
                    { 33, "", "DG010", "PT033", new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 0m, "Mới" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuons_MaDocGia",
                table: "PhieuMuons",
                column: "MaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuons_QuyenSachId",
                table: "PhieuMuons",
                column: "QuyenSachId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTras_MaDocGia",
                table: "PhieuTras",
                column: "MaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTras_QuyenSachId",
                table: "PhieuTras",
                column: "QuyenSachId");

            migrationBuilder.CreateIndex(
                name: "IX_QuyenSachs_MaSach",
                table: "QuyenSachs",
                column: "MaSach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "PhieuTras");

            migrationBuilder.DropTable(
                name: "PhieuMuons");

            migrationBuilder.DropTable(
                name: "DocGias");

            migrationBuilder.DropTable(
                name: "QuyenSachs");

            migrationBuilder.DropTable(
                name: "Sachs");
        }
    }
}
