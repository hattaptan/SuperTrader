using SuperTrader.Base.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Entity.Model
{
    public class Portfolio : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int id { get; set; }

        [ForeignKey("traderId")]
        public int traderId { get; set; }
        public Traders trader { get; set; }

        [ForeignKey("sellId")]
        public int sellId { get; set; }
        public Sell sell { get; set; }

        [ForeignKey("buyId")]
        public int buyId { get; set; }
        public Buy buy { get; set; }

    }
}
