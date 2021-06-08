using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;

namespace EmprendeUCR_WebApplication.Data.Contexts
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
           : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Canton> Canton { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Entrepreneur> Entrepreneur { get; set; }
        public DbSet<Product_Service> Product_Service { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<Is_Offer> Is_Offer { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Product_Photos> Product_Photos { get; set; }
    }
}
