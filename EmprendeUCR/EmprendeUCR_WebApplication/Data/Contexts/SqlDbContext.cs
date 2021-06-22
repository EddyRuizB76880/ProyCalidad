using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmprendeUCR_WebApplication.Data.Entities;
using Microsoft.Extensions.Logging;
using Lab2.Infrastructure.Core;

namespace EmprendeUCR_WebApplication.Data.Contexts
{
    public class SqlServerDbContext : ApplicationDbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options, ILogger<SqlServerDbContext> logger)
           : base(options, logger)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Canton> Canton { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Entrepreneur> Entrepreneur { get; set; }
        public DbSet<Product_Service> Product_Service { get; set; }
        public DbSet<SinpePaymentMethod> SinpePaymentMethod { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Card> Card { get; set; }


        public DbSet<PaymentInfo> PaymentInfo { get; set; }
        public DbSet<PhonePaymentInfo> PhonePaymentInfo { get; set; }
        public DbSet<IBANCardPaymentInfo> IBANCardPaymentInfo { get; set; }
        public DbSet<IBANSINPEPaymentInfo> IBANSINPEPaymentInfo { get; set; }

        public DbSet<Offer> Offer { get; set; }
        public DbSet<Is_Offer> Is_Offer { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Members> Members { get; set; }
        public DbSet<Email_Confirmation> Email_Confirmation { get; set; }
        public DbSet<Administrator> Administrator { get; set; }
        public DbSet<Product_Photos> Product_Photos { get; set; }
        public DbSet<Service_Photos> Service_Photos { get; set; }
        public DbSet<Report> Report { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tells entity framework this entity has a composite key.
            modelBuilder.Entity<Is_Offer>()
                .HasKey(o => new { o.Offer_ID, o.Code_ID, o.User_Email, o.Category_ID });

            var likes = modelBuilder.Entity<Likes>();
            likes.HasKey(b => new { b.Client_Email, b.Category_Id });
        }      

    }
}