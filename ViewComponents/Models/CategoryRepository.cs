using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories => throw new NotImplementedException();

        public void AddCategory(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
