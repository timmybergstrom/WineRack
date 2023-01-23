using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineRack.Domain.Migrations
{
    public partial class UpdateWineryCountryRelationshipFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineryCountry_Countries_CountryId",
                table: "WineryCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_WineryCountry_Wineries_WineryId",
                table: "WineryCountry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineryCountry",
                table: "WineryCountry");

            migrationBuilder.RenameTable(
                name: "WineryCountry",
                newName: "WineryCountries");

            migrationBuilder.RenameIndex(
                name: "IX_WineryCountry_WineryId",
                table: "WineryCountries",
                newName: "IX_WineryCountries_WineryId");

            migrationBuilder.RenameIndex(
                name: "IX_WineryCountry_CountryId",
                table: "WineryCountries",
                newName: "IX_WineryCountries_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineryCountries",
                table: "WineryCountries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WineryCountries_Countries_CountryId",
                table: "WineryCountries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WineryCountries_Wineries_WineryId",
                table: "WineryCountries",
                column: "WineryId",
                principalTable: "Wineries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineryCountries_Countries_CountryId",
                table: "WineryCountries");

            migrationBuilder.DropForeignKey(
                name: "FK_WineryCountries_Wineries_WineryId",
                table: "WineryCountries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineryCountries",
                table: "WineryCountries");

            migrationBuilder.RenameTable(
                name: "WineryCountries",
                newName: "WineryCountry");

            migrationBuilder.RenameIndex(
                name: "IX_WineryCountries_WineryId",
                table: "WineryCountry",
                newName: "IX_WineryCountry_WineryId");

            migrationBuilder.RenameIndex(
                name: "IX_WineryCountries_CountryId",
                table: "WineryCountry",
                newName: "IX_WineryCountry_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineryCountry",
                table: "WineryCountry",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WineryCountry_Countries_CountryId",
                table: "WineryCountry",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WineryCountry_Wineries_WineryId",
                table: "WineryCountry",
                column: "WineryId",
                principalTable: "Wineries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
