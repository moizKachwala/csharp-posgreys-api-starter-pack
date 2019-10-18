using TopCoderStarterApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using TopCoderStarterApp.Services;
using System.Threading.Tasks;
using System.Collections.Generic;
using TopCoderStarterApp.Services.Interfaces;

namespace TopCoderStarterApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UsersController(IUserRepository context)
        {
            _repo = context;
        }
#pragma warning restore CS1591

        // GET api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return new ObjectResult(await _repo.GetAllUsers());
        }

        // GET api/users/1
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(long id)
        {
            var user = await _repo.GetUser(id);

            if (user == null)
                return new NotFoundResult();

            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody] User user)
        {
            await _repo.Create(user);
            return new OkObjectResult(user);
        }

        // PUT api/users/1
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> Put(long id, [FromBody] User user)
        {
            var userFromDb = await _repo.GetUser(id);

            if (userFromDb == null)
                return new NotFoundResult();

            user.Id = userFromDb.Id;
            await _repo.Update(user);
            return new OkObjectResult(user);
        }

        // DELETE api/users/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var user = await _repo.GetUser(id);

            if (user == null)
                return new NotFoundResult();

            await _repo.Delete(id);

            return new OkResult();
        }
    }
}