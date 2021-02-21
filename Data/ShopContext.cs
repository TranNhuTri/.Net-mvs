using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext (DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
        public DbSet<ProductView> Products { get; set; }
        public DbSet<TypeProduct> TypeProduct { get; set; }
    }
}