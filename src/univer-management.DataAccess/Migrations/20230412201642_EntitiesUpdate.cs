using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class EntitiesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Semestr",
                table: "Oquv_Rejalar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "MashgulotLength",
                table: "Oquv_Reja_Mashgulot",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Semestr",
                table: "Guruxlar",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Semestr",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "MashgulotLength",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.DropColumn(
                name: "Semestr",
                table: "Guruxlar");
        }
    }
}
