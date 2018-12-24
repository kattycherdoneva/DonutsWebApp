using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonutsWebApp.Data.Models;
using DonutsWebApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DonutsWebApp.Data
{
    public class DonutsAppContext : IdentityDbContext<DonutsAppUser>
    {
        public DonutsAppContext(DbContextOptions<DonutsAppContext> options)
            : base(options)
        {
        }

        public DbSet<Donation> Donations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ProductForReceipt> ProductForReceipts { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Shipping> Shippings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
