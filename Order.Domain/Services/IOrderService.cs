using Event.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Domain.Services
{
    public interface IOrderService
    {
        public EventOrder AddOrder(EventOrder order);

        public IEnumerable<EventOrder> GetAllOrders();
    }
}
