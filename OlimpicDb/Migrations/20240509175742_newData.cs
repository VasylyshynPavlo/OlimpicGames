using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlimpicDb.Migrations
{
    /// <inheritdoc />
    public partial class newData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Players_PlayerId",
                table: "PlayerStatistic");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Statistics_StatisticId",
                table: "PlayerStatistic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerStatistic",
                table: "PlayerStatistic");

            migrationBuilder.RenameTable(
                name: "PlayerStatistic",
                newName: "PlayerStatistics");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerStatistic_StatisticId",
                table: "PlayerStatistics",
                newName: "IX_PlayerStatistics_StatisticId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerStatistics",
                table: "PlayerStatistics",
                columns: new[] { "PlayerId", "StatisticId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistics_Players_PlayerId",
                table: "PlayerStatistics",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistics_Statistics_StatisticId",
                table: "PlayerStatistics",
                column: "StatisticId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistics_Players_PlayerId",
                table: "PlayerStatistics");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistics_Statistics_StatisticId",
                table: "PlayerStatistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerStatistics",
                table: "PlayerStatistics");

            migrationBuilder.RenameTable(
                name: "PlayerStatistics",
                newName: "PlayerStatistic");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerStatistics_StatisticId",
                table: "PlayerStatistic",
                newName: "IX_PlayerStatistic_StatisticId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerStatistic",
                table: "PlayerStatistic",
                columns: new[] { "PlayerId", "StatisticId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Players_PlayerId",
                table: "PlayerStatistic",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Statistics_StatisticId",
                table: "PlayerStatistic",
                column: "StatisticId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
