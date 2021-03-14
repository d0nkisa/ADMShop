using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }

        public virtual Users Admin { get; set; }
    }
}
