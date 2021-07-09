using EmprendeUCR.Domain.Core.Helpers;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EmprendeUCR.Infrastructure.PaymentMethods.EntityMappings
{
    public class PaymentMethodMap : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");

            builder.HasKey(p => p.Name);
            
            builder.Property(p => p.Status);

            builder.Property(p => p.Type);
        }
    }
}