using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportsEventManager.Migrations
{
    /// <inheritdoc />
    public partial class AddEventPlayerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventPlayers",
                columns: table => new
                {
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    Score = table.Column<decimal>(type: "numeric", nullable: true),
                    Rank = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPlayers", x => new { x.EventId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_EventPlayers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventPlayers_PlayerId",
                table: "EventPlayers",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventPlayers");
        }
    }
}
