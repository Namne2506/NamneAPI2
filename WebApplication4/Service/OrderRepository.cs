using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Service
{
    public class OrderRepository : IOrderRepository
    {
        private readonly SalesApplicationContext context;
        private readonly DbSet<Order> orders;

        public OrderRepository(SalesApplicationContext context, DbSet<Order> orders)
        {
            this.context = context;
            this.orders = orders;
        }

        public bool Create(Order order)
        {
            context.Add(order);
            context.SaveChanges();
            return true;

        }
    }
}
