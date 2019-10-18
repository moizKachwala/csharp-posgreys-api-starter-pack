using dockerapi.Models;
using dockerapi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dockerapi.Services
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
    }
}
