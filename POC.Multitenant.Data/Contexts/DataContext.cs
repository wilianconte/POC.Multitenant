using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Mappings;
using POC.Multitenant.Data.Seeds;
using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMapping());

            
        }
    }
}