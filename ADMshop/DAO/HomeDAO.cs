using System;
using System.Text;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ADMshop.DAO
{
    class HomeDAO
    {
        private adm_dbContext context;

        public Users LogIn(string username, string password)
        {
            try
            {
                var user = this.context.Login
                .Include(u => u.Users)
                .Where(u => u.Username.Equals(username) && u.Pasword.Equals(HashPassword(password)))
                .FirstOrDefault().Users;

                return user;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }

        public void RegisterUser(Login login ,Users user)
        {            
            this.context.Login.Add(login);
            this.context.SaveChanges();
        }

        public int GetID(adm_dbContext context)
        {
            return context.Users.Count();
        }
        
        public HomeDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
