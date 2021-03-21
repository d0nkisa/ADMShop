using System;
using ADMshop.Models;
using System.Linq;

namespace ADMshop.DAO
{
    class RoleDAO
    {
        private adm_dbContext context;
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public RoleDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");

            this.context = context;
        }
        /// <summary>
        /// Взема ролята на потребителя, може да е потребител или админ;
        /// </summary>
        /// <param name="name">името на ролята</param>
        /// <returns>име на ролята</returns>
        public Roles GetRole(string name)
        {
            return this.context.Roles.Where(r => r.Role.Equals(name)).FirstOrDefault();
        }
    }
}
