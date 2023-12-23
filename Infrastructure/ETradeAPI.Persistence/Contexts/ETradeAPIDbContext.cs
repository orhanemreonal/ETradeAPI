using ETradeAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETradeAPI.Persistence.Contexts
{
    public class ETradeAPIDbContext : DbContext
    {
        public ETradeAPIDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
