using CookiClickerEF.Models;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.EntityFrameworkCore.Firebird.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Context
{
    public class CookieClickerContext : DbContext
    {
        public CookieClickerContext(DbContextOptions<CookieClickerContext> options): base(options)
        {
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
