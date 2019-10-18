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

        /// <summary>
        /// This method shows all blogs
        /// </summary>
        /// <returns></returns>
        ///<remarks>
        /// Sample request
        /// GET/Blog
        /// </remarks>

        // GET api/users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return new ObjectResult(await _repo.GetAllUsers());
        }
    }
}