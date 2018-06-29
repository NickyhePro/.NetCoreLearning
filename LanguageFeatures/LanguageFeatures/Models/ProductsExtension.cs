using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyModel;

namespace LanguageFeatures.Models
{
    public static class ProductsExtension
    {
        public static decimal totalPrice(this IEnumerable<Product> products)
        {
            decimal totalPrice = 0;
            foreach (Product p in products)
            {
                totalPrice += p?.Price ?? 0;
            }

            return totalPrice;
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> products, Predicate<Product> predicate)
        {
            foreach (var product in products)
            {
                if (predicate(product))
                {
                    yield return product;
                }
            } 
        }

    }
}
