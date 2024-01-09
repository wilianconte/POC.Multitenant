using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Repositories;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<User> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
