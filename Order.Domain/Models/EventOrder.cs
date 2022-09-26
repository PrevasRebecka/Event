using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Event.Domain.Models
{
    public class EventOrder
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Sku { get; set; } = null!;

        public double Price { get; set; }

        public Billing BillTo { get; set; } = null!;

        public Shipping ShipTo { get; set; } = null!;
    }
}