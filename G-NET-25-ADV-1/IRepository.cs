using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_25_ADV_1
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
    // 1. Define a simple class to use as T
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // 2. Implement the interface
    public class ProductRepository : IRepository<Product>
    {
        private List<Product> _products = new List<Product> {
        new Product { Id = 1, Name = "Laptop" },
        new Product { Id = 2, Name = "Mouse" }
    };

        public IEnumerable<Product> GetAll() => _products;

        // Remaining methods implemented here...
        public Product GetById(int id) => _products.Find(p => p.Id == id);
        public void Add(Product entity) => _products.Add(entity);
        public void Update(Product entity) { /* Logic */ }
        public void Delete(int id) { /* Logic */ }
    }
}
