using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class SomeEntityErrorsSolved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oquv_Reja_Mashgulot_Oquv_Rejalar_Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.DropIndex(
                name: "IX_Oquv_Reja_Mashgulot_Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.DropColumn(
                name: "DifZachot",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Imtihon",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Labaratoriya",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Leksiya",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Seminar",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Zachot",
                table: "Oquv_Rejalar");

            migrationBuilder.DropColumn(
                name: "Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Reja_Mashgulot_OquvRejaId",
                table: "Oquv_Reja_Mashgulot",
                column: "OquvRejaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oquv_Reja_Mashgulot_Oquv_Rejalar_OquvRejaId",
                table: "Oquv_Reja_Mashgulot",
                column: "OquvRejaId",
                principalTable: "Oquv_Rejalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Oquv_Reja_Mashgulot_Oquv_Rejalar_OquvRejaId",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.DropIndex(
                name: "IX_Oquv_Reja_Mashgulot_OquvRejaId",
                table: "Oquv_Reja_Mashgulot");

            migrationBuilder.AddColumn<double>(
                name: "DifZachot",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Imtihon",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Labaratoriya",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Leksiya",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Seminar",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Zachot",
                table: "Oquv_Rejalar",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Reja_Mashgulot_Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot",
                column: "Oquv_RejaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Oquv_Reja_Mashgulot_Oquv_Rejalar_Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot",
                column: "Oquv_RejaId",
                principalTable: "Oquv_Rejalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
