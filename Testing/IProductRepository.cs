using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllPorducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
    }
}
