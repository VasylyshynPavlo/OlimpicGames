using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OlimpicDb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStatisticAndPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Statistics_Players_PlayerId",
                table: "Statistics");

            migrationBuilder.DropIndex(
                name: "IX_Statistics_PlayerId",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Statistics");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Statistics",
                newName: "PlaceId");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateTable(
                name: "PlayerStatistic",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    StatisticId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistic", x => new { x.PlayerId, x.StatisticId });
                    table.ForeignKey(
                        name: "FK_PlayerStatistic_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerStatistic_Statistics_StatisticId",
                        column: x => x.StatisticId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "CountryId", "Date", "OlimpicGameId" },
                values: new object[] { 1, "Tokio", 95, "23 July 2021", 0 });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Sport not specified", "NONE" },
                    { 2, "At the Olympic Games, swimming events are held in a pool measuring 50 metres in length. The four strokes of Olympic swimming events—for both individual and relay races—are breaststroke, butterfly, backstroke and front crawl; the front crawl is predominantly used in freestyle races, and as such the term freestyle is often used as a synonym for front crawl. A fifth race, the mixed medley, involves all four strokes, with swimmers switching between them. The distances also vary, with different skills needed for a 50m race to a 1500m event. Explosivity, endurance, strength and technique are all essential qualities for swimmers.", "Swimming" },
                    { 3, "The aim of taekwondo is for an athlete to kick and punch their opponent while avoiding being struck themselves. The trademark of this martial art is its combination of kicking and punching movements in quick succession. Matches are fought on an octagonal mat for three rounds of two minutes each. Points are awarded according to the degree of difficulty of techniques used; for example, a kick to the head scores higher than punches and kicks to the trunk. Spinning kicks are also rewarded with extra points. Penalties may be given to athletes for various faults.", "Taekwondo" },
                    { 4, "Modern athletics is composed of various running, jumping, throwing, walking, and combined events. Due to its many categories and disciplines, athletics involves the most participants in a single sport at the Olympic Games. The track programme includes sprints, middle-distance and long-distance events as well as hurdles, steeplechase races, and relays for men and women. These events take place on the 400m oval track in the Olympic stadium (made up of two straights and two curved bends). Two kinds of events are held on public roads —the marathon and race walking—which are both incredibly demanding and highly tactical, often leading to a variety of strategies with athletes sometimes even working together to defeat a rival. Spectators line the route to watch and cheer the athletes on. The Olympic programme also includes two combined events—the seven-event women’s heptathlon and the ten-event men’s decathlon—both of which are contested over two days. Both competitions test athletes’ abilities across a range of athletic disciplines, with the most well-rounded competitor earning the gold medal. The disciplines are contested on, within, and around the track in the Olympic stadium, in the jumping area (high jump and pole vault), the jumping pit (long jump and triple jump), the throwing circle (shot put, discus and hammer throw), and the javelin runway. Athletes compete one after another, and the event includes a qualifying stage during which the best athletes secure their place in the final.", "Athletics" },
                    { 5, "There are three Olympic shooting disciplines: rifle, pistol and shotgun. Rifle and pistol events take place on shooting ranges, where athletes aim at targets at distances of 10m, 25m and 50m. There are also three positions: kneeling (where the athlete goes down on one knee and rests the elbow on the other knee), prone and standing. Some events include all positions. To hit the targets as accurately and as close to the centre (the bullseye) as possible, marksmen use relaxation techniques to lower their heartbeat. Shotgun events are different in principle, as they take place outdoors. Marksmen shoot at flying targets fired from different angles and directions. This sport demands a great deal of concentration, decision making and sharp reflexes.", "Shooting" },
                    { 6, "The Olympic weightlifting programme has greatly evolved over time. Since the Montreal 1976 Games, there have been two lifts used in competition: the snatch and the clean and jerk. In the snatch, the bar is lifted from the floor to above the head in one movement. By contrast, the clean and jerk is a two-stage action: the bar is first brought up to the shoulders before being jerked over the head. These extremely demanding exercises require exceptional physical strength and ironclad mental resolve. Today, competitors perform both lifts three times, and their best result in each lift are combined to determine their overall score. The competitor with the highest total score is declared the winner. Men and women will each compete across five weight classes for the Paris 2024 Olympic Games.", "Weightlifting" },
                    { 7, "The objective of judo is to throw your opponent to the ground, immobilise them with a pinning hold or force them into submission with a joint lock or choke. There are two types of scores in judo: An ippon is awarded when an athlete throws his opponent to the mat on his or her back with strength, speed and control. An ippon can also be awarded through submission or by pinning an opponent to the ground for 20 seconds. If a judoka achieves ippon, they immediately win the match. A waza-ari is awarded for a throw that isn’t clear enough to be an ippon (either because it lacked speed or force, or the opponent did not land primarily on their back) or when an   opponent is pinned down for less than 20 seconds (but longer than 10 seconds). Two waza‑ari in one match is the equivalent of an ippon and immediately ends the match. Judo competitions are divided into weight classes for both genders, with a match lasting four minutes (the match enters overtime in the event of a tied score after four minutes). Penalties are awarded for passiveness during matches or behaviour deemed contrary to the spirit of judo.", "Judo" },
                    { 8, "", "Artistic Gymnastics" },
                    { 9, "", "Rowing" },
                    { 10, "", "Boxing" },
                    { 11, "", "Wrestling" },
                    { 12, "", "Sailing" },
                    { 13, "", "Fencing" },
                    { 14, "", "Table Tennis" },
                    { 15, "", "Marathon Swimming" },
                    { 16, "", "Canoe Sprint" },
                    { 17, "", "Cycling Road" },
                    { 18, "", "Karate" },
                    { 19, "", "Canoe Slalom" },
                    { 20, "", "Handball" },
                    { 21, "", "Equestrian" },
                    { 22, "", "Hockey" },
                    { 23, "", "Football" },
                    { 24, "", "Rugby Sevens" },
                    { 25, "", "Beach Volleyball" },
                    { 26, "", "Tennis" },
                    { 27, "", "Triathlon" },
                    { 28, "", "Basketball" },
                    { 29, "", "Volleyball" },
                    { 30, "", "Cycling Mountain Bike" },
                    { 31, "", "Golf" },
                    { 32, "", "Cycling BMX Racing" },
                    { 33, "", "Surfing" },
                    { 34, "", "Modern Pentathlon" },
                    { 35, "", "Rhythmic Gymnastics" },
                    { 36, "", "Water Polo" },
                    { 37, "", "Cycling Track" },
                    { 38, "", "Archery" },
                    { 39, "", "Artistic Swimming" },
                    { 40, "", "Badminton" },
                    { 41, "", "Trampoline Gymnastics" },
                    { 42, "", "Baseball/Softball" },
                    { 43, "", "Cycling BMX Freestyle" },
                    { 44, "", "Diving" },
                    { 45, "", "Sport Climbing" },
                    { 46, "", "Skateboarding" },
                    { 47, "", "3x3 Basketball" }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "PlaceId", "SportId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistic_StatisticId",
                table: "PlayerStatistic",
                column: "StatisticId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerStatistic");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "Statistics",
                newName: "PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "Statistics",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Places",
                type: "date",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_PlayerId",
                table: "Statistics",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Statistics_Players_PlayerId",
                table: "Statistics",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
