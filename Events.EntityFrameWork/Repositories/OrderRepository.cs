using Event.Domain.Models;
using Event.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        OrderDbContext _dbContext;

        public OrderRepository(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EventOrder AddOrder(EventOrder order)
        {
            var addedEntity = _dbContext.Add(order);
            _dbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public IEnumerable<EventOrder> GetAllOrders()
        {
            return _dbContext.Orders.Include(b => b.BillTo).Include(s => s.ShipTo);
        }
    }
}
