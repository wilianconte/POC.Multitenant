using POC.Multitenant.Domain.Interfaces;

namespace POC.Multitenant.Domain.Entities
{
    public class User : IMustHaveTenant
    {
        public User()
        { }
        public User(string name) 
        {
            Name = name;
        }

        public Guid TenantId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
