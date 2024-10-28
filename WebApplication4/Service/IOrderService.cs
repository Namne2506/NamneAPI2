using WebApplication4.Models;

namespace WebApplication4.Service
{
    public interface IOrderService
    {
        public bool Create(Order order);
    }
}
