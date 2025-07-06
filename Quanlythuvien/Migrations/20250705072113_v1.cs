using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayTra",
                table: "ChiTietPhieuMuons");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayPhaiTra",
                table: "PhieuMuons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuTras",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPhieuTra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhieuTraMaPhieuTra = table.Column<string>(type: "nvarchar(12)", nullable: false),
                    MaSach = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuTras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuTras_PhieuTras_PhieuTraMaPhieuTra",
                        column: x => x.PhieuTraMaPhieuTra,
                        principalTable: "PhieuTras",
                        principalColumn: "MaPhieuTra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuTras_Sachs_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sachs",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTras_MaSach",
                table: "ChiTietPhieuTras",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTras_PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "PhieuTraMaPhieuTra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuTras");

            migrationBuilder.DropColumn(
                name: "NgayPhaiTra",
                table: "PhieuMuons");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTra",
                table: "ChiTietPhieuMuons",
                type: "datetime2",
                nullable: true);
        }
    }
}
