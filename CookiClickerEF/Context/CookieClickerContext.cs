using CookiClickerEF.Models;

using Microsoft.EntityFrameworkCore;
using System;

namespace CookiClickerEF.Context
{
    public class CookieClickerContext : DbContext
    {
        public CookieClickerContext(DbContextOptions<CookieClickerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameStateUpgradeData>()
                .HasKey(model => new { model.UpgradeId, model.GameStateId });

            modelBuilder.Entity<UpgradeData>().HasData(
                new UpgradeData() { Id = 1, Name = "Pointer", FileName = "upgrades/pointer.png", Price = 25, ActiveAddition = 1 },
                new UpgradeData() { Id = 2, Name = "V-Bucks Generator", FileName = "upgrades/vbucks.png", Price = 100, PassiveAddition = 1 },
                new UpgradeData() { Id = 3, Name = "Grandma", FileName = "upgrades/grandma.png", Price = 450, PassiveAddition = 5 }
            );

            modelBuilder.Entity<GameStateData>().HasData(
                new GameStateData() { Id = 1, Money = 0, CreatedAt = DateTime.Now }
            );

        }

        public DbSet<GameStateData> GameStates { get; set; }
        public DbSet<UpgradeData> Upgrades { get; set; }
        public DbSet<GameStateUpgradeData> GameStateUpgrades { get; set; }
    }
}
