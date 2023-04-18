using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DarsJadvalllari",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Dushanba = table.Column<string>(type: "text", nullable: false),
                    Seshanba = table.Column<string>(type: "text", nullable: false),
                    Chorshanba = table.Column<string>(type: "text", nullable: false),
                    Payshanba = table.Column<string>(type: "text", nullable: false),
                    Juma = table.Column<string>(type: "text", nullable: false),
                    Shanba = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DarsJadvalllari", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DarsJadvalllari");
        }
    }
}
