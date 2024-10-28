using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Service
{
    public class OrderService : IOrderService
    {
        private readonly SalesApplicationContext context;
        private readonly DbSet<Order> orders;
        private readonly DbSet<Product> products;
        private readonly DbSet<Customer> customers;

        public OrderService(SalesApplicationContext context, DbSet<Order> orders, DbSet<Product> products, DbSet<Customer> customers)
        {
            this.context = context;
            this.orders = orders;
            this.products = products;
            this.customers = customers;
        }

        public bool Create(Order order)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == c.CustomerId);
            if (customer == null)
            {
                customer = new Customer();
               
            } 
            context.Add(customer);
            context.SaveChanges();  

            foreach (var product in products)
            {
                var Product = products.FirstOrDefault(p => p.ProductId == p.ProductId);
                if(product == null)
                {
                    var NewProduct = new Product()
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Price = product.Price,
                        Stock = product.Stock
                    };
                    products.Add(NewProduct);
                    context.SaveChanges();
                }
            }
            
            return true;

        }

    }
}
