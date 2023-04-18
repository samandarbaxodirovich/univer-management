using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class kddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chorshanba",
                table: "DarsJadvalllari");

            migrationBuilder.RenameColumn(
                name: "Shanba",
                table: "DarsJadvalllari",
                newName: "uchinchiPara");

            migrationBuilder.RenameColumn(
                name: "Seshanba",
                table: "DarsJadvalllari",
                newName: "birinchiPara");

            migrationBuilder.RenameColumn(
                name: "Payshanba",
                table: "DarsJadvalllari",
                newName: "Tortinchipara");

            migrationBuilder.RenameColumn(
                name: "Juma",
                table: "DarsJadvalllari",
                newName: "IkkinchiPara");

            migrationBuilder.RenameColumn(
                name: "Dushanba",
                table: "DarsJadvalllari",
                newName: "Beshinchipara");

            migrationBuilder.AddColumn<int>(
                name: "KunRaqami",
                table: "DarsJadvalllari",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KunRaqami",
                table: "DarsJadvalllari");

            migrationBuilder.RenameColumn(
                name: "uchinchiPara",
                table: "DarsJadvalllari",
                newName: "Shanba");

            migrationBuilder.RenameColumn(
                name: "birinchiPara",
                table: "DarsJadvalllari",
                newName: "Seshanba");

            migrationBuilder.RenameColumn(
                name: "Tortinchipara",
                table: "DarsJadvalllari",
                newName: "Payshanba");

            migrationBuilder.RenameColumn(
                name: "IkkinchiPara",
                table: "DarsJadvalllari",
                newName: "Juma");

            migrationBuilder.RenameColumn(
                name: "Beshinchipara",
                table: "DarsJadvalllari",
                newName: "Dushanba");

            migrationBuilder.AddColumn<string>(
                name: "Chorshanba",
                table: "DarsJadvalllari",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
