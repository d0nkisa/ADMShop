using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Users
    {
        public Users()
        {
            Offers = new HashSet<Offers>();
        }

        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
        public int TownId { get; set; }
        public int CountryId { get; set; }
        public byte[] UserImage { get; set; }

        public virtual Countries Country { get; set; }
        public virtual Roles Role { get; set; }
        public virtual Towns Town { get; set; }
        public virtual Login User { get; set; }
        public virtual Admins Admins { get; set; }
        public virtual ICollection<Offers> Offers { get; set; }
    }
}
