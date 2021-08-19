using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatoshiTestApp.Models
{
    public class SatoshiTestDbContext : DbContext
    {
        public SatoshiTestDbContext(DbContextOptions<SatoshiTestDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //    // Configure StudentId as FK for StudentAddress
            //    modelBuilder.Entity<SalesOrderModel>()
            //                .HasRequired(s => s.Address)
            //                .WithRequiredPrincipal(ad => ad.Student
            //                
            modelBuilder.Entity<ProductsModel>().HasData(new ProductsModel
            {
                id = 1,
                productName = "MI Notebook"
            },
            new ProductsModel
            {
                id = 2,
                productName = "Lenovo"
            },
              new ProductsModel
              {
                  id = 3,
                  productName = "Surface"
              },
                new ProductsModel
                {
                    id = 4,
                    productName = "Mac"
                });

        }

        public DbSet<SalesOrderModel> SalesOrders { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
    }
}
