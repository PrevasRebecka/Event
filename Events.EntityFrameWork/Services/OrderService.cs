using Event.Domain.Models;
using Event.Domain.Repository;
using Event.Domain.Services;

namespace Event.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public EventOrder AddOrder(EventOrder order)
        {
            return _orderRepository.AddOrder(order);
        }

        public IEnumerable<EventOrder> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }
    }
}
