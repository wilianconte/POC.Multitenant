using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Contexts;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Repositories;

namespace POC.Multitenant.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DbContext context;

        public UserRepository (DataContext context) 
        {
            context = context;
        }

        public List<User> GetAll()
        {
            return null;
        }
    }
}