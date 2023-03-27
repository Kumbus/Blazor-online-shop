using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Domain.Entities;

namespace ShopOnline.Infrastructure.Data
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Guid category1Id = Guid.NewGuid();
            Guid category2Id = Guid.NewGuid();
            Guid category3Id = Guid.NewGuid();
            Guid category4Id = Guid.NewGuid();
            //Products
            //Beauty Category
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Glossier - Beauty Kit",
                Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                ImageURL = "/Images/Beauty/Beauty1.png",
                Price = 100,
                Quantity = 100,
                CategoryId = category1Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Curology - Skin Care Kit",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/Beauty2.png",
                Price = 50,
                Quantity = 45,
                CategoryId = category1Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Cocooil - Organic Coconut Oil",
                Description = "A kit provided by Curology, containing skin care products",
                ImageURL = "/Images/Beauty/Beauty3.png",
                Price = 20,
                Quantity = 30,
                CategoryId = category1Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Schwarzkopf - Hair Care and Skin Care Kit",
                Description = "A kit provided by Schwarzkopf, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/Beauty4.png",
                Price = 50,
                Quantity = 60,
                CategoryId = category1Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Skin Care Kit",
                Description = "Skin Care Kit, containing skin care and hair care products",
                ImageURL = "/Images/Beauty/Beauty5.png",
                Price = 30,
                Quantity = 85,
                CategoryId = category1Id

            });
            //Electronics Category
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Air Pods",
                Description = "Air Pods - in-ear wireless headphones",
                ImageURL = "/Images/Electronic/Electronics1.png",
                Price = 100,
                Quantity = 120,
                CategoryId = category3Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "On-ear Golden Headphones",
                Description = "On-ear Golden Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronic/Electronics2.png",
                Price = 40,
                Quantity = 200,
                CategoryId = category3Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "On-ear Black Headphones",
                Description = "On-ear Black Headphones - these headphones are not wireless",
                ImageURL = "/Images/Electronic/Electronics3.png",
                Price = 40,
                Quantity = 300,
                CategoryId = category3Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Sennheiser Digital Camera with Tripod",
                Description = "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod",
                ImageURL = "/Images/Electronic/Electronic4.png",
                Price = 600,
                Quantity = 20,
                CategoryId = category3Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Canon Digital Camera",
                Description = "Canon Digital Camera - High quality digital camera provided by Canon",
                ImageURL = "/Images/Electronic/Electronic5.png",
                Price = 500,
                Quantity = 15,
                CategoryId = category3Id

            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Provided by Nintendo",
                ImageURL = "/Images/Electronic/technology6.png",
                Price = 100,
                Quantity = 60,
                CategoryId = category3Id
            });
            //Furniture Category
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Black Leather Office Chair",
                Description = "Very comfortable black leather office chair",
                ImageURL = "/Images/Furniture/Furniture1.png",
                Price = 50,
                Quantity = 212,
                CategoryId = category2Id
            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Pink Leather Office Chair",
                Description = "Very comfortable pink leather office chair",
                ImageURL = "/Images/Furniture/Furniture2.png",
                Price = 50,
                Quantity = 112,
                CategoryId = category2Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Lounge Chair",
                Description = "Very comfortable lounge chair",
                ImageURL = "/Images/Furniture/Furniture3.png",
                Price = 70,
                Quantity = 90,
                CategoryId = category2Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Silver Lounge Chair",
                Description = "Very comfortable Silver lounge chair",
                ImageURL = "/Images/Furniture/Furniture4.png",
                Price = 120,
                Quantity = 95,
                CategoryId = category2Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Porcelain Table Lamp",
                Description = "White and blue Porcelain Table Lamp",
                ImageURL = "/Images/Furniture/Furniture6.png",
                Price = 15,
                Quantity = 100,
                CategoryId = category2Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Office Table Lamp",
                Description = "Office Table Lamp",
                ImageURL = "/Images/Furniture/Furniture7.png",
                Price = 20,
                Quantity = 73,
                CategoryId = category2Id
            });
            //Shoes Category
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Puma Sneakers",
                Description = "Comfortable Puma Sneakers in most sizes",
                ImageURL = "/Images/Shoes/Shoes1.png",
                Price = 100,
                Quantity = 50,
                CategoryId = category4Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Colorful Trainers",
                Description = "Colorful trainsers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes2.png",
                Price = 150,
                Quantity = 60,
                CategoryId = category4Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Blue Nike Trainers",
                Description = "Blue Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes3.png",
                Price = 200,
                Quantity = 70,
                CategoryId = category4Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Colorful Hummel Trainers",
                Description = "Colorful Hummel Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes4.png",
                Price = 120,
                Quantity = 120,
                CategoryId = category4Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Red Nike Trainers",
                Description = "Red Nike Trainers - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes5.png",
                Price = 200,
                Quantity = 100,
                CategoryId = category4Id
            });
            builder.Entity<Product>().HasData(new Product
            {
                Id = Guid.NewGuid(),
                Name = "Birkenstock Sandles",
                Description = "Birkenstock Sandles - available in most sizes",
                ImageURL = "/Images/Shoes/Shoes6.png",
                Price = 50,
                Quantity = 150,
                CategoryId = category4Id
            });

            Guid user1Id = Guid.NewGuid();
            Guid user2Id = Guid.NewGuid();

            //Add users
            builder.Entity<User>().HasData(new User
            {
                Id = user1Id.ToString(),
                UserName = "Bob"

            });
            builder.Entity<User>().HasData(new User
            {
                Id = user2Id.ToString(),
                UserName = "Sarah"

            });

            //Create Shopping Cart for Users
            builder.Entity<Cart>().HasData(new Cart
            {
                Id = Guid.NewGuid(),
                UserId = user1Id.ToString()

            });
            builder.Entity<Cart>().HasData(new Cart
            {
                Id = Guid.NewGuid(),
                UserId = user2Id.ToString()

            });
            //Add Product Categories

            builder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = category1Id,
                Name = "Beauty"
            });
            builder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = category2Id,
                Name = "Furniture"
            });
            builder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = category3Id,
                Name = "Electronics"
            });
            builder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = category4Id,
                Name = "Shoes"
            });
        }
    }
}
