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
        /// <summary>
        /// Метод който връща списък с оферти според категориите;
        /// </summary>
        /// <param name="id">номер на обява</param>
        /// <returns>списък с обяви</returns>
        public List<Offers> GetOfferByCat(List<int> id)
        {
            List<Offers> x = new List<Offers>();
            foreach (var item in id)
            {
                x.AddRange(this.context.Offers
                   .Where(o => o.Category.Equals(item)));
            }
            return x;
        }
        /// <summary>
        /// търси обявата според текст с сърч бара;
        /// </summary>
        /// <param name="name">текста от сърч бара</param>
        /// <returns>обява която съвпада</returns>
        public List<Offers> SearchByName(string name)
        {
            List<Offers> x = new List<Offers>();
            
                x.AddRange(this.context.Offers
                .Where(o => o.OfferHeading.Contains(name)));      
            return x;
        }
        public Offers GetOfferById(int id,int cat)
        {
            return this.context.Offers
                 .Where(o => o.OfferId.Equals(id) && o.Category.Equals(cat))
                 .FirstOrDefault();
        }
        /// <summary>
        /// метод за изтриване на обява, според нейния номер;
        /// </summary>
        /// <param name="id">номер на обява</param>
        /// <returns>променената база данни</returns>
        public int DeleteOffer(int id)
        {
            this.context.Offers.Remove(GetOfferById(id));
            return this.context.SaveChanges();

        }
        /// <summary>
        /// метод за конвертиране на снимката от какъвто формат е към поток от байтове, за да
        /// може да се запише в базата данни;
        /// </summary>
        /// <param name="img">снимка подадена от потребителя</param>
        /// <returns>поток от байтове, който се записва в базата</returns>
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
        /// <summary>
        /// Метод за конвертиране на снимките от byte към bmp;
        /// </summary>
        /// <param name="blob">променлива която съдтржа снимката във формат байт</param>
        /// <returns>снимка във bmp формат</returns>
        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();

            return bm;
        }

        /// <summary>
        /// Следеи за индекса на всяка оферта и брои офертите;
        /// </summary>
        /// <param name="context">връзка с базата</param>
        /// <returns>номера на офертата</returns>
        public int OfferCount(adm_dbContext context)
        {
            return context.Offers.Count(); 
        }

        private adm_dbContext context;
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public OfferDAO(adm_dbContext context)
        {
            if (context == null) 
                throw new ArgumentNullException("context");

            this.context = context;
        }
        /// <summary>
        /// проверява дали офертата е null, ако не е връща нова форма с текущата избрана оферта;
        /// </summary>
        /// <param name="currentuser">съдържа данни за текущия потребител</param>
        /// <param name="id"> номер на обява</param>
        /// <param name="Offers"> списък от обявите</param>
        public void CheckIfOfferIsNull( Users currentuser, int id,List<Offers> Offers )
        {
            List<Offers> offers = Offers;
            Offers offer = offers[id - 1];
            if (offer != null)
            {
                HomeScreen.ActiveForm.Close();
                OfferForm offerForrm = new OfferForm(currentuser, id,offer);
                offerForrm.Activate();
                offerForrm.Show();
            }
            else MessageBox.Show("No Offer! Try something different!");
        }
        /// <summary>
        /// Ако тяма подадена снимка която да се преобразува връща снимка по подразбиране;
        /// </summary>
        /// <param name="no_photo">снимка по подразбиране</param>
        /// <returns></returns>
        internal Image ByteToImage(Bitmap no_photo)
        {        
            return (Image)no_photo;
        }
        public int CreateOffer(Offers newoffer)
        {
            this.context.Offers.Add(newoffer);
            return this.context.SaveChanges();
        }
        public List<Offers> AllOffers()
        {
            return this.context.Offers.ToList();
        }
        public Offers GetOfferById(int id)
        {
            return this.context.Offers
                 .Where(o => o.OfferId.Equals(id))
                 .FirstOrDefault();
        }
    }
}
