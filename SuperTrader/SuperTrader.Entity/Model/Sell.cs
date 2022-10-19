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
    public class Sell : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [ForeignKey("shareId")]
        public int shareId { get; set; }
        public Share share { get; set; }

        [ForeignKey("traderId")]
        public int traderId { get; set; }
        public Traders trader { get; set; }

    }
}
