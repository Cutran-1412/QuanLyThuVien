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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
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
                    TienPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                name: "PhieuMuons",
                columns: table => new
                {
                    MaPhieuMuon = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MaDocGia = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuons", x => x.MaPhieuMuon);
                    table.ForeignKey(
                        name: "FK_PhieuMuons_DocGias_MaDocGia",
                        column: x => x.MaDocGia,
                        principalTable: "DocGias",
                        principalColumn: "MaDocGia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhieuMuonId = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    MaSach = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonId",
                        column: x => x.PhieuMuonId,
                        principalTable: "PhieuMuons",
                        principalColumn: "MaPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuons_Sachs_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sachs",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTras",
                columns: table => new
                {
                    MaPhieuTra = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    MaPhieuMuon = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TienPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTras", x => x.MaPhieuTra);
                    table.ForeignKey(
                        name: "FK_PhieuTras_PhieuMuons_MaPhieuMuon",
                        column: x => x.MaPhieuMuon,
                        principalTable: "PhieuMuons",
                        principalColumn: "MaPhieuMuon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Password", "Username" },
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
                    { 10, "2004", "Admin10" }
                });

            migrationBuilder.InsertData(
                table: "DocGias",
                columns: new[] { "MaDocGia", "DiaChi", "Email", "GioiTinh", "HoTen", "NgayDangKy", "NgaySinh", "SoDienThoai", "SoSachMuonToiDa", "TienPhat" },
                values: new object[,]
                {
                    { "DG001", "12 Tràng Tiền, Hà Nội", "nguyenvana@example.com", "Nam", "Nguyễn Văn An", new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", 10, 0m },
                    { "DG002", "45 Lê Lợi, TP.HCM", "tranthib@example.com", "Nữ", "Trần Thị Bình", new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "0934567890", 10, 0m },
                    { "DG003", "99 Phạm Văn Đồng, TP.HCM", "lehoangc@example.com", "Nam", "Lê Hoàng Cường", new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2002, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "0971122334", 10, 0m },
                    { "DG004", "18 Điện Biên Phủ, Hà Nội", "phaminhd@example.com", "Nam", "Phạm Minh Duy", new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0908123456", 10, 0m },
                    { "DG005", "6 Nguyễn Trãi, Hà Nội", "dangthuye@example.com", "Nữ", "Đặng Thùy Huyền", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0369988776", 10, 0m },
                    { "DG006", "150 Hai Bà Trưng, TP.HCM", "voquocf@example.com", "Nam", "Võ Quốc Toàn", new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "0924455667", 10, 0m },
                    { "DG007", "210 Nguyễn Huệ, Huế", "ngoducg@example.com", "Nam", "Ngô Đức Duy", new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1979, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "0919988775", 10, 0m },
                    { "DG008", "34 Trần Hưng Đạo, Nam Định", "buithih@example.com", "Nữ", "Bùi Thị Hằng", new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0988112233", 10, 0m },
                    { "DG009", "8 Lý Thường Kiệt, Đà Nẵng", "trinhgiai@example.com", "Nam", "Trịnh Gia Bảo", new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0955667788", 10, 0m },
                    { "DG010", "35 Nguyễn Văn Cừ, Nha Trang", "hoangmyk@example.com", "Nữ", "Hoàng Mỹ Khánh", new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "0965123456", 10, 0m }
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
                table: "PhieuMuons",
                columns: new[] { "MaPhieuMuon", "MaDocGia", "NgayMuon" },
                values: new object[] { "PM1", "DG001", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "PhieuMuons",
                columns: new[] { "MaPhieuMuon", "MaDocGia", "NgayMuon" },
                values: new object[] { "PM2", "DG001", new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "PhieuTras",
                columns: new[] { "MaPhieuTra", "MaPhieuMuon", "NgayTra", "TienPhat" },
                values: new object[] { "PT001", "PM1", new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m });

            migrationBuilder.InsertData(
                table: "PhieuTras",
                columns: new[] { "MaPhieuTra", "MaPhieuMuon", "NgayTra", "TienPhat" },
                values: new object[] { "PT002", "PM2", new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuons_MaSach",
                table: "ChiTietPhieuMuons",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuons",
                column: "PhieuMuonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuons_MaDocGia",
                table: "PhieuMuons",
                column: "MaDocGia");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTras_MaPhieuMuon",
                table: "PhieuTras",
                column: "MaPhieuMuon");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuons");

            migrationBuilder.DropTable(
                name: "PhieuTras");

            migrationBuilder.DropTable(
                name: "Sachs");

            migrationBuilder.DropTable(
                name: "PhieuMuons");

            migrationBuilder.DropTable(
                name: "DocGias");
        }
    }
}
