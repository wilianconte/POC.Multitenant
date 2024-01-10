using POC.Multitenant.Data.Contexts;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Domain.Services
{
    public class CurrentTenantService : ICurrentTenantService
    {
        private readonly TenantDbContext _context;
        public Guid TenantId { get; set; }

        public CurrentTenantService(TenantDbContext context)
        {
            _context = context;

        }

        public async Task<bool> SetTenant(Guid tenant)
        {

            //var tenantInfo = await _context.Tenants.Where(x => x.Id == tenant).FirstOrDefaultAsync(); // check if tenant exists

            //if (tenantInfo != null)
            //{
                TenantId = tenant;
                return true;
            //}
            //else
            //{
            //    throw new Exception("Tenant invalid");
            //}

        }
        
    }
}
