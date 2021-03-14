using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Towns
    {
        public Towns()
        {
            Offers = new HashSet<Offers>();
            Users = new HashSet<Users>();
        }

        public int TownId { get; set; }
        public string TownName { get; set; }
        public int? CountryCode { get; set; }

        public virtual Countries CountryCodeNavigation { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
