using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class ProductRepository :IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product(){ProductId=1,ProductName="Samsung s9 Plus",Price=5200,CategoryId=1 },
            new Product(){ProductId=2,ProductName="Samsung Tablet",Price=2500,CategoryId=3 },
            new Product(){ProductId=3,ProductName="Asus NoteBook",Price=8700,CategoryId=2 },
            new Product(){ProductId=4,ProductName="Samsung s7",Price=2150,CategoryId=1 },

            new Product(){ProductId=5,ProductName="Samsung s9 Plus",Price=5200,CategoryId=1 },
            new Product(){ProductId=6,ProductName="Samsung Tablet",Price=2500,CategoryId=3 },
            new Product(){ProductId=7,ProductName="Asus NoteBook",Price=8700,CategoryId=2 },
            new Product(){ProductId=8,ProductName="Samsung s7",Price=2150,CategoryId=1 },

            new Product(){ProductId=9,ProductName="Samsung s9 Plus",Price=5200,CategoryId=1 },
            new Product(){ProductId=10,ProductName="Samsung Tablet",Price=2500,CategoryId=3 },
            new Product(){ProductId=11,ProductName="Asus NoteBook",Price=8700,CategoryId=2 },
            new Product(){ProductId=12,ProductName="Samsung s7",Price=2150,CategoryId=1 }

        };
        public IEnumerable<Product> Products => _products;



        public void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}
