using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quanlythuvien.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuon_PhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuon_Sachs_MaSach",
                table: "ChiTietPhieuMuon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuon",
                newName: "ChiTietPhieuMuons");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuon_PhieuMuonId",
                table: "ChiTietPhieuMuons",
                newName: "IX_ChiTietPhieuMuons_PhieuMuonId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuons",
                newName: "IX_ChiTietPhieuMuons_MaSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuons",
                column: "PhieuMuonId",
                principalTable: "PhieuMuons",
                principalColumn: "MaPhieuMuon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuons_Sachs_MaSach",
                table: "ChiTietPhieuMuons",
                column: "MaSach",
                principalTable: "Sachs",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuons_PhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuMuons_Sachs_MaSach",
                table: "ChiTietPhieuMuons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietPhieuMuons",
                table: "ChiTietPhieuMuons");

            migrationBuilder.RenameTable(
                name: "ChiTietPhieuMuons",
                newName: "ChiTietPhieuMuon");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuon",
                newName: "IX_ChiTietPhieuMuon_PhieuMuonId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietPhieuMuons_MaSach",
                table: "ChiTietPhieuMuon",
                newName: "IX_ChiTietPhieuMuon_MaSach");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietPhieuMuon",
                table: "ChiTietPhieuMuon",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuon_PhieuMuons_PhieuMuonId",
                table: "ChiTietPhieuMuon",
                column: "PhieuMuonId",
                principalTable: "PhieuMuons",
                principalColumn: "MaPhieuMuon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuMuon_Sachs_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach",
                principalTable: "Sachs",
                principalColumn: "MaSach",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
