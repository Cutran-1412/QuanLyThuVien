using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaTra",
                table: "ChiTietPhieuMuons");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "ChiTietPhieuMuons",
                newName: "SoLuongMuon");

            migrationBuilder.AddColumn<int>(
                name: "SoLuongDaTra",
                table: "ChiTietPhieuMuons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongDaTra",
                table: "ChiTietPhieuMuons");

            migrationBuilder.RenameColumn(
                name: "SoLuongMuon",
                table: "ChiTietPhieuMuons",
                newName: "SoLuong");

            migrationBuilder.AddColumn<bool>(
                name: "DaTra",
                table: "ChiTietPhieuMuons",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
