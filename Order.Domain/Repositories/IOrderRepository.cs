using Event.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Domain.Repository
{
    public interface IOrderRepository
    {
        public EventOrder AddOrder(EventOrder order);

        public IEnumerable<EventOrder> GetAllOrders(); 
    }
}
