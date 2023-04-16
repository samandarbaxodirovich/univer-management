﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using univer_management.DataAccess.DbContexts;

#nullable disable

namespace univer_management.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230412203124_SomeEntityErrorsSolved")]
    partial class SomeEntityErrorsSolved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("univer_management.Domain.Entities.Auditoriya", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AuditoriyaTipi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Auditoriya_TipiId")
                        .HasColumnType("bigint");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("NumberOfOrder")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Auditoriya_TipiId");

                    b.ToTable("Auditoriyalar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Auditoriya_Tipi", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Auditoriya_Tiplari");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Fan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("KafedraId")
                        .HasColumnType("bigint");

                    b.Property<double>("Level")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KafedraId");

                    b.ToTable("Fanlar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Gurux", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AuditoriyaId")
                        .HasColumnType("bigint");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("MutaxasislikId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberOfSemester")
                        .HasColumnType("integer");

                    b.Property<int>("Semestr")
                        .HasColumnType("integer");

                    b.Property<int>("Smena")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditoriyaId");

                    b.HasIndex("MutaxasislikId");

                    b.ToTable("Guruxlar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Kafedra", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MutaxasislikId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MutaxasislikId");

                    b.ToTable("Kafedralar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Mashgulot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mashgulotlar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Mutaxasislik", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Mutaxasisliklar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("KafedraId")
                        .HasColumnType("bigint");

                    b.Property<double>("Level")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("KafedraId");

                    b.ToTable("Oqituvchilar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Fan", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("FanId")
                        .HasColumnType("bigint");

                    b.Property<long>("OqituvchiId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FanId");

                    b.HasIndex("OqituvchiId");

                    b.ToTable("Oqituvchi_Fan");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Mutaxasislik", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MutaxasislikId")
                        .HasColumnType("bigint");

                    b.Property<long>("OqituvchiId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MutaxasislikId");

                    b.HasIndex("OqituvchiId");

                    b.ToTable("Oqituvchi_Mutaxasislik");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Rejasi", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ChorshanbaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DushanbaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JumaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("KafedraId")
                        .HasColumnType("bigint");

                    b.Property<long>("OqituvchiId")
                        .HasColumnType("bigint");

                    b.Property<string>("PayshanbaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SeshanbaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShanbaDars")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KafedraId");

                    b.HasIndex("OqituvchiId");

                    b.ToTable("Oqituvchi_Rejasi");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oquv_Reja", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("FanId")
                        .HasColumnType("bigint");

                    b.Property<long>("MutaxasislikId")
                        .HasColumnType("bigint");

                    b.Property<int>("Semestr")
                        .HasColumnType("integer");

                    b.Property<string>("TextUquvReja")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FanId");

                    b.HasIndex("MutaxasislikId");

                    b.ToTable("Oquv_Rejalar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oquv_Reja_Mashgulot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("MashgulotId")
                        .HasColumnType("bigint");

                    b.Property<double>("MashgulotLength")
                        .HasColumnType("double precision");

                    b.Property<long>("OquvRejaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MashgulotId");

                    b.HasIndex("OquvRejaId");

                    b.ToTable("Oquv_Reja_Mashgulot");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Yuklama", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AuditoriyaId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("FanId")
                        .HasColumnType("bigint");

                    b.Property<long>("GuruxId")
                        .HasColumnType("bigint");

                    b.Property<double>("HaftasigaDars")
                        .HasColumnType("double precision");

                    b.Property<long>("MashgulotId")
                        .HasColumnType("bigint");

                    b.Property<long>("OqituvchiId")
                        .HasColumnType("bigint");

                    b.Property<long>("Oquv_RejaId")
                        .HasColumnType("bigint");

                    b.Property<long>("Oquv_Reja_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditoriyaId");

                    b.HasIndex("FanId");

                    b.HasIndex("GuruxId");

                    b.HasIndex("MashgulotId");

                    b.HasIndex("OqituvchiId");

                    b.HasIndex("Oquv_RejaId");

                    b.ToTable("Yuklamalar");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Auditoriya", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Auditoriya_Tipi", "Auditoriya_Tipi")
                        .WithMany()
                        .HasForeignKey("Auditoriya_TipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auditoriya_Tipi");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Fan", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Kafedra", "Kafedra")
                        .WithMany()
                        .HasForeignKey("KafedraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kafedra");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Gurux", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Auditoriya", "Auditoriya")
                        .WithMany()
                        .HasForeignKey("AuditoriyaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Mutaxasislik", "Mutaxasislik")
                        .WithMany()
                        .HasForeignKey("MutaxasislikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auditoriya");

                    b.Navigation("Mutaxasislik");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Kafedra", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Mutaxasislik", "Mutaxasislik")
                        .WithMany()
                        .HasForeignKey("MutaxasislikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mutaxasislik");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Kafedra", "Kafedra")
                        .WithMany()
                        .HasForeignKey("KafedraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kafedra");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Fan", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Fan", "Fan")
                        .WithMany()
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oqituvchi", "Oqituvchi")
                        .WithMany()
                        .HasForeignKey("OqituvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fan");

                    b.Navigation("Oqituvchi");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Mutaxasislik", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Mutaxasislik", "Mutaxasislik")
                        .WithMany()
                        .HasForeignKey("MutaxasislikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oqituvchi", "Oqituvchi")
                        .WithMany()
                        .HasForeignKey("OqituvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mutaxasislik");

                    b.Navigation("Oqituvchi");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oqituvchi_Rejasi", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Kafedra", "Kafedra")
                        .WithMany()
                        .HasForeignKey("KafedraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oqituvchi", "Oqituvchi")
                        .WithMany()
                        .HasForeignKey("OqituvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kafedra");

                    b.Navigation("Oqituvchi");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oquv_Reja", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Fan", "Fan")
                        .WithMany()
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Mutaxasislik", "Mutaxasislik")
                        .WithMany()
                        .HasForeignKey("MutaxasislikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fan");

                    b.Navigation("Mutaxasislik");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Oquv_Reja_Mashgulot", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Mashgulot", "Mashgulot")
                        .WithMany()
                        .HasForeignKey("MashgulotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oquv_Reja", "OquvReja")
                        .WithMany()
                        .HasForeignKey("OquvRejaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mashgulot");

                    b.Navigation("OquvReja");
                });

            modelBuilder.Entity("univer_management.Domain.Entities.Yuklama", b =>
                {
                    b.HasOne("univer_management.Domain.Entities.Auditoriya", "Auditoriya")
                        .WithMany()
                        .HasForeignKey("AuditoriyaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Fan", "Fan")
                        .WithMany()
                        .HasForeignKey("FanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Gurux", "Gurux")
                        .WithMany()
                        .HasForeignKey("GuruxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Mashgulot", "Mashgulot")
                        .WithMany()
                        .HasForeignKey("MashgulotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oqituvchi", "Oqituvchi")
                        .WithMany()
                        .HasForeignKey("OqituvchiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("univer_management.Domain.Entities.Oquv_Reja", "Oquv_Reja")
                        .WithMany()
                        .HasForeignKey("Oquv_RejaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auditoriya");

                    b.Navigation("Fan");

                    b.Navigation("Gurux");

                    b.Navigation("Mashgulot");

                    b.Navigation("Oqituvchi");

                    b.Navigation("Oquv_Reja");
                });
#pragma warning restore 612, 618
        }
    }
}
