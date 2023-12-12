using E_CommerceSystemV2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

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
        public DbSet<UserOrders> UserOrders => Set<UserOrders>();

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //order
      
            modelBuilder.Entity<Order>().HasKey(o => o.OrderId);
            modelBuilder.Entity<Order>().HasMany(u => u.UserOrders).WithOne(o => o.Order).HasForeignKey(K => K.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            //category

            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>().HasMany(p => p.Products).WithOne(c => c.Category)
                .OnDelete(DeleteBehavior.Restrict);

            //product
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasOne(c => c.Category).WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>().HasMany(t => t.Tags).WithMany(p => p.Products);
            modelBuilder.Entity<Product>().Property(p => p.Price).HasColumnType("decimal(18,2)");

            //tag
            modelBuilder.Entity<Tag>().HasKey(t => t.TagId);
            modelBuilder.Entity<Tag>().HasMany(p => p.Products).WithMany(t => t.Tags);

            //user
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
            modelBuilder.Entity<User>().HasMany(o => o.UserOrders).WithOne(U => U.User).HasForeignKey(U=>U.UserId)
                .OnDelete(DeleteBehavior.Cascade);
           
            //TagProduct


            modelBuilder.Entity<TagProducts>().HasKey(k => new { k.TagId, k.ProductId });
            //UserOrders
            modelBuilder.Entity<UserOrders>().HasKey(k => new { k.UserId, k.OrderId });

            #region Seeding

            var users = new List<User>
        {
            new User { UserId = 1, E_mail = "john.doe@example.com", PasswordHashSet = "password123", CreationDate = DateTime.Now },
            new User { UserId = 2, E_mail = "jane.doe@example.com", PasswordHashSet = "password123", CreationDate = DateTime.Now },
            new User { UserId = 3, E_mail = "Sara.doe@example.com", PasswordHashSet = "password123", CreationDate = DateTime.Now },
            new User { UserId = 4, E_mail = "Sandy.Jakson@example.com", PasswordHashSet = "password123", CreationDate = DateTime.Now },
        };

            var orders = new List<Order>
        {
            new Order { OrderId = 1, OrderDate = DateTime.Now },
            new Order { OrderId = 2, OrderDate = DateTime.Now },
        };

            var products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
            new Product { ProductId = 2, Name = "Smartphone", Price = 599.99m, CategoryId = 1 },
        };

            var tags = new List<Tag>
        {
            new Tag { TagId = 1, Name = "Electronics" },
            new Tag { TagId = 2, Name = "Clothing" },
        };

            var productTags = new List<TagProducts>
        {
            new TagProducts { TagId = 1, ProductId = 1 },
            new TagProducts { TagId = 2, ProductId = 2 },
        };

            var categories = new List<Category>
        {
            new Category { CategoryId = 1, Name = "Electronics" },
            new Category { CategoryId = 2, Name = "Clothing" },
        };

            var userOrders = new List<UserOrders>
        {
            new UserOrders { UserId = 1, OrderId = 1 },
            new UserOrders { UserId = 2, OrderId = 2 },
        };

            #endregion

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Order>().HasData(orders);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Tag>().HasData(tags);
            modelBuilder.Entity<TagProducts>().HasData(productTags);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<UserOrders>().HasData(userOrders);
        }




    }
    }
