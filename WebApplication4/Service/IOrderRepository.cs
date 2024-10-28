using WebApplication4.Models;

namespace WebApplication4.Service
{
    public interface IOrderRepository
    {
        bool Create(Order order);
    }
}
