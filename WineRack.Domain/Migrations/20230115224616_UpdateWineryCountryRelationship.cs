using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineRack.Domain.Migrations
{
    public partial class UpdateWineryCountryRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wineries_Countries_CountryId",
                table: "Wineries");

            migrationBuilder.DropIndex(
                name: "IX_Wineries_CountryId",
                table: "Wineries");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Wineries");

            migrationBuilder.CreateTable(
                name: "WineryCountry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineryId = table.Column<int>(type: "int", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineryCountry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WineryCountry_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WineryCountry_Wineries_WineryId",
                        column: x => x.WineryId,
                        principalTable: "Wineries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WineryCountry_CountryId",
                table: "WineryCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WineryCountry_WineryId",
                table: "WineryCountry",
                column: "WineryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WineryCountry");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Wineries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wineries_CountryId",
                table: "Wineries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wineries_Countries_CountryId",
                table: "Wineries",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
