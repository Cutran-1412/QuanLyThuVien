using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuTras",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuMuons_MaPhieuMuon",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ChiTietPhieuMuons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuTras",
                table: "ChiTietPhieuTras",
                columns: new[] { "MaPhieuTra", "MaSach" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons",
                columns: new[] { "MaPhieuMuon", "MaSach" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuTras",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ChiTietPhieuTras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "ChiTietPhieuMuons",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuTras",
                table: "ChiTietPhieuTras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "MaPhieuTra");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuons_MaPhieuMuon",
                table: "ChiTietPhieuMuons",
                column: "MaPhieuMuon");
        }
    }
}
