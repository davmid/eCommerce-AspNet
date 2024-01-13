using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using shop_view.Models;
using System.Collections.Generic;

namespace shop_view.data
{
    public class shopDbContext : IdentityDbContext

    {
        public shopDbContext(DbContextOptions<shopDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingBasketXD> ShoppingCartItems { get; set; }
        public DbSet<AppUser> ApplicationUsers { get; set; }

    }
}