using System.Collections.Generic;
using System.Threading.Tasks;
using TopCoderStarterApp.Models;

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
