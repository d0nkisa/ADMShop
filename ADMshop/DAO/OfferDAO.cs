using System;
using System.Collections.Generic;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ADMshop.DAO
{
    class OfferDAO
    {
        public int CreateOffer(Offers newoffer)
        {
            this.context.Offers.Add(newoffer);
            return this.context.SaveChanges();
        }
        public Offers GetOfferById(int id)
        {
            return this.context.Offers
                 .Include(o => o.OfferPrice)
                 .Include(o => o.OfferHeading)
                 .Include(o => o.Image)
                 .Where(o => o.OfferId.Equals(id))
                 .FirstOrDefault();
        }
        public int DeleteOffer(int id)
        {
            this.context.Offers.Remove(GetOfferById(id));
            return this.context.SaveChanges();

        }

        public List<Users> GetAllOffersByUserId(int userId)
        {
            var offers = this.context.Users
                        .Include(j => j.Firstname)
                        .Include(j => j.Offers)
                        .ThenInclude(ja => ja.User)
                        .Where(j => j.UserId.Equals(userId))
                        .ToList();
            return offers;
        }

        private adm_dbContext context;
        public OfferDAO(adm_dbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
