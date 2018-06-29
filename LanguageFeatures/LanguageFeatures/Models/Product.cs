using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Edm.Csdl;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }

        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; } = "WaterSports";
        public Product Realated { get; set; }
        public bool InStock { get; }
        public bool BeginWithK => Name?[0] == 'K';

        public static Product[] GetProducts()
        {
            var kayak = new Product
            {
                Name = "Kayak", Price = 275m, Category = "Water Craft"
            };

            var lifeJacket = new Product
            {
                Name = "LifeJacket",
                Price = 48.95m
            };

            kayak.Realated = lifeJacket;

            return new Product[]{kayak, lifeJacket, null};
        }
    }
}
