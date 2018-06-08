using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models
{
    [Table(nameof(GameStateUpgrade))]
    public class GameStateUpgrade
    {
        public int UpgradeId { get; set; }

        public int GameStateId { get; set; }
        
        public GameState GameState { get; set; }
        
        public Upgrade Upgrade { get; set; }
    }
}
