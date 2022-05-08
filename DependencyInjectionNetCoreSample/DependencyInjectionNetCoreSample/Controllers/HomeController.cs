using DependencyInjectionNetCoreSample.Models;
using DependencyInjectionNetCoreSample.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionNetCoreSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      

        public HomeController(ILogger<HomeController> logger)
        {
            //Constructor injection
            _logger = logger;
          
        }

        public IActionResult Index([FromServices] IProductService _productService) // action method injection
        {
            var products = _productService.GetProducts();
            return View(products);
         
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
