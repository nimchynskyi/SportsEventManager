using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsEventManager.Migrations
{
    /// <inheritdoc />
    public partial class EnhanceEventAndTeamModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "VenueId",
                table: "Events",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                newName: "IX_Events_LocationId");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Teams",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Players",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_EventId",
                table: "Teams",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EventId",
                table: "Players",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_LocationId",
                table: "Events",
                column: "LocationId",
                principalTable: "Venues",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Events_EventId",
                table: "Players",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Venues_LocationId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Events_EventId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Events_EventId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_EventId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Players_EventId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Events",
                newName: "VenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_LocationId",
                table: "Events",
                newName: "IX_Events_VenueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Venues_VenueId",
                table: "Events",
                column: "VenueId",
                principalTable: "Venues",
                principalColumn: "Id");
        }
    }
}
