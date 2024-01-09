using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Contexts;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Repositories;


namespace POC.Multitenant.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository (DataContext context) 
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            var result = _context.Set<User>().ToList();

            return _context.Set<User>().ToList();
        }
    }
}