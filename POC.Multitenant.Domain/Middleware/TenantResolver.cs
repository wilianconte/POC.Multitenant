﻿using Microsoft.AspNetCore.Http;
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
        public async Task InvokeAsync(HttpContext context, ITenantService tenantService)
        {
            // Tenant Id from incoming request header
            context.Request.Headers.TryGetValue("X-TenantId", out var tenantFromHeader); 

            if (string.IsNullOrEmpty(tenantFromHeader) == false)
            {
                tenantService.SetTenant(Guid.Parse(tenantFromHeader));
            }

            await _next(context);
        }
    }
}