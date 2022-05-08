using DependencyInjectionNetCoreSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionNetCoreSample.Service
{
   public interface IProductService
    {

        List<Product> GetProducts();
    }

    

public class AmazonProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
        {
            new Product() { Id = 1001, Name = "Apple AirPods Pro", Price = 249.00m },
            new Product() { Id = 1002, Name = "Sony Noise Cancelling Headphones", Price = 199.00m },
            new Product() { Id = 1003, Name = "Acer Aspire 5 Slim Laptop", Price = 346.00m }
        };
        }
    }
}
