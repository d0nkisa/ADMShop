using System;
using ADMshop.Models;
using System.Linq;

namespace ADMshop.DAO
{
    class RoleDAO
    {
        private adm_dbContext context;
        public RoleDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");

            this.context = context;
        }

        public Roles GetRole(string name)
        {
            return this.context.Roles.Where(r => r.Role.Equals(name)).FirstOrDefault();
        }
    }
}
