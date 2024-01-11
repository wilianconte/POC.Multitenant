using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
    }
}
