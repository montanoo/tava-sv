using System;
using System.Collections.Generic;

#nullable disable

namespace Tava.Models
{
    public partial class User
    {
        public User()
        {
            Admins = new HashSet<Admin>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Admin> Admins { get; set; }
    }
}
