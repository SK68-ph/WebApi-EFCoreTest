using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using TestEFCore.Models;

namespace TestEFCore.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
