using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WineRack.Domain.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Wineries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "TastingNotes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BottleVarietals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Bottles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BottleNotes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Wineries");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "TastingNotes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BottleVarietals");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Bottles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BottleNotes");
        }
    }
}
