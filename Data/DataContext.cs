using e_commerce_api.Models;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Customer> customersInit = new List<Customer>();
            customersInit.Add(new Customer() { Id = Guid.NewGuid(), Name = "Mijael Callejas", Email = "mijael.rcf@gmail", Address = "Street 13" });

            modelBuilder.Entity<Customer>(customer =>
            {
                customer.HasData(customersInit);
            });
        }
    }
}
