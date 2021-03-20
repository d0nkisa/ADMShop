using System;
using ADMshop.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ADMshop.DAO
{
    class UserDAO
    {
        private adm_dbContext context;
        
        public UserDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");

            this.context = context;
        }

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
