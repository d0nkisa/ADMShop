using System;
using ADMshop.Models;
using System.Linq;
namespace ADMshop.DAO
{
    class CountryDAO
    {
        private adm_dbContext context;
        /// <summary>
        /// Взема имената на държавите;
        /// </summary>
        /// <param name="name">името на държавата</param>
        /// <returns>държава</returns>
        public Countries GetCoutry(string name)
        {
            return this.context.Countries.Where(c => c.CountryName.Equals(name)).FirstOrDefault();
        }
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public CountryDAO(adm_dbContext context)
        {
            if (context == null) 
            throw new ArgumentNullException("context");
            
            this.context = context;
        }
    }
}
