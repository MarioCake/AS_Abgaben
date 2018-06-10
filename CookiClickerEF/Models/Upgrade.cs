using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiClickerEF.Models
{
    [Table("Upgrade")]
    public class Upgrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int? DependencyId { get; set; }

        [ForeignKey(nameof(DependencyId))]
        public Upgrade Dependency { get; set; }
        
        public List<GameStateUpgrade> GameStateUpgrades { get; set; }
        
    }
}
