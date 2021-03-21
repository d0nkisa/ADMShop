using ADMshop.Models;
using System;
using System.Linq;
namespace ADMshop.DAO
{
    class CategoryDAO
    {
        /// <summary>
        /// Взема категориите на обявите;
        /// </summary>
        /// <param name="name">името на категорията</param>
        /// <returns>категория</returns>
        public Category GetCategory(string name)
        {
            return this.context.Category.Where(c => c.CategoryName.Equals(name)).FirstOrDefault();
        }

        private adm_dbContext context;
        /// <summary>
        /// Ако контекста не е null, дава връзка на DAO-то към базата данни
        /// </summary>
        /// <param name="context">контекст към базата данни</param>
        public CategoryDAO(adm_dbContext context)
        {
            if (context == null) 
               throw new ArgumentNullException("context");

            this.context = context;
        }
    }
}
