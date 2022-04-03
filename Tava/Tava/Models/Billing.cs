using System;
using System.Collections.Generic;

#nullable disable

namespace Tava.Models
{
    public partial class Billing
    {
        public int Id { get; set; }
        public int? AdminId { get; set; }
        public int? ClientId { get; set; }
        public DateTime? Date { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? Totalprice { get; set; }
        public int? PointofsaleId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Client Client { get; set; }
        public virtual Pointofsale Pointofsale { get; set; }
        public virtual Product Product { get; set; }
    }
}
