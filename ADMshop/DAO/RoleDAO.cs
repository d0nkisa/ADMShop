using System;
using System.Collections.Generic;
using System.Text;
using ADMshop.Models;
using System.Linq;

namespace ADMshop.DAO
{
    class RoleDAO
    {
        public Roles GetRole(string name)
        {
            return this.context.Roles.Where(r => r.Role.Equals(name)).FirstOrDefault();
        }

        private adm_dbContext context;
        public RoleDAO(adm_dbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
