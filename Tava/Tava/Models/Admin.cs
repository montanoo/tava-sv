using System;
using System.Collections.Generic;

#nullable disable

namespace Tava.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Billings = new HashSet<Billing>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Identitynumber { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Bankaccount { get; set; }
        public string Companyname { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Billing> Billings { get; set; }
    }
}
