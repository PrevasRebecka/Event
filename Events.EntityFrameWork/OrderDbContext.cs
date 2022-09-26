using Microsoft.EntityFrameworkCore;
using Event.Domain.Models;

namespace Event.Infrastructure
{
    public class OrderDbContext : DbContext
    {

        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) {      }

        public DbSet<EventOrder> Orders { get; set; } = null!;
        public DbSet<Shipping> Shippings { get; set; } = null!;
        public DbSet<Billing> Billings { get; set; } = null!;
    }
}
