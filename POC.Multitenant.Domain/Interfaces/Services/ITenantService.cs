namespace POC.Multitenant.Domain.Interfaces.Services;

public interface ITenantService
{
    Guid TenantId { get; set; }
    public bool SetTenant(Guid tenant);
}
