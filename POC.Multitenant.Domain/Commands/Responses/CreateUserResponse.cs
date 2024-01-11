namespace POC.Multitenant.Domain.Commands.Responses
{
    public class CreateUserResponse
    {
        public Guid TenantId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
