using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Service;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository repos;

        public OrderController(OrderRepository repos)
        {
            this.repos = repos;
        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            try
            {
                var data = repos.Create(order);
                return StatusCode(201, data);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
