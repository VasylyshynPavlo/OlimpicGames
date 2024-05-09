using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlimpicDb.Migrations
{
    /// <inheritdoc />
    public partial class ChangePlayerAndFilterCountryList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalName",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Players");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageLink",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Flag_of_Afghanistan_%282013%E2%80%932021%29.svg/320px-Flag_of_Afghanistan_%282013%E2%80%932021%29.svg.png", "Afghanistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/320px-Flag_of_Albania.svg.png", "Albania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Algeria.svg/320px-Flag_of_Algeria.svg.png", "Algeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Flag_of_American_Samoa.svg/320px-Flag_of_American_Samoa.svg.png", "American Samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Andorra.svg/320px-Flag_of_Andorra.svg.png", "Andorra" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Flag_of_Angola.svg/320px-Flag_of_Angola.svg.png", "Angola" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Antigua_and_Barbuda.svg/320px-Flag_of_Antigua_and_Barbuda.svg.png", "Antigua and Barbuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Flag_of_Argentina.svg/320px-Flag_of_Argentina.svg.png", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Flag_of_Armenia.svg/320px-Flag_of_Armenia.svg.png", "Armenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Aruba.svg/320px-Flag_of_Aruba.svg.png", "Aruba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/b/b9/Flag_of_Australia.svg/320px-Flag_of_Australia.svg.png", "Australia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/320px-Flag_of_Austria.svg.png", "Austria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Azerbaijan.svg/320px-Flag_of_Azerbaijan.svg.png", "Azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Flag_of_the_Bahamas.svg/320px-Flag_of_the_Bahamas.svg.png", "Bahamas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Bahrain.svg/320px-Flag_of_Bahrain.svg.png", "Bahrain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Flag_of_Bangladesh.svg/320px-Flag_of_Bangladesh.svg.png", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Flag_of_Barbados.svg/320px-Flag_of_Barbados.svg.png", "Barbados" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Flag_of_Belarus.svg/320px-Flag_of_Belarus.svg.png", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Belgium_%28civil%29.svg/320px-Flag_of_Belgium_%28civil%29.svg.png", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Flag_of_Belize.svg/320px-Flag_of_Belize.svg.png", "Belize" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Benin.svg/320px-Flag_of_Benin.svg.png", "Benin" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bermuda.svg/320px-Flag_of_Bermuda.svg.png", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Flag_of_Bhutan.svg/320px-Flag_of_Bhutan.svg.png", "Bhutan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Bolivia.svg/320px-Flag_of_Bolivia.svg.png", "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bosnia_and_Herzegovina.svg/320px-Flag_of_Bosnia_and_Herzegovina.svg.png", "Bosnia and Herzegovina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_Botswana.svg/320px-Flag_of_Botswana.svg.png", "Botswana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/320px-Flag_of_Brazil.svg.png", "Brazil" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Flag_of_the_British_Virgin_Islands.svg/320px-Flag_of_the_British_Virgin_Islands.svg.png", "British Virgin Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Brunei.svg/320px-Flag_of_Brunei.svg.png", "Brunei" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Bulgaria.svg/320px-Flag_of_Bulgaria.svg.png", "Bulgaria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Burkina_Faso.svg/320px-Flag_of_Burkina_Faso.svg.png", "Burkina Faso" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Flag_of_Burundi.svg/320px-Flag_of_Burundi.svg.png", "Burundi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_Cambodia.svg/320px-Flag_of_Cambodia.svg.png", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Flag_of_Cameroon.svg/320px-Flag_of_Cameroon.svg.png", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Canada_%28Pantone%29.svg/320px-Flag_of_Canada_%28Pantone%29.svg.png", "Canada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Cape_Verde.svg/320px-Flag_of_Cape_Verde.svg.png", "Cape Verde" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Flag_of_the_Cayman_Islands_%28pre-1999%29.svg/320px-Flag_of_the_Cayman_Islands_%28pre-1999%29.svg.png", "Cayman Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Central_African_Republic.svg/320px-Flag_of_the_Central_African_Republic.svg.png", "Central African Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Flag_of_Chad.svg/320px-Flag_of_Chad.svg.png", "Chad" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Flag_of_Chile.svg/320px-Flag_of_Chile.svg.png", "Chile" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/320px-Flag_of_the_People%27s_Republic_of_China.svg.png", "China" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Colombia.svg/320px-Flag_of_Colombia.svg.png", "Colombia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Flag_of_the_Comoros.svg/320px-Flag_of_the_Comoros.svg.png", "Comoros" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Flag_of_the_Cook_Islands.svg/320px-Flag_of_the_Cook_Islands.svg.png", "Cook Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Flag_of_Costa_Rica.svg/320px-Flag_of_Costa_Rica.svg.png", "Costa Rica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/320px-Flag_of_Croatia.svg.png", "Croatia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Flag_of_Cuba.svg/320px-Flag_of_Cuba.svg.png", "Cuba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Cyprus.svg/320px-Flag_of_Cyprus.svg.png", "Cyprus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_Czech_Republic.svg/320px-Flag_of_the_Czech_Republic.svg.png", "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg/320px-Flag_of_the_Democratic_Republic_of_the_Congo.svg.png", "Democratic Republic of the Congo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Denmark.svg/320px-Flag_of_Denmark.svg.png", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_Djibouti.svg/320px-Flag_of_Djibouti.svg.png", "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Flag_of_Dominica.svg/320px-Flag_of_Dominica.svg.png", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_the_Dominican_Republic.svg/320px-Flag_of_the_Dominican_Republic.svg.png", "Dominican Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Flag_of_East_Timor.svg/320px-Flag_of_East_Timor.svg.png", "East Timor" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Flag_of_Ecuador.svg/320px-Flag_of_Ecuador.svg.png", "Ecuador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Egypt.svg/320px-Flag_of_Egypt.svg.png", "Egypt" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_El_Salvador.svg/320px-Flag_of_El_Salvador.svg.png", "El Salvador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Equatorial_Guinea.svg/320px-Flag_of_Equatorial_Guinea.svg.png", "Equatorial Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Flag_of_Eritrea.svg/320px-Flag_of_Eritrea.svg.png", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flag_of_Estonia.svg/320px-Flag_of_Estonia.svg.png", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Flag_of_Eswatini.svg/320px-Flag_of_Eswatini.svg.png", "Eswatini" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Flag_of_Ethiopia.svg/320px-Flag_of_Ethiopia.svg.png", "Ethiopia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Flag_of_the_Federated_States_of_Micronesia.svg/320px-Flag_of_the_Federated_States_of_Micronesia.svg.png", "Federated States of Micronesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Fiji.svg/320px-Flag_of_Fiji.svg.png", "Fiji" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Finland.svg/320px-Flag_of_Finland.svg.png", "Finland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/320px-Flag_of_France.svg.png", "France" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Flag_of_Gabon.svg/320px-Flag_of_Gabon.svg.png", "Gabon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Georgia.svg/320px-Flag_of_Georgia.svg.png", "Georgia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/320px-Flag_of_Germany.svg.png", "Germany" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Ghana.svg/320px-Flag_of_Ghana.svg.png", "Ghana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/320px-Flag_of_the_United_Kingdom.svg.png", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Greece.svg/320px-Flag_of_Greece.svg.png", "Greece" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Grenada.svg/320px-Flag_of_Grenada.svg.png", "Grenada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Flag_of_Guam.svg/320px-Flag_of_Guam.svg.png", "Guam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Flag_of_Guatemala.svg/320px-Flag_of_Guatemala.svg.png", "Guatemala" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Flag_of_Guinea.svg/320px-Flag_of_Guinea.svg.png", "Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Guinea-Bissau.svg/320px-Flag_of_Guinea-Bissau.svg.png", "Guinea-Bissau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_Guyana.svg/320px-Flag_of_Guyana.svg.png", "Guyana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Haiti.svg/320px-Flag_of_Haiti.svg.png", "Haiti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Flag_of_Honduras_%281949%E2%80%932022%29.svg/320px-Flag_of_Honduras_%281949%E2%80%932022%29.svg.png", "Honduras" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Flag_of_Hong_Kong.svg/320px-Flag_of_Hong_Kong.svg.png", "Hong Kong" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Flag_of_Hungary.svg/320px-Flag_of_Hungary.svg.png", "Hungary" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Iceland.svg/320px-Flag_of_Iceland.svg.png", "Iceland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Flag_of_India.svg/320px-Flag_of_India.svg.png", "India" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Indonesia.svg/320px-Flag_of_Indonesia.svg.png", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Flag_of_Iran.svg/320px-Flag_of_Iran.svg.png", "Iran" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Iraq.svg/320px-Flag_of_Iraq.svg.png", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Flag_of_Ireland.svg/320px-Flag_of_Ireland.svg.png", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png", "Israel" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/320px-Flag_of_Italy.svg.png", "Italy" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg/320px-Flag_of_C%C3%B4te_d%27Ivoire.svg.png", "Ivory Coast" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Jamaica.svg/320px-Flag_of_Jamaica.svg.png", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/320px-Flag_of_Japan.svg.png", "Japan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kazakhstan.svg/320px-Flag_of_Kazakhstan.svg.png", "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Kenya.svg/320px-Flag_of_Kenya.svg.png", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kiribati.svg/320px-Flag_of_Kiribati.svg.png", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Flag_of_Kosovo.svg/320px-Flag_of_Kosovo.svg.png", "Kosovo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Flag_of_Kuwait.svg/320px-Flag_of_Kuwait.svg.png", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg/320px-Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg.png", "Kyrgyzstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Laos.svg/320px-Flag_of_Laos.svg.png", "Laos" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Latvia.svg/320px-Flag_of_Latvia.svg.png", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Flag_of_Lebanon.svg/320px-Flag_of_Lebanon.svg.png", "Lebanon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Flag_of_Lesotho.svg/320px-Flag_of_Lesotho.svg.png", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Flag_of_Liberia.svg/320px-Flag_of_Liberia.svg.png", "Liberia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Libya.svg/320px-Flag_of_Libya.svg.png", "Libya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Flag_of_Liechtenstein.svg/320px-Flag_of_Liechtenstein.svg.png", "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Lithuania.svg/320px-Flag_of_Lithuania.svg.png", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Flag_of_Luxembourg.svg/320px-Flag_of_Luxembourg.svg.png", "Luxembourg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Madagascar.svg/320px-Flag_of_Madagascar.svg.png", "Madagascar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Flag_of_Malawi.svg/320px-Flag_of_Malawi.svg.png", "Malawi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Flag_of_Malaysia.svg/320px-Flag_of_Malaysia.svg.png", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Maldives.svg/320px-Flag_of_Maldives.svg.png", "Maldives" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Mali.svg/320px-Flag_of_Mali.svg.png", "Mali" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Malta.svg/320px-Flag_of_Malta.svg.png", "Malta" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Flag_of_the_Marshall_Islands.svg/320px-Flag_of_the_Marshall_Islands.svg.png", "Marshall Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Flag_of_Mauritania.svg/320px-Flag_of_Mauritania.svg.png", "Mauritania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Mauritius.svg/320px-Flag_of_Mauritius.svg.png", "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Mexico.svg/320px-Flag_of_Mexico.svg.png", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Moldova.svg/320px-Flag_of_Moldova.svg.png", "Moldova" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Flag_of_Monaco.svg/320px-Flag_of_Monaco.svg.png", "Monaco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Flag_of_Mongolia.svg/320px-Flag_of_Mongolia.svg.png", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Montenegro.svg/320px-Flag_of_Montenegro.svg.png", "Montenegro" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Morocco.svg/320px-Flag_of_Morocco.svg.png", "Morocco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Mozambique.svg/320px-Flag_of_Mozambique.svg.png", "Mozambique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Flag_of_Myanmar.svg/320px-Flag_of_Myanmar.svg.png", "Myanmar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Namibia.svg/320px-Flag_of_Namibia.svg.png", "Namibia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Nauru.svg/320px-Flag_of_Nauru.svg.png", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Flag_of_Nepal.svg/320px-Flag_of_Nepal.svg.png", "Nepal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/320px-Flag_of_the_Netherlands.svg.png", "Netherlands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Flag_of_New_Zealand.svg/320px-Flag_of_New_Zealand.svg.png", "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Nicaragua.svg/320px-Flag_of_Nicaragua.svg.png", "Nicaragua" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Flag_of_Niger.svg/320px-Flag_of_Niger.svg.png", "Niger" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_Nigeria.svg/320px-Flag_of_Nigeria.svg.png", "Nigeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_North_Macedonia.svg/320px-Flag_of_North_Macedonia.svg.png", "North Macedonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Norway.svg/320px-Flag_of_Norway.svg.png", "Norway" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Oman.svg/320px-Flag_of_Oman.svg.png", "Oman" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Flag_of_Pakistan.svg/320px-Flag_of_Pakistan.svg.png", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Palau.svg/320px-Flag_of_Palau.svg.png", "Palau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Palestine.svg/320px-Flag_of_Palestine.svg.png", "Palestine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Flag_of_Panama.svg/320px-Flag_of_Panama.svg.png", "Panama" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Flag_of_Papua_New_Guinea.svg/320px-Flag_of_Papua_New_Guinea.svg.png", "Papua New Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Paraguay.svg/320px-Flag_of_Paraguay.svg.png", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Peru.svg/320px-Flag_of_Peru.svg.png", "Peru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_the_Philippines.svg/320px-Flag_of_the_Philippines.svg.png", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Flag_of_Poland.svg/320px-Flag_of_Poland.svg.png", "Poland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Portugal.svg/320px-Flag_of_Portugal.svg.png", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Flag_of_Puerto_Rico.svg/320px-Flag_of_Puerto_Rico.svg.png", "Puerto Rico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Qatar.svg/320px-Flag_of_Qatar.svg.png", "Qatar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Olympic_flag.svg/320px-Olympic_flag.svg.png", "Refugee Olympic Team" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_the_Republic_of_the_Congo.svg/320px-Flag_of_the_Republic_of_the_Congo.svg.png", "Republic of the Congo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Russian_Olympic_Committee_flag.png/320px-Russian_Olympic_Committee_flag.png", "ROC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/320px-Flag_of_Romania.svg.png", "Romania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Rwanda.svg/320px-Flag_of_Rwanda.svg.png", "Rwanda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Saint_Kitts_and_Nevis.svg/320px-Flag_of_Saint_Kitts_and_Nevis.svg.png", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Saint_Lucia.svg/320px-Flag_of_Saint_Lucia.svg.png", "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Flag_of_Saint_Vincent_and_the_Grenadines.svg/320px-Flag_of_Saint_Vincent_and_the_Grenadines.svg.png", "Saint Vincent and the Grenadines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Samoa.svg/320px-Flag_of_Samoa.svg.png", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Flag_of_San_Marino.svg/320px-Flag_of_San_Marino.svg.png", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg/320px-Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg.png", "São Tomé and Príncipe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Flag_of_Saudi_Arabia.svg/320px-Flag_of_Saudi_Arabia.svg.png", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Flag_of_Senegal.svg/320px-Flag_of_Senegal.svg.png", "Senegal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png", "Serbia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Seychelles.svg/320px-Flag_of_Seychelles.svg.png", "Seychelles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Sierra_Leone.svg/320px-Flag_of_Sierra_Leone.svg.png", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Singapore.svg/320px-Flag_of_Singapore.svg.png", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Flag_of_Slovakia.svg/320px-Flag_of_Slovakia.svg.png", "Slovakia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Flag_of_Slovenia.svg/320px-Flag_of_Slovenia.svg.png", "Slovenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Flag_of_the_Solomon_Islands.svg/320px-Flag_of_the_Solomon_Islands.svg.png", "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Flag_of_Somalia.svg/320px-Flag_of_Somalia.svg.png", "Somalia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Flag_of_South_Africa.svg/320px-Flag_of_South_Africa.svg.png", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Flag_of_South_Korea.svg/320px-Flag_of_South_Korea.svg.png", "South Korea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/Flag_of_South_Sudan.svg/320px-Flag_of_South_Sudan.svg.png", "South Sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/320px-Flag_of_Spain.svg.png", "Spain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Sri_Lanka.svg/320px-Flag_of_Sri_Lanka.svg.png", "Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Sudan.svg/320px-Flag_of_Sudan.svg.png", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Flag_of_Suriname.svg/320px-Flag_of_Suriname.svg.png", "Suriname" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Flag_of_Sweden.svg/320px-Flag_of_Sweden.svg.png", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/320px-Flag_of_Switzerland.svg.png", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Flag_of_Syria.svg/320px-Flag_of_Syria.svg.png", "Syria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Tajikistan.svg/320px-Flag_of_Tajikistan.svg.png", "Tajikistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tanzania.svg/320px-Flag_of_Tanzania.svg.png", "Tanzania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Flag_of_Thailand.svg/320px-Flag_of_Thailand.svg.png", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_The_Gambia.svg/320px-Flag_of_The_Gambia.svg.png", "The Gambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Flag_of_Togo.svg/320px-Flag_of_Togo.svg.png", "Togo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Tonga.svg/320px-Flag_of_Tonga.svg.png", "Tonga" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Trinidad_and_Tobago.svg/320px-Flag_of_Trinidad_and_Tobago.svg.png", "Trinidad and Tobago" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Tunisia.svg/320px-Flag_of_Tunisia.svg.png", "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Flag_of_Turkey.svg/320px-Flag_of_Turkey.svg.png", "Turkey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Turkmenistan.svg/320px-Flag_of_Turkmenistan.svg.png", "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tuvalu.svg/320px-Flag_of_Tuvalu.svg.png", "Tuvalu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Flag_of_Uganda.svg/320px-Flag_of_Uganda.svg.png", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/320px-Flag_of_Ukraine.svg.png", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_United_Arab_Emirates.svg/320px-Flag_of_the_United_Arab_Emirates.svg.png", "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/320px-Flag_of_the_United_States.svg.png", "United States" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Uruguay.svg/320px-Flag_of_Uruguay.svg.png", "Uruguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Uzbekistan.svg/320px-Flag_of_Uzbekistan.svg.png", "Uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Vanuatu.svg/320px-Flag_of_Vanuatu.svg.png", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/Flag_of_Venezuela_%28state%29.svg/320px-Flag_of_Venezuela_%28state%29.svg.png", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Vietnam.svg/320px-Flag_of_Vietnam.svg.png", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Flag_of_the_United_States_Virgin_Islands.svg/320px-Flag_of_the_United_States_Virgin_Islands.svg.png", "Virgin Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Yemen.svg/320px-Flag_of_Yemen.svg.png", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Flag_of_Zambia.svg/320px-Flag_of_Zambia.svg.png", "Zambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Flag_of_Zimbabwe.svg/320px-Flag_of_Zimbabwe.svg.png", "Zimbabwe" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageLink",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalName",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/320px-Flag_of_the_United_States.svg.png", "United States" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/320px-Flag_of_Japan.svg.png", "Japan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/b/b9/Flag_of_Australia.svg/320px-Flag_of_Australia.svg.png", "Australia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/b/ba/Flag_of_Germany.svg/320px-Flag_of_Germany.svg.png", "Germany" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/320px-Flag_of_the_People%27s_Republic_of_China.svg.png", "China" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/c/c3/Flag_of_France.svg/320px-Flag_of_France.svg.png", "France" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/0/03/Flag_of_Italy.svg/320px-Flag_of_Italy.svg.png", "Italy" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Canada_%28Pantone%29.svg/320px-Flag_of_Canada_%28Pantone%29.svg.png", "Canada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/320px-Flag_of_the_United_Kingdom.svg.png", "Great Britain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Russian_Olympic_Committee_flag.png/320px-Russian_Olympic_Committee_flag.png", "ROC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/9/9a/Flag_of_Spain.svg/320px-Flag_of_Spain.svg.png", "Spain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/0/05/Flag_of_Brazil.svg/320px-Flag_of_Brazil.svg.png", "Brazil" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/320px-Flag_of_the_Netherlands.svg.png", "Netherlands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/09/Flag_of_South_Korea.svg/320px-Flag_of_South_Korea.svg.png", "South Korea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Flag_of_New_Zealand.svg/320px-Flag_of_New_Zealand.svg.png", "New Zealand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/1/12/Flag_of_Poland.svg/320px-Flag_of_Poland.svg.png", "Poland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Flag_of_Argentina.svg/320px-Flag_of_Argentina.svg.png", "Argentina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/af/Flag_of_South_Africa.svg/320px-Flag_of_South_Africa.svg.png", "South Africa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Flag_of_Hungary.svg/320px-Flag_of_Hungary.svg.png", "Hungary" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Mexico.svg/320px-Flag_of_Mexico.svg.png", "Mexico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/320px-Flag_of_Ukraine.svg.png", "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Flag_of_Sweden.svg/320px-Flag_of_Sweden.svg.png", "Sweden" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Egypt.svg/320px-Flag_of_Egypt.svg.png", "Egypt" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/en/thumb/4/41/Flag_of_India.svg/320px-Flag_of_India.svg.png", "India" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Belgium_%28civil%29.svg/320px-Flag_of_Belgium_%28civil%29.svg.png", "Belgium" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/45/Flag_of_Ireland.svg/320px-Flag_of_Ireland.svg.png", "Ireland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_Czech_Republic.svg/320px-Flag_of_the_Czech_Republic.svg.png", "Czech Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Flag_of_Turkey.svg/320px-Flag_of_Turkey.svg.png", "Turkey" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/320px-Flag_of_Switzerland.svg.png", "Switzerland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Denmark.svg/320px-Flag_of_Denmark.svg.png", "Denmark" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/320px-Flag_of_Romania.svg.png", "Romania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Flag_of_Belarus.svg/320px-Flag_of_Belarus.svg.png", "Belarus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kazakhstan.svg/320px-Flag_of_Kazakhstan.svg.png", "Kazakhstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Portugal.svg/320px-Flag_of_Portugal.svg.png", "Portugal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png", "Israel" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Israel.svg/320px-Flag_of_Israel.svg.png", "Serbia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Kenya.svg/320px-Flag_of_Kenya.svg.png", "Kenya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Greece.svg/320px-Flag_of_Greece.svg.png", "Greece" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Norway.svg/320px-Flag_of_Norway.svg.png", "Norway" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Colombia.svg/320px-Flag_of_Colombia.svg.png", "Colombia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bd/Flag_of_Cuba.svg/320px-Flag_of_Cuba.svg.png", "Cuba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Flag_of_Iran.svg/320px-Flag_of_Iran.svg.png", "Iran" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Uzbekistan.svg/320px-Flag_of_Uzbekistan.svg.png", "Uzbekistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_the_Dominican_Republic.svg/320px-Flag_of_the_Dominican_Republic.svg.png", "Dominican Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Tunisia.svg/320px-Flag_of_Tunisia.svg.png", "Tunisia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/320px-Flag_of_Austria.svg.png", "Austria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_Nigeria.svg/320px-Flag_of_Nigeria.svg.png", "Nigeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/320px-Flag_of_Croatia.svg.png", "Croatia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/78/Flag_of_Chile.svg/320px-Flag_of_Chile.svg.png", "Chile" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Flag_of_Slovenia.svg/320px-Flag_of_Slovenia.svg.png", "Slovenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Jamaica.svg/320px-Flag_of_Jamaica.svg.png", "Jamaica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Morocco.svg/320px-Flag_of_Morocco.svg.png", "Morocco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Flag_of_Ecuador.svg/320px-Flag_of_Ecuador.svg.png", "Ecuador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5b/Flag_of_Hong_Kong.svg/320px-Flag_of_Hong_Kong.svg.png", "Hong Kong" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Finland.svg/320px-Flag_of_Finland.svg.png", "Finland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Algeria.svg/320px-Flag_of_Algeria.svg.png", "Algeria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7b/Flag_of_Venezuela_%28state%29.svg/320px-Flag_of_Venezuela_%28state%29.svg.png", "Venezuela" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Azerbaijan.svg/320px-Flag_of_Azerbaijan.svg.png", "Azerbaijan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/Flag_of_Mongolia.svg/320px-Flag_of_Mongolia.svg.png", "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a9/Flag_of_Thailand.svg/320px-Flag_of_Thailand.svg.png", "Thailand" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Bulgaria.svg/320px-Flag_of_Bulgaria.svg.png", "Bulgaria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Lithuania.svg/320px-Flag_of_Lithuania.svg.png", "Lithuania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Flag_of_Slovakia.svg/320px-Flag_of_Slovakia.svg.png", "Slovakia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Flag_of_Ethiopia.svg/320px-Flag_of_Ethiopia.svg.png", "Ethiopia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/28/Flag_of_Puerto_Rico.svg/320px-Flag_of_Puerto_Rico.svg.png", "Puerto Rico" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Georgia.svg/320px-Flag_of_Georgia.svg.png", "Georgia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cf/Flag_of_Peru.svg/320px-Flag_of_Peru.svg.png", "Peru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Montenegro.svg/320px-Flag_of_Montenegro.svg.png", "Montenegro" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Latvia.svg/320px-Flag_of_Latvia.svg.png", "Latvia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flag_of_Estonia.svg/320px-Flag_of_Estonia.svg.png", "Estonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Bahrain.svg/320px-Flag_of_Bahrain.svg.png", "Bahrain" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Fiji.svg/320px-Flag_of_Fiji.svg.png", "Fiji" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/66/Flag_of_Malaysia.svg/320px-Flag_of_Malaysia.svg.png", "Malaysia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a7/Olympic_flag.svg/320px-Olympic_flag.svg.png", "Refugee Olympic Team" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Flag_of_Saudi_Arabia.svg/320px-Flag_of_Saudi_Arabia.svg.png", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Indonesia.svg/320px-Flag_of_Indonesia.svg.png", "Indonesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_C%C3%B4te_d%27Ivoire.svg/320px-Flag_of_C%C3%B4te_d%27Ivoire.svg.png", "Ivory Coast" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Flag_of_Zambia.svg/320px-Flag_of_Zambia.svg.png", "Zambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4e/Flag_of_Uganda.svg/320px-Flag_of_Uganda.svg.png", "Uganda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ec/Flag_of_Guatemala.svg/320px-Flag_of_Guatemala.svg.png", "Guatemala" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Singapore.svg/320px-Flag_of_Singapore.svg.png", "Singapore" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Flag_of_Honduras_%281949%E2%80%932022%29.svg/320px-Flag_of_Honduras_%281949%E2%80%932022%29.svg.png", "Honduras" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Flag_of_Trinidad_and_Tobago.svg/320px-Flag_of_Trinidad_and_Tobago.svg.png", "Trinidad and Tobago" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9d/Flag_of_Angola.svg/320px-Flag_of_Angola.svg.png", "Angola" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Moldova.svg/320px-Flag_of_Moldova.svg.png", "Moldova" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_the_Philippines.svg/320px-Flag_of_the_Philippines.svg.png", "Philippines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Vietnam.svg/320px-Flag_of_Vietnam.svg.png", "Vietnam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Flag_of_Armenia.svg/320px-Flag_of_Armenia.svg.png", "Armenia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Flag_of_the_Bahamas.svg/320px-Flag_of_the_Bahamas.svg.png", "Bahamas" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg/320px-Flag_of_Kyrgyzstan_%281992%E2%80%932023%29.svg.png", "Kyrgyzstan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Qatar.svg/320px-Flag_of_Qatar.svg.png", "Qatar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Flag_of_Cyprus.svg/320px-Flag_of_Cyprus.svg.png", "Cyprus" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Flag_of_Costa_Rica.svg/320px-Flag_of_Costa_Rica.svg.png", "Costa Rica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Ghana.svg/320px-Flag_of_Ghana.svg.png", "Ghana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_Botswana.svg/320px-Flag_of_Botswana.svg.png", "Botswana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/29/Flag_of_Eritrea.svg/320px-Flag_of_Eritrea.svg.png", "Eritrea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Flag_of_Cameroon.svg/320px-Flag_of_Cameroon.svg.png", "Cameroon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Flag_of_Luxembourg.svg/320px-Flag_of_Luxembourg.svg.png", "Luxembourg" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Flag_of_Kosovo.svg/320px-Flag_of_Kosovo.svg.png", "Kosovo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Flag_of_Kuwait.svg/320px-Flag_of_Kuwait.svg.png", "Kuwait" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Namibia.svg/320px-Flag_of_Namibia.svg.png", "Namibia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Tajikistan.svg/320px-Flag_of_Tajikistan.svg.png", "Tajikistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Uruguay.svg/320px-Flag_of_Uruguay.svg.png", "Uruguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Flag_of_Mozambique.svg/320px-Flag_of_Mozambique.svg.png", "Mozambique" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Flag_of_Pakistan.svg/320px-Flag_of_Pakistan.svg.png", "Pakistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ab/Flag_of_Panama.svg/320px-Flag_of_Panama.svg.png", "Panama" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/320px-Flag_of_Albania.svg.png", "Albania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fd/Flag_of_Senegal.svg/320px-Flag_of_Senegal.svg.png", "Senegal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/11/Flag_of_Sri_Lanka.svg/320px-Flag_of_Sri_Lanka.svg.png", "Sri Lanka" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Turkmenistan.svg/320px-Flag_of_Turkmenistan.svg.png", "Turkmenistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ef/Flag_of_Barbados.svg/320px-Flag_of_Barbados.svg.png", "Barbados" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_Mauritius.svg/320px-Flag_of_Mauritius.svg.png", "Mauritius" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Nicaragua.svg/320px-Flag_of_Nicaragua.svg.png", "Nicaragua" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/79/Flag_of_North_Macedonia.svg/320px-Flag_of_North_Macedonia.svg.png", "North Macedonia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e3/Flag_of_Papua_New_Guinea.svg/320px-Flag_of_Papua_New_Guinea.svg.png", "Papua New Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Paraguay.svg/320px-Flag_of_Paraguay.svg.png", "Paraguay" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Samoa.svg/320px-Flag_of_Samoa.svg.png", "Samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_Benin.svg/320px-Flag_of_Benin.svg.png", "Benin" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bosnia_and_Herzegovina.svg/320px-Flag_of_Bosnia_and_Herzegovina.svg.png", "Bosnia and Herzegovina" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Burkina_Faso.svg/320px-Flag_of_Burkina_Faso.svg.png", "Burkina Faso" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Democratic_Republic_of_the_Congo.svg/320px-Flag_of_the_Democratic_Republic_of_the_Congo.svg.png", "Democratic Republic of the Congo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Flag_of_Guyana.svg/320px-Flag_of_Guyana.svg.png", "Guyana" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f4/Flag_of_Niger.svg/320px-Flag_of_Niger.svg.png", "Niger" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Flag_of_American_Samoa.svg/320px-Flag_of_American_Samoa.svg.png", "American Samoa" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Antigua_and_Barbuda.svg/320px-Flag_of_Antigua_and_Barbuda.svg.png", "Antigua and Barbuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f9/Flag_of_Bangladesh.svg/320px-Flag_of_Bangladesh.svg.png", "Bangladesh" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/50/Flag_of_Burundi.svg/320px-Flag_of_Burundi.svg.png", "Burundi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Cape_Verde.svg/320px-Flag_of_Cape_Verde.svg.png", "Cape Verde" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/35/Flag_of_the_Cook_Islands.svg/320px-Flag_of_the_Cook_Islands.svg.png", "Cook Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Grenada.svg/320px-Flag_of_Grenada.svg.png", "Grenada" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Haiti.svg/320px-Flag_of_Haiti.svg.png", "Haiti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Flag_of_Lebanon.svg/320px-Flag_of_Lebanon.svg.png", "Lebanon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Madagascar.svg/320px-Flag_of_Madagascar.svg.png", "Madagascar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Malta.svg/320px-Flag_of_Malta.svg.png", "Malta" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Flag_of_Monaco.svg/320px-Flag_of_Monaco.svg.png", "Monaco" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Rwanda.svg/320px-Flag_of_Rwanda.svg.png", "Rwanda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Flag_of_Syria.svg/320px-Flag_of_Syria.svg.png", "Syria" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Tonga.svg/320px-Flag_of_Tonga.svg.png", "Tonga" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Flag_of_Afghanistan_%282013%E2%80%932021%29.svg/320px-Flag_of_Afghanistan_%282013%E2%80%932021%29.svg.png", "Afghanistan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Bolivia.svg/320px-Flag_of_Bolivia.svg.png", "Bolivia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/Flag_of_the_Cayman_Islands_%28pre-1999%29.svg/320px-Flag_of_the_Cayman_Islands_%28pre-1999%29.svg.png", "Cayman Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_El_Salvador.svg/320px-Flag_of_El_Salvador.svg.png", "El Salvador" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/Flag_of_Gabon.svg/320px-Flag_of_Gabon.svg.png", "Gabon" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Flag_of_Guam.svg/320px-Flag_of_Guam.svg.png", "Guam" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Flag_of_Guinea.svg/320px-Flag_of_Guinea.svg.png", "Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/47/Flag_of_Liechtenstein.svg/320px-Flag_of_Liechtenstein.svg.png", "Liechtenstein" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Flag_of_Malawi.svg/320px-Flag_of_Malawi.svg.png", "Malawi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9b/Flag_of_Nepal.svg/320px-Flag_of_Nepal.svg.png", "Nepal" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Oman.svg/320px-Flag_of_Oman.svg.png", "Oman" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/00/Flag_of_Palestine.svg/320px-Flag_of_Palestine.svg.png", "Palestine" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Saint_Lucia.svg/320px-Flag_of_Saint_Lucia.svg.png", "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Flag_of_San_Marino.svg/320px-Flag_of_San_Marino.svg.png", "San Marino" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Flag_of_Seychelles.svg/320px-Flag_of_Seychelles.svg.png", "Seychelles" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Sudan.svg/320px-Flag_of_Sudan.svg.png", "Sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_United_Arab_Emirates.svg/320px-Flag_of_the_United_Arab_Emirates.svg.png", "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/89/Flag_of_Yemen.svg/320px-Flag_of_Yemen.svg.png", "Yemen" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6a/Flag_of_Zimbabwe.svg/320px-Flag_of_Zimbabwe.svg.png", "Zimbabwe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/91/Flag_of_Bhutan.svg/320px-Flag_of_Bhutan.svg.png", "Bhutan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/34/Flag_of_Djibouti.svg/320px-Flag_of_Djibouti.svg.png", "Djibouti" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Flag_of_Eswatini.svg/320px-Flag_of_Eswatini.svg.png", "Eswatini" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Flag_of_The_Gambia.svg/320px-Flag_of_The_Gambia.svg.png", "The Gambia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/01/Flag_of_Guinea-Bissau.svg/320px-Flag_of_Guinea-Bissau.svg.png", "Guinea-Bissau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ce/Flag_of_Iceland.svg/320px-Flag_of_Iceland.svg.png", "Iceland" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Iraq.svg/320px-Flag_of_Iraq.svg.png", "Iraq" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Laos.svg/320px-Flag_of_Laos.svg.png", "Laos" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Libya.svg/320px-Flag_of_Libya.svg.png", "Libya" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Maldives.svg/320px-Flag_of_Maldives.svg.png", "Maldives" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_Mali.svg/320px-Flag_of_Mali.svg.png", "Mali" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Sierra_Leone.svg/320px-Flag_of_Sierra_Leone.svg.png", "Sierra Leone" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/68/Flag_of_Togo.svg/320px-Flag_of_Togo.svg.png", "Togo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f8/Flag_of_the_United_States_Virgin_Islands.svg/320px-Flag_of_the_United_States_Virgin_Islands.svg.png", "Virgin Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Flag_of_Aruba.svg/320px-Flag_of_Aruba.svg.png", "Aruba" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e7/Flag_of_Belize.svg/320px-Flag_of_Belize.svg.png", "Belize" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/42/Flag_of_the_British_Virgin_Islands.svg/320px-Flag_of_the_British_Virgin_Islands.svg.png", "British Virgin Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_Cambodia.svg/320px-Flag_of_Cambodia.svg.png", "Cambodia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4b/Flag_of_Chad.svg/320px-Flag_of_Chad.svg.png", "Chad" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Flag_of_the_Comoros.svg/320px-Flag_of_the_Comoros.svg.png", "Comoros" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/26/Flag_of_East_Timor.svg/320px-Flag_of_East_Timor.svg.png", "East Timor" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Flag_of_Equatorial_Guinea.svg/320px-Flag_of_Equatorial_Guinea.svg.png", "Equatorial Guinea" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Flag_of_the_Federated_States_of_Micronesia.svg/320px-Flag_of_the_Federated_States_of_Micronesia.svg.png", "Federated States of Micronesia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d3/Flag_of_Kiribati.svg/320px-Flag_of_Kiribati.svg.png", "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b8/Flag_of_Liberia.svg/320px-Flag_of_Liberia.svg.png", "Liberia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/Flag_of_Myanmar.svg/320px-Flag_of_Myanmar.svg.png", "Myanmar" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/48/Flag_of_Palau.svg/320px-Flag_of_Palau.svg.png", "Palau" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/92/Flag_of_the_Republic_of_the_Congo.svg/320px-Flag_of_the_Republic_of_the_Congo.svg.png", "Republic of the Congo" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6d/Flag_of_Saint_Vincent_and_the_Grenadines.svg/320px-Flag_of_Saint_Vincent_and_the_Grenadines.svg.png", "Saint Vincent and the Grenadines" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0a/Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg/320px-Flag_of_S%C3%A3o_Tom%C3%A9_and_Pr%C3%ADncipe.svg.png", "São Tomé and Príncipe" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Flag_of_the_Solomon_Islands.svg/320px-Flag_of_the_Solomon_Islands.svg.png", "Solomon Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/60/Flag_of_Suriname.svg/320px-Flag_of_Suriname.svg.png", "Suriname" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tanzania.svg/320px-Flag_of_Tanzania.svg.png", "Tanzania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bc/Flag_of_Vanuatu.svg/320px-Flag_of_Vanuatu.svg.png", "Vanuatu" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Flag_of_Andorra.svg/320px-Flag_of_Andorra.svg.png", "Andorra" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bf/Flag_of_Bermuda.svg/320px-Flag_of_Bermuda.svg.png", "Bermuda" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Brunei.svg/320px-Flag_of_Brunei.svg.png", "Brunei" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6f/Flag_of_the_Central_African_Republic.svg/320px-Flag_of_the_Central_African_Republic.svg.png", "Central African Republic" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Flag_of_Dominica.svg/320px-Flag_of_Dominica.svg.png", "Dominica" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Flag_of_Lesotho.svg/320px-Flag_of_Lesotho.svg.png", "Lesotho" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2e/Flag_of_the_Marshall_Islands.svg/320px-Flag_of_the_Marshall_Islands.svg.png", "Marshall Islands" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Flag_of_Mauritania.svg/320px-Flag_of_Mauritania.svg.png", "Mauritania" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/30/Flag_of_Nauru.svg/320px-Flag_of_Nauru.svg.png", "Nauru" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Flag_of_Somalia.svg/320px-Flag_of_Somalia.svg.png", "Somalia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fe/Flag_of_Saint_Kitts_and_Nevis.svg/320px-Flag_of_Saint_Kitts_and_Nevis.svg.png", "Saint Kitts and Nevis" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/Flag_of_South_Sudan.svg/320px-Flag_of_South_Sudan.svg.png", "South Sudan" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CountryFlagLink", "Name" },
                values: new object[] { "https://upload.wikimedia.org/wikipedia/commons/thumb/3/38/Flag_of_Tuvalu.svg/320px-Flag_of_Tuvalu.svg.png", "Tuvalu" });
        }
    }
}
