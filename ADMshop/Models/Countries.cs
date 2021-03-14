using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Countries
    {
        public Countries()
        {
            Towns = new HashSet<Towns>();
            Users = new HashSet<Users>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Towns> Towns { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
