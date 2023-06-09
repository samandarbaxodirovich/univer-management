﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univer_management.DataAccess.Configurations;
using univer_management.Domain.Entities;

namespace univer_management.DataAccess.DbContexts
{
    public class AppDbContext:DbContext
    {
        public DbSet<Auditoriya> Auditoriyalar { get; set; } = default!;
        public DbSet<Auditoriya_Tipi> Auditoriya_Tiplari  { get; set; } = default!;
        public DbSet<Fan> Fanlar  { get; set; } = default!;
        public DbSet<Gurux> Guruxlar { get; set; } = default!;
        public DbSet<Kafedra> Kafedralar { get; set;} = default!;
        public DbSet<Mashgulot> Mashgulotlar { get; set; } = default!;
        public DbSet<Mutaxasislik> Mutaxasisliklar { get; set; } = default!;
        public DbSet<Oqituvchi> Oqituvchilar { get;set; } = default!;
        public DbSet<Oqituvchi_Fan> Oqituvchi_Fan { get; set; } = default!;
        public DbSet<Oqituvchi_Mutaxasislik> Oqituvchi_Mutaxasislik { get; set; } = default!;
        public DbSet<Oqituvchi_Rejasi> Oqituvchi_Rejasi { get; set; } = default!;
        public DbSet<Oquv_Reja> Oquv_Rejalar { get; set; } = default!;
        public DbSet<Oquv_Reja_Mashgulot> Oquv_Reja_Mashgulot { get; set; } = default!;
        public DbSet<Yuklama> Yuklamalar { get; set; } = default!;
        public DbSet<DarsJadval> DarsJadvalllari { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql("Host= hansken.db.elephantsql.com; Port=5432; Database=unmwgzfo; User Id = unmwgzfo; Password= 8rpCkvQs9-L-TNtHp98CTs4kj8CmZYs4;");
            optionsBuilder.UseNpgsql("host=localhost; Port=5432; Database=univer-managemet; User Id = postgres; Password= bigchange");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new MashgulotConfiguration());
        }

    }
}
