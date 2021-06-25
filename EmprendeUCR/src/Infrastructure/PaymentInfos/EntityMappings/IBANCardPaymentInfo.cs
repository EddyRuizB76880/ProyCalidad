using EmprendeUCR.Domain.Core.Helpers;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace EmprendeUCR.Infrastructure.PaymentInfo.EntityMappings
{
    public class IBANCardPaymentInfoMap : IEntityTypeConfiguration<IBANCardPaymentInfo>
    {
        public void Configure(EntityTypeBuilder<IBANCardPaymentInfo> builder)
        {
            builder.ToTable("IBANCardPaymentInfo");

            builder.HasKey(p => p.PaymentInfoID);
            
            builder.Property(p => p.AccountNumber);

            builder.Property(p => p.NameCard);
        }
    }
}