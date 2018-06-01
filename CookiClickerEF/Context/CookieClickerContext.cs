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
            optionsBuilder.UseSqlite("Data Source=CookieClicker.db");
        }

        public DbSet<GameState> GameStates { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
    }
}
