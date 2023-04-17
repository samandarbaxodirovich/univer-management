using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class shjklssaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oquv_Reja_Id",
                table: "Yuklamalar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Oquv_Reja_Id",
                table: "Yuklamalar",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
