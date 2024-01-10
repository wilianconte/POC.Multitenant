using Microsoft.EntityFrameworkCore;

namespace POC.Multitenant.Data.Contexts
{
    public class TenantDbContext : DbContext
    {
        // This context is for looking up the tenant when a request comes in.
        public TenantDbContext(DbContextOptions<TenantDbContext> options) : base(options)
        {
        }
    }
}