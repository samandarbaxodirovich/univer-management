using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class DefaultString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Level",
                table: "Oqituvchilar",
                type: "text",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Level",
                table: "Oqituvchilar",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
