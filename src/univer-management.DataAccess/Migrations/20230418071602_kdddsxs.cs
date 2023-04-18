using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class kdddsxs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uchinchiPara",
                table: "DarsJadvalllari",
                newName: "sehanba");

            migrationBuilder.RenameColumn(
                name: "birinchiPara",
                table: "DarsJadvalllari",
                newName: "payshanba");

            migrationBuilder.RenameColumn(
                name: "Tortinchipara",
                table: "DarsJadvalllari",
                newName: "Shanba");

            migrationBuilder.RenameColumn(
                name: "KunRaqami",
                table: "DarsJadvalllari",
                newName: "paraRaqami");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chorshanba",
                table: "DarsJadvalllari");

            migrationBuilder.RenameColumn(
                name: "sehanba",
                table: "DarsJadvalllari",
                newName: "uchinchiPara");

            migrationBuilder.RenameColumn(
                name: "payshanba",
                table: "DarsJadvalllari",
                newName: "birinchiPara");

            migrationBuilder.RenameColumn(
                name: "paraRaqami",
                table: "DarsJadvalllari",
                newName: "KunRaqami");

            migrationBuilder.RenameColumn(
                name: "Shanba",
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
        }
    }
}
