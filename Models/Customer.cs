using System.ComponentModel.DataAnnotations;

namespace e_commerce_api.Models
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string Name { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<Order> Orders { get; set; }
    }
}
