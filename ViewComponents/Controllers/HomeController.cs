using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewComponents.Models;

namespace ViewComponents.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;
        public HomeController(ICategoryRepository _categoryRepository, IProductRepository _productRepository)
        {
            productRepository = _productRepository;
            categoryRepository = _categoryRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.Products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
