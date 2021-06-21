using EmprendeUCR_WebApplication.Domain.Core.Helpers;
using EmprendeUCR_WebApplication.Domain.Core.ValueObjects;
using EmprendeUCR_WebApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EmprendeUCR_WebApplication.Domain.ShoppingCartContext.Entities;

namespace EmprendeUCR_WebApplication.Infrastructure.ShoppingCartContext.EntityMappings
{
    public class ShoppingCartMap : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(e => e.Email)
                   .HasName("PK__Shopping__A9D10535B2BE1623");

            builder.ToTable("Shopping_Cart");

            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            
            builder.HasMany(e => e.ShopLines)
                .WithOne(c => c.shoppingCart!);
        }
    }
}
