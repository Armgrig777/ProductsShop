using Microsoft.EntityFrameworkCore;
using ProductsShop.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductsShop.Data.Data
{
    public class ProductsRepo : DbContext
    {
        const string connection = "Server=.;Database=ProductShopDb;Trusted_Connection=True;TrustServerCertificate=True";
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shop> Shop { get; set; }
    }
}
