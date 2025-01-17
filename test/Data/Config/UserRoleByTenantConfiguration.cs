﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Data.Config
{
    public class UserRoleByTenantConfiguration : IEntityTypeConfiguration<UserRoleByTenant>
    {
        public void Configure(EntityTypeBuilder<UserRoleByTenant> builder)
        {
            builder.ToTable("users_roles_by_tenant");

            builder.HasIndex(a => new { a.UserTenantId, a.RoleId })
            .IsUnique();

            builder.Property(a => a.Version)
                .IsConcurrencyToken();

            builder
            .HasOne(e => e.UserTenant)
            .WithMany()
            .HasForeignKey(e => e.UserTenantId).OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

            builder
           .HasOne(e => e.Role)
           .WithMany()
           .HasForeignKey(e => e.RoleId).OnDelete(DeleteBehavior.Cascade)
           .IsRequired();

        }
    }
}
