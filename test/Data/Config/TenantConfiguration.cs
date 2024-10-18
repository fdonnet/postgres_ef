using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Models;

namespace Test.Data.Config
{
    public class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.Property(a => a.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(a => a.Label)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Description)
                .HasMaxLength(250);

            builder.Property(a => a.Version)
                .IsConcurrencyToken();

            builder.Property(a => a.IsActivated)
                .IsRequired();

            builder.HasIndex(a => a.Code)
                .IsUnique();
        }
    }
}
