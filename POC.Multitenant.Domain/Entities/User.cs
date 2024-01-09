namespace POC.Multitenant.Domain.Entities
{
    public class User
    {
        public Guid TenantId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
