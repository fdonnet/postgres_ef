using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.Models;

namespace Test.Data.Config
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(a => a.Code)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(a => new { a.Code, a.TenantId })
                 .IsUnique();

            builder.Property(a => a.Label)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Description)
                .HasMaxLength(700);

            builder.Property(a => a.Version)
                .IsConcurrencyToken();


            //When it's a role specific to a tenant
            builder
                .HasOne(s => s.Tenant)
                .WithMany()
                .HasForeignKey(e => e.TenantId);
        }
    }
}
