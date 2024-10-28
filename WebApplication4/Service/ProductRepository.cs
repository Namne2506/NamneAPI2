using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Service
{
    public class ProductRepository : IProductRepository
    {
        private readonly SalesApplicationContext context;
        private readonly DbSet<Product> products;

        public ProductRepository(SalesApplicationContext context, DbSet<Product> products)
        {
            this.context = context;
            this.products = products;
        }

        public bool Create(Product product)
        {
            context.Add(product);
            context.SaveChanges();
            return true;
        }
    }
}
