using ADMshop.Models;
using System;
using System.Linq;
namespace ADMshop.DAO
{
    class CategoryDAO
    {
        public Category GetCategory(string name)
        {
            return this.context.Category.Where(c => c.CategoryName.Equals(name)).FirstOrDefault();
        }

        private adm_dbContext context;
        public CategoryDAO(adm_dbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }
    }
}
