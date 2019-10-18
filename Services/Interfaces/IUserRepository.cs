using TopCoderStarterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopCoderStarterApp.Services.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUser(long id);
        Task Create(User user);
        Task<bool> Update(User user);
        Task<bool> Delete(long id);

    }
}
