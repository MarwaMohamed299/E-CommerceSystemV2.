using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace E_CommerceSystemV2.API
{
    public class ECommerceContext :DbContext
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product>Products => Set <Product>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<TagProducts> TagProducts => Set<TagProducts>();
        public DbSet<User> Users => Set<User>();
        public DbSet<UserOrder> UserOrders => Set<UserOrder>();
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

                
        }
    }
}