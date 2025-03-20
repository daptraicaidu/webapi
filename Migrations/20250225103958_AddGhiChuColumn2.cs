using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodsAPI2.Migrations
{
    /// <inheritdoc />
    public partial class AddGhiChuColumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "Goods",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "Goods");
        }
    }
}
