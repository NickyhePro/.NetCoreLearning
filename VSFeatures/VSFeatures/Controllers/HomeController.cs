using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VSFeatures.Models;

namespace VSFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IRepository repository = ProductsRepository.GetRepository;

        public IActionResult Index() => View(repository.GetProducts.Where(p => p?.Price<50));

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            repository.AddProduct(p);
            return RedirectToAction("Index");
        }
    
    }
}   