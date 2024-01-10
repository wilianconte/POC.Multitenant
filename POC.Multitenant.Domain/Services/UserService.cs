using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Repositories;
using POC.Multitenant.Domain.Interfaces.Services;

namespace POC.Multitenant.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly ICurrentTenantService _tenantService;

        private readonly IUserRepository _repository;

        public UserService(ICurrentTenantService tenantService, IUserRepository repository)
        { 
            _tenantService = tenantService;
            _repository = repository;
        }

        public List<User> GetAll()
        { 
            return _repository.GetAll();
        }
    }
}
