using shop_view.Models;
using shop_view.data.enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace shop_view.data
{
    public class shopDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<shopDbContext>();

                context.Database.EnsureCreated();

                

                // ... (Previous code)

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
    {
        // Existing products...

        new Product()
        {
            Name = "Classic Wooden Dining Table",
            ShortDescription = "Elegant and Timeless",
            Description = "Crafted from solid wood, this classic dining table adds a touch of elegance to any dining room. Durable and timeless design.",
            Price = 699.99,
            ImageURL = "https://example.com/classic_dining_table.jpg",
            ReleaseYear = 2021,
            ProductCategory = ProductCategory.Table,
            ManufacturerId = 2,
        },

        new Product()
        {
            Name = "Cozy Recliner Chair",
            ShortDescription = "Relax in Style",
            Description = "Unwind in ultimate comfort with this cozy recliner chair. It features plush upholstery and a reclining mechanism for added relaxation.",
            Price = 499.99,
            ImageURL = "https://example.com/cozy_recliner_chair.jpg",
            ReleaseYear = 2022,
            ProductCategory = ProductCategory.Chair,
            ManufacturerId = 3,
        },

        // Add six more products...

        // Product 3
        new Product()
        {
            Name = "Contemporary Bed Frame",
            ShortDescription = "Sleek and Modern",
            Description = "Upgrade your bedroom with this sleek and modern bed frame. The contemporary design adds a stylish touch to your sleeping space.",
            Price = 799.99,
            ImageURL = "https://example.com/contemporary_bed_frame.jpg",
            ReleaseYear = 2022,
            ProductCategory = ProductCategory.Bed,
            ManufacturerId = 1,
        },

        // Product 4
        new Product()
        {
            Name = "Vintage Coffee Table",
            ShortDescription = "Retro Charm",
            Description = "Bring retro charm to your living room with this vintage coffee table. The solid wood construction ensures durability and style.",
            Price = 299.99,
            ImageURL = "https://example.com/vintage_coffee_table.jpg",
            ReleaseYear = 2021,
            ProductCategory = ProductCategory.Table,
            ManufacturerId = 2,
        },

        // Product 5
        new Product()
        {
            Name = "Leather Office Chair",
            ShortDescription = "Comfortable and Professional",
            Description = "Stay comfortable and professional with this leather office chair. Adjustable features and quality materials for long-lasting use.",
            Price = 349.99,
            ImageURL = "https://example.com/leather_office_chair.jpg",
            ReleaseYear = 2022,
            ProductCategory = ProductCategory.Chair,
            ManufacturerId = 3,
        },

        // Product 6
        new Product()
        {
            Name = "Rustic Wardrobe",
            ShortDescription = "Charming Storage",
            Description = "Add charming storage to your bedroom with this rustic wardrobe. Ample space for clothes and a stylish addition to your decor.",
            Price = 599.99,
            ImageURL = "https://example.com/rustic_wardrobe.jpg",
            ReleaseYear = 2021,
            ProductCategory = ProductCategory.Wardrobe,
            ManufacturerId = 1,
        },

        // Product 7
        new Product()
        {
            Name = "Glass Dining Set",
            ShortDescription = "Modern Elegance",
            Description = "Dine in modern elegance with this glass dining set. The sleek design and quality materials make it a perfect addition to your home.",
            Price = 899.99,
            ImageURL = "https://example.com/glass_dining_set.jpg",
            ReleaseYear = 2022,
            ProductCategory = ProductCategory.Table,
            ManufacturerId = 2,
        },

        // Product 8
        new Product()
        {
            Name = "Lounge Sectional Sofa",
            ShortDescription = "Versatile and Comfortable",
            Description = "Create a cozy lounge area with this versatile sectional sofa. Comfortable seating and a modular design for flexible arrangements.",
            Price = 1299.99,
            ImageURL = "https://example.com/lounge_sectional_sofa.jpg",
            ReleaseYear = 2021,
            ProductCategory = ProductCategory.Sofa,
            ManufacturerId = 3,
        },

    });

                    context.SaveChanges();
                }

                // ... (Remaining code),

            };

                }

            }
        }
    
