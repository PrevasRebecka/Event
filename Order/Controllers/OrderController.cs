using Microsoft.AspNetCore.Mvc;
using Event.Domain.Models;
using Event.Domain.Services;

namespace Event.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("/api/orders")]
        public IEnumerable<EventOrder> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }


        [HttpPost("/api/add-order")]
        public ActionResult<EventOrder> Post([FromBody] EventOrder order)
        {
            if (ModelState.IsValid)
            {
               return _orderService.AddOrder(order);
            }
            return BadRequest();
        }
    }
}