using System;
using Microsoft.EntityFrameworkCore;

namespace exampleapp.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var envs = Environment.GetEnvironmentVariables();
            var host = envs["DBHOST"] ?? "localhost";
            var port = envs["DBPORT"] ?? "3306";
            var password = envs["DBPASSWORD"] ?? "mysecret";
            options.UseMySql($"server={host};userid=root;pwd={password};"
                    + $"port={port};database=products");
        }

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}