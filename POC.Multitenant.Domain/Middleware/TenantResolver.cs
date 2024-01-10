using Microsoft.AspNetCore.Http;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Domain.Middleware
{
    public class TenantResolver
    {
        private readonly RequestDelegate _next;
        public TenantResolver(RequestDelegate next)
        {
            _next = next;
        }

        // Get Tenant Id from incoming requests 
        public async Task InvokeAsync(HttpContext context, ICurrentTenantService currentTenantService)
        {
            context.Request.Headers.TryGetValue("X-TenantId", out var tenantFromHeader); // Tenant Id from incoming request header

            if (string.IsNullOrEmpty(tenantFromHeader) == false)
            {
                await currentTenantService.SetTenant(Guid.Parse(tenantFromHeader));
            }

            await _next(context);
        }
    }
}
