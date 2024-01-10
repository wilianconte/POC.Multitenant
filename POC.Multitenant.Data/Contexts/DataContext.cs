using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Mappings;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Data.Contexts
{
    public class DataContext : DbContext
    {
        private readonly ICurrentTenantService _currentTenantService;
        public Guid CurrentTenantId { get; set; }

        public DataContext(ICurrentTenantService currentTenantService, DbContextOptions<DataContext> options) : base(options)
        {
            _currentTenantService = currentTenantService;
            CurrentTenantId = _currentTenantService.TenantId;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMapping());

            modelBuilder.Entity<User>().HasQueryFilter(a => a.TenantId == CurrentTenantId);
        }
    }
}