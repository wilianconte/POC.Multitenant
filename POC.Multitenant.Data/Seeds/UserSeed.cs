using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Data.Seeds;

public class UserSeed 
{
    private static readonly Guid Tenant1 = Guid.NewGuid();
    private static readonly Guid Tenant2 = Guid.NewGuid();

    public static readonly User[] Data =
   {
        new User()
        { 
            TenantId = Tenant1,
            Id = 1,
            Name = "João"
        },
        new User()
        {
            TenantId = Tenant1,
            Id = 2,
            Name = "Maria"
        },
        new User()
        {
            TenantId = Tenant2,
            Id = 3,
            Name = "João"
        },
        new User()
        {
            TenantId = Tenant2,
            Id = 4,
            Name = "Maria"
        }
    };
}

