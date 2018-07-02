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
        public ViewResult Index() => View(ProductsRepository.GetRepository.GetProducts.Where(p=>p.Price<50));
    }
}