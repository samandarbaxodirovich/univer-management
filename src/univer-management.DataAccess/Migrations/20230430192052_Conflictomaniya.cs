using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class Conflictomaniya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mashgulotlar",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Ma'ruza" },
                    { 2L, "Amaliy" },
                    { 3L, "Oraliq nazorat" },
                    { 4L, "Mustaqil ta'lim" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mashgulotlar",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Mashgulotlar",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Mashgulotlar",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Mashgulotlar",
                keyColumn: "Id",
                keyValue: 4L);
        }
    }
}
