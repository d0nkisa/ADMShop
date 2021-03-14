using System;
using System.Collections.Generic;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace ADMshop.DAO
{
    class OfferDAO
    {
        public int CreateOffer(string name,string description, int userId, int category, decimal price,int town,int phone)
        {
            Offers offer = new Offers();
            offer.OfferHeading = name;
            offer.OfferDescription = description;
            offer.UserId = userId;
            offer.ItemState = true; //novo
            offer.Category = category;
            offer.OfferPrice = price;
            offer.TownId = town;
            offer.Phone = phone;

            this.context.Offers.Add(offer);
            return this.context.SaveChanges();
        }

        public int DeleteOffer()
        {
            throw new NotImplementedException();
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
