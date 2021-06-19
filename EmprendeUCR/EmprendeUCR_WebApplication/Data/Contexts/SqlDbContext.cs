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
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Email_Confirmation> Email_Confirmation { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var likes = modelBuilder.Entity<Likes>();
            likes.HasKey(b => new {b.Client_Email, b.Category_Id});
        }
        
    }
}
