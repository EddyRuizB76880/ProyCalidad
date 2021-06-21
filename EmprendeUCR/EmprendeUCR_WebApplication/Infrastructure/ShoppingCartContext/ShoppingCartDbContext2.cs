using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EmprendeUCR_WebApplication.Domain.Core.CoreEntities;
using EmprendeUCR_WebApplication.Infrastructure.Core.EntityMappings;
using Lab2.Infrastructure.Core;
using Microsoft.Extensions.Logging;
using System.Reflection;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;
using EmprendeUCR_WebApplication.Infrastructure.ShoppingCartContext.EntityMappings;
#nullable disable

namespace EmprendeUCR_WebApplication.Infrastructure.ShoppingCartContext
{
    public partial class ShoppingCartDbContext2 : ApplicationDbContext
    {
        public ShoppingCartDbContext2(DbContextOptions<ShoppingCartDbContext2> options, ILogger<ShoppingCartDbContext2> logger) 
            : base(options, logger)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductService> ProductServices { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShopLine> ShopLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductServiceMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
            modelBuilder.ApplyConfiguration(new ShoppingCartMap());
            modelBuilder.ApplyConfiguration(new ProductLineMap());
        }
    }
}
