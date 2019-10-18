using TopCoderStarterApp.Models;
using TopCoderStarterApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopCoderStarterApp.Services
{
    public class UserRepository: IUserRepository
    {
        private readonly ApiDBContext _context;
        public UserRepository(ApiDBContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context
                            .Users
                            .ToListAsync();
        }

        public async Task<User> GetUser(long id)
        {
            return await _context
                        .Users
                        .AsNoTracking()
                        .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task Create(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(User user)
        {
            _context.Users.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            return (await _context.SaveChangesAsync() > 0 ? true : false);
        }
        public async Task<bool> Delete(long id)
        {
            var customer = await _context.Users.SingleOrDefaultAsync(c => c.Id == id);
            _context.Remove(customer);

            return (await _context.SaveChangesAsync() > 0 ? true : false);
        }
    }
}
