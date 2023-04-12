using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditoriya_Tiplari",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoriya_Tiplari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mashgulotlar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mashgulotlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mutaxasisliklar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutaxasisliklar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auditoriyalar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumberOfOrder = table.Column<string>(type: "text", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    AuditoriyaTipi = table.Column<string>(type: "text", nullable: false),
                    Auditoriya_TipiId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditoriyalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auditoriyalar_Auditoriya_Tiplari_Auditoriya_TipiId",
                        column: x => x.Auditoriya_TipiId,
                        principalTable: "Auditoriya_Tiplari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kafedralar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    MutaxasislikId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kafedralar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kafedralar_Mutaxasisliklar_MutaxasislikId",
                        column: x => x.MutaxasislikId,
                        principalTable: "Mutaxasisliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guruxlar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    NumberOfSemester = table.Column<int>(type: "integer", nullable: false),
                    Smena = table.Column<int>(type: "integer", nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    AuditoriyaId = table.Column<long>(type: "bigint", nullable: false),
                    MutaxasislikId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guruxlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guruxlar_Auditoriyalar_AuditoriyaId",
                        column: x => x.AuditoriyaId,
                        principalTable: "Auditoriyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guruxlar_Mutaxasisliklar_MutaxasislikId",
                        column: x => x.MutaxasislikId,
                        principalTable: "Mutaxasisliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fanlar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    KafedraId = table.Column<long>(type: "bigint", nullable: false),
                    Level = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fanlar_Kafedralar_KafedraId",
                        column: x => x.KafedraId,
                        principalTable: "Kafedralar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oqituvchilar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Level = table.Column<double>(type: "double precision", nullable: false),
                    KafedraId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oqituvchilar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oqituvchilar_Kafedralar_KafedraId",
                        column: x => x.KafedraId,
                        principalTable: "Kafedralar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oquv_Rejalar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FanId = table.Column<long>(type: "bigint", nullable: false),
                    Leksiya = table.Column<double>(type: "double precision", nullable: false),
                    Seminar = table.Column<double>(type: "double precision", nullable: false),
                    Labaratoriya = table.Column<double>(type: "double precision", nullable: false),
                    Zachot = table.Column<double>(type: "double precision", nullable: false),
                    DifZachot = table.Column<double>(type: "double precision", nullable: false),
                    Imtihon = table.Column<double>(type: "double precision", nullable: false),
                    TextUquvReja = table.Column<string>(type: "text", nullable: false),
                    MutaxasislikId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oquv_Rejalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oquv_Rejalar_Fanlar_FanId",
                        column: x => x.FanId,
                        principalTable: "Fanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oquv_Rejalar_Mutaxasisliklar_MutaxasislikId",
                        column: x => x.MutaxasislikId,
                        principalTable: "Mutaxasisliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oqituvchi_Fan",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OqituvchiId = table.Column<long>(type: "bigint", nullable: false),
                    FanId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oqituvchi_Fan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Fan_Fanlar_FanId",
                        column: x => x.FanId,
                        principalTable: "Fanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Fan_Oqituvchilar_OqituvchiId",
                        column: x => x.OqituvchiId,
                        principalTable: "Oqituvchilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oqituvchi_Mutaxasislik",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OqituvchiId = table.Column<long>(type: "bigint", nullable: false),
                    MutaxasislikId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oqituvchi_Mutaxasislik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Mutaxasislik_Mutaxasisliklar_MutaxasislikId",
                        column: x => x.MutaxasislikId,
                        principalTable: "Mutaxasisliklar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Mutaxasislik_Oqituvchilar_OqituvchiId",
                        column: x => x.OqituvchiId,
                        principalTable: "Oqituvchilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oqituvchi_Rejasi",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OqituvchiId = table.Column<long>(type: "bigint", nullable: false),
                    DushanbaDars = table.Column<string>(type: "text", nullable: false),
                    SeshanbaDars = table.Column<string>(type: "text", nullable: false),
                    ChorshanbaDars = table.Column<string>(type: "text", nullable: false),
                    PayshanbaDars = table.Column<string>(type: "text", nullable: false),
                    JumaDars = table.Column<string>(type: "text", nullable: false),
                    ShanbaDars = table.Column<string>(type: "text", nullable: false),
                    KafedraId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oqituvchi_Rejasi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Rejasi_Kafedralar_KafedraId",
                        column: x => x.KafedraId,
                        principalTable: "Kafedralar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oqituvchi_Rejasi_Oqituvchilar_OqituvchiId",
                        column: x => x.OqituvchiId,
                        principalTable: "Oqituvchilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Oquv_Reja_Mashgulot",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OquvRejaId = table.Column<long>(type: "bigint", nullable: false),
                    Oquv_RejaId = table.Column<long>(type: "bigint", nullable: false),
                    MashgulotId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oquv_Reja_Mashgulot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oquv_Reja_Mashgulot_Mashgulotlar_MashgulotId",
                        column: x => x.MashgulotId,
                        principalTable: "Mashgulotlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Oquv_Reja_Mashgulot_Oquv_Rejalar_Oquv_RejaId",
                        column: x => x.Oquv_RejaId,
                        principalTable: "Oquv_Rejalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yuklamalar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GuruxId = table.Column<long>(type: "bigint", nullable: false),
                    FanId = table.Column<long>(type: "bigint", nullable: false),
                    OqituvchiId = table.Column<long>(type: "bigint", nullable: false),
                    Oquv_Reja_Id = table.Column<long>(type: "bigint", nullable: false),
                    Oquv_RejaId = table.Column<long>(type: "bigint", nullable: false),
                    AuditoriyaId = table.Column<long>(type: "bigint", nullable: false),
                    HaftasigaDars = table.Column<double>(type: "double precision", nullable: false),
                    MashgulotId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yuklamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Auditoriyalar_AuditoriyaId",
                        column: x => x.AuditoriyaId,
                        principalTable: "Auditoriyalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Fanlar_FanId",
                        column: x => x.FanId,
                        principalTable: "Fanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Guruxlar_GuruxId",
                        column: x => x.GuruxId,
                        principalTable: "Guruxlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Mashgulotlar_MashgulotId",
                        column: x => x.MashgulotId,
                        principalTable: "Mashgulotlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Oqituvchilar_OqituvchiId",
                        column: x => x.OqituvchiId,
                        principalTable: "Oqituvchilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Yuklamalar_Oquv_Rejalar_Oquv_RejaId",
                        column: x => x.Oquv_RejaId,
                        principalTable: "Oquv_Rejalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auditoriyalar_Auditoriya_TipiId",
                table: "Auditoriyalar",
                column: "Auditoriya_TipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Fanlar_KafedraId",
                table: "Fanlar",
                column: "KafedraId");

            migrationBuilder.CreateIndex(
                name: "IX_Guruxlar_AuditoriyaId",
                table: "Guruxlar",
                column: "AuditoriyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Guruxlar_MutaxasislikId",
                table: "Guruxlar",
                column: "MutaxasislikId");

            migrationBuilder.CreateIndex(
                name: "IX_Kafedralar_MutaxasislikId",
                table: "Kafedralar",
                column: "MutaxasislikId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Fan_FanId",
                table: "Oqituvchi_Fan",
                column: "FanId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Fan_OqituvchiId",
                table: "Oqituvchi_Fan",
                column: "OqituvchiId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Mutaxasislik_MutaxasislikId",
                table: "Oqituvchi_Mutaxasislik",
                column: "MutaxasislikId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Mutaxasislik_OqituvchiId",
                table: "Oqituvchi_Mutaxasislik",
                column: "OqituvchiId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Rejasi_KafedraId",
                table: "Oqituvchi_Rejasi",
                column: "KafedraId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchi_Rejasi_OqituvchiId",
                table: "Oqituvchi_Rejasi",
                column: "OqituvchiId");

            migrationBuilder.CreateIndex(
                name: "IX_Oqituvchilar_KafedraId",
                table: "Oqituvchilar",
                column: "KafedraId");

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Reja_Mashgulot_MashgulotId",
                table: "Oquv_Reja_Mashgulot",
                column: "MashgulotId");

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Reja_Mashgulot_Oquv_RejaId",
                table: "Oquv_Reja_Mashgulot",
                column: "Oquv_RejaId");

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Rejalar_FanId",
                table: "Oquv_Rejalar",
                column: "FanId");

            migrationBuilder.CreateIndex(
                name: "IX_Oquv_Rejalar_MutaxasislikId",
                table: "Oquv_Rejalar",
                column: "MutaxasislikId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_AuditoriyaId",
                table: "Yuklamalar",
                column: "AuditoriyaId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_FanId",
                table: "Yuklamalar",
                column: "FanId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_GuruxId",
                table: "Yuklamalar",
                column: "GuruxId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_MashgulotId",
                table: "Yuklamalar",
                column: "MashgulotId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_OqituvchiId",
                table: "Yuklamalar",
                column: "OqituvchiId");

            migrationBuilder.CreateIndex(
                name: "IX_Yuklamalar_Oquv_RejaId",
                table: "Yuklamalar",
                column: "Oquv_RejaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oqituvchi_Fan");

            migrationBuilder.DropTable(
                name: "Oqituvchi_Mutaxasislik");

            migrationBuilder.DropTable(
                name: "Oqituvchi_Rejasi");

            migrationBuilder.DropTable(
                name: "Oquv_Reja_Mashgulot");

            migrationBuilder.DropTable(
                name: "Yuklamalar");

            migrationBuilder.DropTable(
                name: "Guruxlar");

            migrationBuilder.DropTable(
                name: "Mashgulotlar");

            migrationBuilder.DropTable(
                name: "Oqituvchilar");

            migrationBuilder.DropTable(
                name: "Oquv_Rejalar");

            migrationBuilder.DropTable(
                name: "Auditoriyalar");

            migrationBuilder.DropTable(
                name: "Fanlar");

            migrationBuilder.DropTable(
                name: "Auditoriya_Tiplari");

            migrationBuilder.DropTable(
                name: "Kafedralar");

            migrationBuilder.DropTable(
                name: "Mutaxasisliklar");
        }
    }
}
