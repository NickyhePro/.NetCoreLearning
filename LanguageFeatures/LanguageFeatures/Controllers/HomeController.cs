using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "No Name";
                decimal? price = p?.Price ?? 0;
                string related = p?.Realated?.Name ?? "None";
                results.Add($"Name: {name}, Price: {price}, Related: {related}");
            }

            return View(results);
        }*/

        /*public IActionResult Index()       //Dictionary initializer
        {
            
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product {Name = "Kayak", Price = 275m},
                ["LifeJacket"] = new Product {Name = "LifeJacket", Price = 12.25m}
            };

            return View(products.Keys);#1#
        }*/

        /*public IActionResult Index()     //Is keyword in if condition
        {
            object[] data = new object[] { 275M, 29.95M,
                "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }*/

        /*public IActionResult Index()       //when keyword in switch condition
        {
            object[] data = new object[] { 275M, 29.95M,
                "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i])
                {
                    case decimal decimalValue:
                        total += decimalValue;
                        break;
                    case int intValue when intValue > 50:
                        total += intValue;
                        break;
                }
            }
            return View("Index", new string[] { $"Total: {total:C2}" });
        }*/

        public IActionResult Index()        //Class extension
        {       
            var cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };

            Product[] productArray = new Product[]{
                new Product{Name = "Kayak", Price = 275M},
                new Product{Name = "Lifejacket", Price = 48.95M},
                new Product{Name = "Soccer ball", Price = 19.50M},
                new Product{Name = "Corner flag", Price = 34.95M}
            };

            decimal cartTotal = cart.Filter(p => p?.Name?[0] == 'K').totalPrice();
            decimal arrayTotal = productArray.Filter(p => (p?.Price?? 0) >= 20).totalPrice();

            return View(new String[] {$"Cart Total: {cartTotal:c2}",$"Array Total: {arrayTotal:c2}"});
        }

        /*public ViewResult Index()           //nameof(instance)
        {
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };
            return View(products.Select(p =>
                $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }*/

        /*public IActionResult Index() =>
            View(Product.GetProducts().Select(p => p.BeginWithK == true));*/

    }
}