using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhieuTras_DocGias_DocGiaMaDocGia",
                table: "PhieuTras");

            migrationBuilder.DropIndex(
                name: "IX_PhieuTras_DocGiaMaDocGia",
                table: "PhieuTras");

            migrationBuilder.DropColumn(
                name: "DocGiaMaDocGia",
                table: "PhieuTras");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DocGiaMaDocGia",
                table: "PhieuTras",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTras_DocGiaMaDocGia",
                table: "PhieuTras",
                column: "DocGiaMaDocGia");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuTras_DocGias_DocGiaMaDocGia",
                table: "PhieuTras",
                column: "DocGiaMaDocGia",
                principalTable: "DocGias",
                principalColumn: "MaDocGia");
        }
    }
}
