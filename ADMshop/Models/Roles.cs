using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        public int RoleId { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
