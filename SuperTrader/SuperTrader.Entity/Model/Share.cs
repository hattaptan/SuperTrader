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
    public class Share : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [StringLength(3)]
        public string shareCode { get; set; }
        public string shareName { get; set; }
        public int price { get; set; }
        public decimal percent { get; set; }
        public DateTime updatedDate { get; set; }

    }
}
