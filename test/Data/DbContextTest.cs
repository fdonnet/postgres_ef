using Microsoft.EntityFrameworkCore;
using System.Net;
using Test.Data.Config;
using Test.Models;

namespace Test.Data
{
    public class DbContextTest(DbContextOptions<DbContextTest> options
        ) : DbContext(options)
    {
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTenant> UsersTenants { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoleByTenant> UserRolesByTenants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Configure
            new TenantConfiguration().Configure(modelBuilder.Entity<Tenant>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new UserTenantConfiguration().Configure(modelBuilder.Entity<UserTenant>());
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
