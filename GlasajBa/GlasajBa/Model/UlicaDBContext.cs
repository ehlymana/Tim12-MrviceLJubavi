﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GlasajBa.Model
{
    class UlicaDBContext : DbContext
    {
        public DbSet<Ulica> Ulice { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "GlasajBABaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Kandidat>().Property(p => p.Slika).HasColumnType("image");
        }
    }
}
