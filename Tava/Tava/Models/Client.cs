using System;
using System.Collections.Generic;

#nullable disable

namespace Tava.Models
{
    public partial class Client
    {
        public Client()
        {
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int? Phone { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
    }
}
