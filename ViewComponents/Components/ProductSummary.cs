using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Models;

namespace ViewComponents.Components
{
    public class ProductSummary:ViewComponent
    {
        private IProductRepository productRepository;

        public ProductSummary(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        public IViewComponentResult Invoke(bool isApproved)
        {
            if (true)
            {

            }


            return View(new ProductSummaryViewModel()
            {
                Count = productRepository.Products.Where(i=>i.IsApproved==isApproved).Count(),
                totalCount=productRepository.Products.Sum(i=>i.Price)

            }); 
                

        }
    }
}
