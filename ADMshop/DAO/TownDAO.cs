using ADMshop.Models;
using System;
using System.Linq;

namespace ADMshop.DAO
{
    class TownDAO
    {
        private adm_dbContext context;
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public TownDAO(adm_dbContext context)
        {
            if (context == null) 
                throw new ArgumentNullException("context");

            this.context = context;
        }
        /// <summary>
        /// Взема градаовете, по име;
        /// </summary>
        /// <param name="name">името на града</param>
        /// <returns>име на град</returns>
        public Towns GetTown(string name)
        {
            return this.context.Towns.Where(t => t.TownName.Equals(name)).FirstOrDefault();
        }
    }
}
