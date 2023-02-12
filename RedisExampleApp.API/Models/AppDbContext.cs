using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace RedisExampleApp.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "kalem 1", Price = 12 },
                new Product() { Id = 2, Name = "kalem 2", Price = 13 },
                new Product() { Id = 3, Name = "kalem 3", Price = 14 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
