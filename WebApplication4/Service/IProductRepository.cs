using WebApplication4.Models;

namespace WebApplication4.Service
{
    public interface IProductRepository
    {
        public bool Create(Product product);
    }
}
