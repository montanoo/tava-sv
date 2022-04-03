using System;
using System.Collections.Generic;

#nullable disable

namespace Tava.Models
{
    public partial class Product
    {
        public Product()
        {
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double? Price { get; set; }
        public string Package { get; set; }
        public int? Unitsperset { get; set; }

        public virtual ICollection<Billing> Billings { get; set; }
    }
}
