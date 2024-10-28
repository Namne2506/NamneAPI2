using System.Data.Entity;
using WebApplication4.Models;

namespace WebApplication4.Service
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SalesApplicationContext context;
        private readonly DbSet<Customer> customers;

        public CustomerRepository(SalesApplicationContext context, DbSet<Customer> customers)
        {
            this.context = context;
            this.customers = customers;
        }

        public bool GetById(int CustomerId)
        {
            var customerFind = customers.FirstOrDefault(c => c.CustomerId == c.CustomerId);
            context.SaveChanges();
            return true;
        }
    }
}
