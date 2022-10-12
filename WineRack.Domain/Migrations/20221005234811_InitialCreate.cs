using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineRack.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BottleNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BottleNote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varietals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrapeVarietal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varietals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegionId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wineries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Winery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wineries_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bottles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineryId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    Vintage = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfBottles = table.Column<int>(type: "int", nullable: false),
                    PurchasePrice = table.Column<float>(type: "real", nullable: false),
                    BottleNoteId = table.Column<int>(type: "int", nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bottle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bottles_BottleNotes_BottleNoteId",
                        column: x => x.BottleNoteId,
                        principalTable: "BottleNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegionBottle",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WineryBottle",
                        column: x => x.WineryId,
                        principalTable: "Wineries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BottleVarietals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BottleId = table.Column<int>(type: "int", nullable: false),
                    VarietalId = table.Column<int>(type: "int", nullable: false),
                    Percentage = table.Column<float>(type: "real", nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BottleVarietal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BottleVarietals_Bottles_BottleId",
                        column: x => x.BottleId,
                        principalTable: "Bottles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BottleVarietals_Varietals_VarietalId",
                        column: x => x.VarietalId,
                        principalTable: "Varietals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TastingNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BottleId = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreatedDt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TastingNoteId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TastingNotes_Bottles_BottleId",
                        column: x => x.BottleId,
                        principalTable: "Bottles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryName" },
                values: new object[,]
                {
                    { 43, "USA" },
                    { 44, "Spain" },
                    { 45, "France" },
                    { 46, "Italy" },
                    { 47, "Germany" },
                    { 48, "South Africa" },
                    { 49, "Australia" },
                    { 50, "Chile" },
                    { 51, "Brazil" }
                });

            migrationBuilder.InsertData(
                table: "Varietals",
                columns: new[] { "Id", "GrapeVarietal" },
                values: new object[,]
                {
                    { 1, "Zinfandel" },
                    { 2, "Cabernet Sauvignon" },
                    { 3, "Merlot" },
                    { 4, "Pinot Noir" },
                    { 5, "Pinot Grigio" },
                    { 6, "Sauvignon Blanc" },
                    { 7, "Chardonnay" },
                    { 8, "Malbec" },
                    { 9, "Carignan(e)" },
                    { 10, "Petit Verdot" },
                    { 11, "Alicante" },
                    { 12, "Baco Noir" },
                    { 13, "Barbera" },
                    { 14, "Cabernet Franc" },
                    { 15, "Cinsault" },
                    { 16, "de Chaunac" },
                    { 17, "Dolcetto" },
                    { 18, "Freisa" },
                    { 19, "Gamay" },
                    { 20, "Gamay Beaujolais" },
                    { 21, "Grenache" },
                    { 22, "Grignolino" },
                    { 23, "Kadarka" },
                    { 24, "Lambrusco" },
                    { 25, "Marechal Foch" },
                    { 26, "Mourvedre" },
                    { 27, "Nebbiolo" },
                    { 28, "Petite Sirah" },
                    { 29, "Pinot Meunier" },
                    { 30, "Pinotage" },
                    { 31, "Primitivo" },
                    { 32, "Ruby Cabarnet" },
                    { 33, "Sangiovese" }
                });

            migrationBuilder.InsertData(
                table: "Varietals",
                columns: new[] { "Id", "GrapeVarietal" },
                values: new object[,]
                {
                    { 34, "Syrah" },
                    { 35, "Tempranillo" },
                    { 36, "Touriga Nacional" },
                    { 37, "Xynomavro" },
                    { 38, "Aglianco" },
                    { 39, "Semillon" },
                    { 40, "Moscato" },
                    { 41, "Gewurztraminer" },
                    { 42, "Riesling" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bottles_BottleNoteId",
                table: "Bottles",
                column: "BottleNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Bottles_RegionId",
                table: "Bottles",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bottles_WineryId",
                table: "Bottles",
                column: "WineryId");

            migrationBuilder.CreateIndex(
                name: "IX_BottleVarietals_BottleId",
                table: "BottleVarietals",
                column: "BottleId");

            migrationBuilder.CreateIndex(
                name: "IX_BottleVarietals_VarietalId",
                table: "BottleVarietals",
                column: "VarietalId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TastingNotes_BottleId",
                table: "TastingNotes",
                column: "BottleId");

            migrationBuilder.CreateIndex(
                name: "IX_Wineries_CountryId",
                table: "Wineries",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BottleVarietals");

            migrationBuilder.DropTable(
                name: "TastingNotes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Varietals");

            migrationBuilder.DropTable(
                name: "Bottles");

            migrationBuilder.DropTable(
                name: "BottleNotes");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Wineries");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
