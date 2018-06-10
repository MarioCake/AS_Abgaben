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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string clientLibrary = System.IO.Path.Combine(Environment.CurrentDirectory, "fbclient.dll");
            FbConnectionStringBuilder builder = new FbConnectionStringBuilder
            {
                Database = "CookieClicker.fdb",
                ClientLibrary = clientLibrary,
                UserID = "sysdba",
                Password = "masterkey",
                ServerType = FbServerType.Embedded,
                Charset = "UTF8"
            };

            FbConnection connection = new FbConnection(builder.ConnectionString);

            optionsBuilder.UseFirebird(connection);

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
