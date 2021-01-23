using Microsoft.EntityFrameworkCore;
using RegistrationApp.Core.Model;

namespace ShopApplication.Core.Database
{
    class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasIndex(c => c.VatNumber).IsUnique();
        }
    }
}
