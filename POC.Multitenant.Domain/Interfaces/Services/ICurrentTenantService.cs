namespace POC.Multitenant.Domain.Interfaces.Services;

public interface ICurrentTenantService
{
    Guid TenantId { get; set; }
    public Task<bool> SetTenant(Guid tenant);
}
