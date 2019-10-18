using dockerapi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Linq;
using dockerapi.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace dockerapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
#pragma warning disable CS1591
    public class UserController : ControllerBase
    {
        private readonly UserRepository _repo;

        public UserController(UserRepository context)
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