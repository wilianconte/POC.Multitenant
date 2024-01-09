using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
