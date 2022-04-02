using System;
using System.Collections.Generic;

namespace Tava.Models
{
    public partial class Pointofsale
    {
        public Pointofsale()
        {
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
    }
}
