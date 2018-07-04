using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSFeatures.Models
{
    public class ProductsRepository : IRepository
    {
        private static ProductsRepository repository = new ProductsRepository();

        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public ProductsRepository()
        {
            var items = new[]
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            foreach (var p in items)
            {
                AddProduct(p);
            }
        }

        public static ProductsRepository GetRepository => repository;

        public IEnumerable<Product> GetProducts => products.Values;

        IEnumerable<Product> IRepository.GetProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddProduct(Product p) => products.Add(p?.Name, p);


    }
}
