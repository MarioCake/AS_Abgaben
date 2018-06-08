using CookiClickerEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Context
{
    public class CookieClickerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CookieClicker.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameStateUpgrade>()
                .HasKey(model => new { model.UpgradeId, model.GameStateId });

        }

        public DbSet<GameState> GameStates { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
        public DbSet<GameStateUpgrade> GameStateUpgrades { get; set; }
    }
}
