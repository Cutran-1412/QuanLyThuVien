using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuTras_PhieuTras_PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuTras_PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropColumn(
                name: "PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.AlterColumn<string>(
                name: "MaPhieuTra",
                table: "ChiTietPhieuTras",
                type: "nvarchar(12)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "MaPhieuTra");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuTras_PhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "MaPhieuTra",
                principalTable: "PhieuTras",
                principalColumn: "MaPhieuTra",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuTras_PhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietPhieuTras_MaPhieuTra",
                table: "ChiTietPhieuTras");

            migrationBuilder.AlterColumn<string>(
                name: "MaPhieuTra",
                table: "ChiTietPhieuTras",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)");

            migrationBuilder.AddColumn<string>(
                name: "PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras",
                type: "nvarchar(12)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTras_PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "PhieuTraMaPhieuTra");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuTras_PhieuTras_PhieuTraMaPhieuTra",
                table: "ChiTietPhieuTras",
                column: "PhieuTraMaPhieuTra",
                principalTable: "PhieuTras",
                principalColumn: "MaPhieuTra",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
