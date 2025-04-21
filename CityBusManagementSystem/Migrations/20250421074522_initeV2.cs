using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CityBusManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class initeV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgDrivingLicense",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgDrivingLicense",
                table: "Drivers");
        }
    }
}
