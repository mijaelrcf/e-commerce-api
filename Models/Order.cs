using System.Text.Json.Serialization;

namespace e_commerce_api.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime OrderDate { get; set; }

        public Guid CustomerId { get; set; }
        
        //[JsonIgnore]
        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }
    }
}
