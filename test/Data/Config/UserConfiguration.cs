using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(a => a.Firstname)
                .HasMaxLength(100);

            builder.Property(a => a.Lastname)
                .HasMaxLength(100);

            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(a => a.Version)
                .IsConcurrencyToken();

            builder.HasIndex(a => a.Email)
                .IsUnique();

            builder
                .HasOne(e => e.SelectedTenant)
                .WithMany()
                .HasForeignKey(e => e.SelectedTenantId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
