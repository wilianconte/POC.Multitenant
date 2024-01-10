namespace POC.Multitenant.Domain.Interfaces
{
    public interface IMustHaveTenant
    {
        public Guid TenantId { get; set; }
    }
}
