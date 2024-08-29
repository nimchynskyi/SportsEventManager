using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsEventManager.Migrations
{
    /// <inheritdoc />
    public partial class UserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCoach",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOrganizer",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPlayer",
                table: "AspNetUsers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCoach",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsOrganizer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPlayer",
                table: "AspNetUsers");
        }
    }
}
