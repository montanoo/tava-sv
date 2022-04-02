using System;
using System.Collections.Generic;

namespace Tava.Models
{
    public partial class User
    {
        public User()
        {
            Admins = new HashSet<Admin>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Admin> Admins { get; set; }
    }
}
