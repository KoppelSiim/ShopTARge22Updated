using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopTARge22.Data.Migrations
{
    public partial class TypoFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateAt",
                table: "Kindergartens",
                newName: "CreatedAt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Kindergartens",
                newName: "CreateAt");
        }
    }
}
