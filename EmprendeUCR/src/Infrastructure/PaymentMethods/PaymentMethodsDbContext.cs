using EmprendeUCR.Domain.PaymentMethods.Entities;
using EmprendeUCR.Infrastructure.Core;
using EmprendeUCR.Infrastructure.PaymentMethods.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace EmprendeUCR.Infrastructure.PaymentMethods
{
    public class PaymentMethodsDbContext : ApplicationDbContext
    {
        public PaymentMethodsDbContext(DbContextOptions<PaymentMethodsDbContext> options, ILogger<PaymentMethodsDbContext> logger)
            : base(options, logger)
        {
        }
        public DbSet<PaymentMethod> PaymentMethod { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PaymentMethodMap());
        }
    }
}