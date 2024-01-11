using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Mappings;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Data.Contexts
{
    public class DataContext : DbContext
    {
        private readonly Guid _tenantId;

        public DataContext(ITenantService tenantService, DbContextOptions<DataContext> options) : base(options)
        {
            _tenantId = tenantService.TenantId;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMapping());

            //Set QueryFilter
            modelBuilder.Entity<User>().HasQueryFilter(a => a.TenantId == _tenantId);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<IMustHaveTenant>().ToList()) 
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                    case EntityState.Modified:
                        entry.Entity.TenantId = _tenantId;
                        break;
                }
            }

            var result = base.SaveChanges();
            return result;
        }
    }
}