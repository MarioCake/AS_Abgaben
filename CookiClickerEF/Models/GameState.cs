﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models
{
    [Table("Game")]
    public class GameState
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Money { get; set; }

        public int? ParentId { get; set; }
        
        public DateTime CreatedAt { get; set; }

        [ForeignKey(nameof(ParentId))]
        public GameState Parent { get; set; }
        
        public List<GameStateUpgrade> GameStateUpgrades { get; set; }
    }
}
