using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }

        public virtual Users Users { get; set; }
    }
}
