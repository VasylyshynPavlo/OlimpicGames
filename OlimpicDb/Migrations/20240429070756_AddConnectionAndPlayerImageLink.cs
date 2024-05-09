using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlimpicDb.Migrations
{
    /// <inheritdoc />
    public partial class AddConnectionAndPlayerImageLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OlimpicGames_PlaceId",
                table: "OlimpicGames");

            migrationBuilder.AddColumn<string>(
                name: "ImageLink",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OlimpicGameId",
                table: "Places",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Places_CountryId",
                table: "Places",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_OlimpicGames_PlaceId",
                table: "OlimpicGames",
                column: "PlaceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Countries_CountryId",
                table: "Places",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Countries_CountryId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_Places_CountryId",
                table: "Places");

            migrationBuilder.DropIndex(
                name: "IX_OlimpicGames_PlaceId",
                table: "OlimpicGames");

            migrationBuilder.DropColumn(
                name: "ImageLink",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "OlimpicGameId",
                table: "Places");

            migrationBuilder.CreateIndex(
                name: "IX_OlimpicGames_PlaceId",
                table: "OlimpicGames",
                column: "PlaceId");
        }
    }
}
