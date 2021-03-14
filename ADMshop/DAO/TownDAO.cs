using ADMshop.Models;
using System;
using System.Linq;

namespace ADMshop.DAO
{
    class TownDAO
    {
        public Towns GetTown(string name)
        {
            return this.context.Towns.Where(t => t.TownName.Equals(name)).FirstOrDefault();
        }

        private adm_dbContext context;
        public TownDAO(adm_dbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
