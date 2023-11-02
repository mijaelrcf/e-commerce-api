namespace e_commerce_api.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}
