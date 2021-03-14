using System;
using ADMshop.Models;
using System.Linq;
namespace ADMshop.DAO
{
    class CountryDAO
    {
        public Countries GetCoutry(string name)
        {
            return this.context.Countries.Where(c => c.CountryName.Equals(name)).FirstOrDefault();
        }

        private adm_dbContext context;
        public CountryDAO(adm_dbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
