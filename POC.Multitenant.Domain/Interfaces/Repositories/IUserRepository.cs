using POC.Multitenant.Domain.Entities;

namespace POC.Multitenant.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        User CreateUser(User user);
    }
}