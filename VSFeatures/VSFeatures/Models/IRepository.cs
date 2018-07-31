using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSFeatures.Models
{
    public interface IRepository
    {
        IEnumerable<Product> GetProducts{get;set;}
        void AddProduct(Product p);
    }
}
