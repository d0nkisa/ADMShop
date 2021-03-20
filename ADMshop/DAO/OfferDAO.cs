using System;
using System.Collections.Generic;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

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
                 .Where(o => o.OfferId.Equals(id))
                 .FirstOrDefault();
        }
        public int DeleteOffer(int id)
        {
            this.context.Offers.Remove(GetOfferById(id));
            return this.context.SaveChanges();

        }
        public byte[] ImageToByte(PictureBox img)
        {
            ImageConverter converter = new ImageConverter();
            Bitmap bmp = default;
            try
            {
                bmp = (Bitmap)img.Image;

            }
            catch
            {
                MessageBox.Show("Can't load image!");
            }
            return (byte[])converter.ConvertTo(bmp, typeof(byte[]));
        }
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }
        public int OfferCount(adm_dbContext context)
        {
            return context.Offers.Count(); 
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

        internal Image ByteToImage(Bitmap no_photo)
        {        
            return (Image)no_photo;
        }
    }
}
