using Microsoft.EntityFrameworkCore;
using HerosDB.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HerosDB
{
    public class HerosContext : DbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }
        public DbSet<SuperVillain> SuperVillains { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!(optionsBuilder.IsConfigured))
            {
                var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("HerosDB");
                optionsBuilder.UseNpgsql(connectionString);
            }
        }
    }
}