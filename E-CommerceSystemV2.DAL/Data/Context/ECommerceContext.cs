using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Data.Types;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceSystemV2.API
{
    public class ECommerceContext : IdentityDbContext<User>
    {
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<TagProducts> TagProducts => Set<TagProducts>();
        public override DbSet<User> Users => Set<User>();

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.LogTo((query) =>
            {
                File.AppendAllText("Queries.sql", $"\n{query}");
            }).EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);


             //Order
             modelBuilder.Entity<Order>()
               .HasMany(o => o.Products)
               .WithOne(p => p.Order)
               .HasForeignKey(p => p.OrderId)
               .OnDelete(DeleteBehavior.NoAction);

              // User
               modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId);
             
                //category
                modelBuilder.Entity<Category>()
                    .HasMany(p => p.Products)
                    .WithOne(c => c.Category)
                    .OnDelete(DeleteBehavior.NoAction);

                //product
                modelBuilder.Entity<Product>()
                    .Property(P => P.Price)
                    .HasColumnType("decimal(18,2)");

                //tag
                modelBuilder.Entity<Tag>()
                    .HasMany(p => p.TagProducts)
                    .WithOne(t => t.Tag)
                    .HasForeignKey(p => p.TagId)
                    .OnDelete(DeleteBehavior.NoAction);
            
                ////TagProduct
                modelBuilder.Entity<TagProducts>()
                    .HasKey(tp => new { tp.ProductId, tp.TagId });

            #region Seeding

            var users = new List<User>
            {
                new User { UserName="john doe", Email = "john.doe@example.com", PasswordHash = "password123", CreationDate = DateTime.Now },
                new User { UserName="jane doe", Email = "jane.doe@example.com", PasswordHash = "password123", CreationDate = DateTime.Now },
                new User { UserName="Sara doe", Email = "Sara.doe@example.com", PasswordHash = "password123", CreationDate = DateTime.Now },
                new User { UserName="Sandy Jakson", Email = "Sandy.Jakson@example.com", PasswordHash = "password123", CreationDate = DateTime.Now },
            };

            var orders = new List<Order>
            {
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now,UserId =users[1].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[0].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[1].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now,UserId =users[2].Id  },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[1].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[3].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[2].Id },
                new Order { OrderId = Guid.NewGuid(), OrderDate = DateTime.Now ,UserId =users[1].Id  },
            };
            var categories = new List<Category>
            {
                new Category { CategoryId = Guid.NewGuid(), Name = "Clothing" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Electronics" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Mobiles" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Tablets" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Fashion" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Appliances" },
                new Category { CategoryId = Guid.NewGuid(), Name = "SmartDevices" },
                new Category { CategoryId = Guid.NewGuid(), Name = "Gaming" },

            };
            var products = new List<Product>
                  {
                new Product { ProductId = Guid.NewGuid(), Name = "Samsung Galaxy S21", Price = 799.99m, CategoryType = CategoryType.Mobiles ,OrderId =orders[0].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Sony Smart TV", Price = 1299.99m, CategoryType = CategoryType.Electronics ,OrderId =orders[1].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "Canon EOS Rebel T7", Price = 499.99m, CategoryType = CategoryType.Electronics,OrderId =orders[2].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "Nike Running Shoes", Price = 89.99m, CategoryType = CategoryType.Fashion,OrderId =orders[1].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "KitchenAid Stand Mixer", Price = 349.99m, CategoryType = CategoryType.Appliances,OrderId =orders[3].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "HP Printer", Price = 149.99m, CategoryType = CategoryType.Electronics ,OrderId =orders[1].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Levi's Jeans", Price = 59.99m, CategoryType = CategoryType .Fashion ,OrderId =orders[1].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "Bose Noise-Canceling Headphones", Price = 299.99m, CategoryType=CategoryType.Electronics,OrderId =orders[1].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Fitbit Charge 5", Price = 149.99m,CategoryType=CategoryType.Gaming ,OrderId =orders[1].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Cuisinart Coffee Maker", Price = 79.99m, CategoryType = CategoryType.Appliances,OrderId =orders[0].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "Adidas Running Shoes", Price = 109.99m, CategoryType = CategoryType.Fashion ,OrderId =orders[2].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Amazon Echo Dot", Price = 39.99m, CategoryType = CategoryType.SmartDevices ,OrderId =orders[1].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Razer Gaming Mouse", Price = 69.99m, CategoryType = CategoryType.Gaming ,OrderId =orders[1].OrderId },
                new Product { ProductId = Guid.NewGuid(), Name = "Calvin Klein Watch", Price = 199.99m, CategoryType = CategoryType.Fashion ,OrderId =orders[1].OrderId},
                new Product { ProductId = Guid.NewGuid(), Name = "Fossil Smartwatch", Price = 149.99m, CategoryType = CategoryType.Fashion ,OrderId =orders[0].OrderId},
                  };

            var tags = new List<Tag>
            {
                new Tag { TagId =Guid.NewGuid() , Name = "Fashion 2024" },
                new Tag { TagId = Guid.NewGuid(), Name = "FlagShip Mobiles" },
                new Tag { TagId = Guid.NewGuid(), Name = "Tech" },

            };
            var productTags = new List<TagProducts>
                {
                    new TagProducts { TagId = tags[1].TagId, ProductId = products[1].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[2].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[3].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[4].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[5].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[6].ProductId },
                    new TagProducts { TagId = tags[2].TagId, ProductId = products[7].ProductId },

                };
            #endregion
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Order>().HasData(orders);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Tag>().HasData(tags);
            modelBuilder.Entity<TagProducts>().HasData(productTags);
            modelBuilder.Entity<Category>().HasData(categories);
        }
    }
}

