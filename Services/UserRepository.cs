using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TopCoderStarterApp.Models;
using TopCoderStarterApp.Services.Interfaces;

namespace TopCoderStarterApp.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiDBContext _context;
        public UserRepository(ApiDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Get all users from database
        /// </summary>
        /// <returns>List of Users</returns>
        public async Task<List<User>> GetAllUsers()
        {
            return await _context
                            .Users
                            .ToListAsync();
        }

        /// <summary>
        /// Get User by Id
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>User based on Id</returns>
        public async Task<User> GetUser(long id)
        {
            return await _context
                        .Users
                        .AsNoTracking()
                        .SingleOrDefaultAsync(c => c.Id == id);
        }

        /// <summary>
        ///  Creates the User
        /// </summary>
        /// <param name="user">Input the user object</param>
        /// <returns>newly constructed user</returns>
        public async Task Create(User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// Update User
        /// </summary>
        /// <param name="user">Input user object</param>
        /// <returns>udpated user</returns>
        public async Task<bool> Update(User user)
        {
            _context.Users.Attach(user);
            _context.Entry(user).State = EntityState.Modified;
            return (await _context.SaveChangesAsync() > 0 ? true : false);
        }

        /// <summary>
        /// Deletes the user based on Id
        /// </summary>
        /// <param name="id">Input Id of user</param>
        /// <returns>if successful => 1 else 0</returns>
        public async Task<bool> Delete(long id)
        {
            var customer = await _context.Users.SingleOrDefaultAsync(c => c.Id == id);
            _context.Remove(customer);

            return (await _context.SaveChangesAsync() > 0 ? true : false);
        }
    }
}
