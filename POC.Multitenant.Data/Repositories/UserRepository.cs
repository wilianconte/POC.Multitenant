using Microsoft.EntityFrameworkCore;
using POC.Multitenant.Data.Contexts;
using POC.Multitenant.Domain.Entities;
using POC.Multitenant.Domain.Interfaces.Repositories;

namespace POC.Multitenant.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository (DataContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.Where(p => p.Id == id).FirstOrDefaultAsync();

        }

        public User CreateUser(User user)
        {
            _context.Add(user);

            _context.SaveChanges();

            return user;
        }
    }
}