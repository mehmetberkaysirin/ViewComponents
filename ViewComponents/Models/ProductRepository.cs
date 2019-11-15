using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => throw new NotImplementedException();

        public void AddProduct(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
