using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Category
    {
        public Category()
        {
            Offers = new HashSet<Offers>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Offers> Offers { get; set; }
    }
}
