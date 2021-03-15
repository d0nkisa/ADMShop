using System;
using System.Collections.Generic;

namespace ADMshop.Models
{
    public partial class Offers
    {
        public int OfferId { get; set; }
        public string OfferHeading { get; set; }
        public decimal OfferPrice { get; set; }
        public string OfferDescription { get; set; }
        public int UserId { get; set; }
        public int TownId { get; set; }
        public bool? ItemState { get; set; }
        public int Phone { get; set; }
        public int Category { get; set; }
        public byte[] Image { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual Towns Town { get; set; }
        public virtual Users User { get; set; }
    }
}
