using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class EditingSomeEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuditoriyaTipi",
                table: "Auditoriyalar");

            migrationBuilder.AddColumn<int>(
                name: "Hafta",
                table: "Oquv_Rejalar",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Soat",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hafta",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Soat",
                table: "Oquv_Rejalar");

            migrationBuilder.AddColumn<string>(
                name: "AuditoriyaTipi",
                table: "Auditoriyalar",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
