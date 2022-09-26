using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Event.Domain.Models
{
    public class Billing
    {
        [Required]
        public int Id { get; set; }
        
        public string Name { get; set; } = null!;
       
        public string Address { get; set; } = null!;
       
        public string City { get; set; } = null!;
        
        public string State { get; set; } = null!;
        
        [MaxLength(5)]
        public string Zip { get; set; } = null!;
    }
}
