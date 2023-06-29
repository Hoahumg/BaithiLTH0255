using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaithiLTH0255.Migrations
{
    /// <inheritdoc />
    public partial class LTHCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LTHCau3",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Hoten = table.Column<string>(type: "TEXT", nullable: false),
                    Malop = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LTHCau3", x => x.Masinhvien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LTHCau3");
        }
    }
}
