using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab2_Weather_API
{
    internal class WeatherDataContex : DbContext
    {
        public DbSet<WeatherData> WeatherDatas { get; set; }
        public WeatherDataContex() 
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=weather.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherData>()
                .ToTable("WeatherDatas"); // Określenie nazwy tabeli

            modelBuilder.Entity<WeatherData>()
                .Property(w => w.Id)
                .ValueGeneratedOnAdd(); // Określenie, że Id jest generowane automatycznie podczas dodawania
        }
    }
}
