using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlimpicDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAllData_Delete2table_UpdateTableConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlimpicGameSports");

            migrationBuilder.DropTable(
                name: "PlayerSports");

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "OlimpicGames",
                columns: new[] { "Id", "PlaceId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OlimpicGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "OlimpicGameSports",
                columns: table => new
                {
                    OlimpicGameId = table.Column<int>(type: "int", nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlimpicGameSports", x => new { x.OlimpicGameId, x.SportId });
                    table.ForeignKey(
                        name: "FK_OlimpicGameSports_OlimpicGames_OlimpicGameId",
                        column: x => x.OlimpicGameId,
                        principalTable: "OlimpicGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OlimpicGameSports_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerSports",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    SportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSports", x => new { x.PlayerId, x.SportId });
                    table.ForeignKey(
                        name: "FK_PlayerSports_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerSports_Sports_SportId",
                        column: x => x.SportId,
                        principalTable: "Sports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "PlaceId", "SportId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_OlimpicGameSports_SportId",
                table: "OlimpicGameSports",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSports_SportId",
                table: "PlayerSports",
                column: "SportId");
        }
    }
}
