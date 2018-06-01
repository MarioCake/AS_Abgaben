using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiClickerEF.Models
{
    [Table(nameof(Upgrade))]
    public class Upgrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PrerequiredId { get; set; }
    }
}
