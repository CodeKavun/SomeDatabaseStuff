using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameDBManager.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreGameInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasMultiplayer",
                table: "Games",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SoldUnits",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasMultiplayer",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "SoldUnits",
                table: "Games");
        }
    }
}
