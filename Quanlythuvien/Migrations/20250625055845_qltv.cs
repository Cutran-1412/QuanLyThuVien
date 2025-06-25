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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
