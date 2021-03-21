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
        /// <summary>
        /// проверява дали въведените входни данни са верни, ако са връща потребител ако не са,
        /// се връща null, върнатите резлутати се използват в метод;
        /// </summary>
        /// <param name="username">потребителското име, въведено от потребителя</param>
        /// <param name="password">паролата, въведена от потребителя</param>
        /// <returns></returns>
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
        /// <summary>
        /// Метод за хеширане на паролата на потребителя, за да не е общодостъпна;
        /// </summary>
        /// <param name="password">въведената от потребителя парола</param>
        /// <returns>хаш на въведената от потребителя парола</returns>
        public string HashPassword(string password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
        }
        /// <summary>
        /// Метод за регистриране на бов потребител;
        /// </summary>
        /// <param name="login">данни за вписване (потребителско име и парола)</param>
        /// <param name="user">данни за потребителя (всичко което се съдуржа в таблица users)</param>
        public void RegisterUser(Login login ,Users user)
        {            
            this.context.Login.Add(login);
            this.context.SaveChanges();
        }
        /// <summary>
        /// Брои всеки нов въдеден потребител и отговаря за id-тата в таблицата users;
        /// </summary>
        /// <param name="context">връзка с базата данни</param>
        /// <returns>номера на потребителя</returns>
        public int GetID(adm_dbContext context)
        {
            return context.Users.Count();
        }

        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public HomeDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
