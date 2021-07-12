using EmprendeUCR.Domain.PaymentInfos.Entities;
using EmprendeUCR.Infrastructure.Core;
//using EmprendeUCR.Infrastructure.PaymentInfos.EntityMappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace EmprendeUCR.Infrastructure.PaymentInfo
{
    public class IBANCardPaymentInfosDbContext : ApplicationDbContext
    {
        public IBANCardPaymentInfosDbContext(DbContextOptions<IBANCardPaymentInfosDbContext> options, ILogger<IBANCardPaymentInfosDbContext> logger)
            : base(options, logger)
        {
        }
        public DbSet<IBANCardPaymentInfo> IBANCardPaymentInfo { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new PaymentMethodMap());  TODO
        }
    }
}