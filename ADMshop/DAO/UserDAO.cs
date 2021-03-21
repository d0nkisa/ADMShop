using System;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADMshop.DAO
{
    class UserDAO
    {
        private adm_dbContext context;
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public UserDAO(adm_dbContext context)
        {
            if (context == null) 
                throw new ArgumentNullException("context");

            this.context = context;
        }
        /// <summary>
        /// Връща града и държавата на потребителя, чийто номер съвпада с входния
        /// параметър;
        /// </summary>
        /// <param name="id">номер на потребителя</param>
        /// <returns>град и държавата на потребителя, където id съвпада с даденото;</returns>
        public Users GetUserById(int id)
        {
            return this.context.Users
                 .Include(u => u.Town)
                 .Include(u => u.Country)
                 .Where(u => u.UserId.Equals(id))
                 .FirstOrDefault();
        }
    }
}
