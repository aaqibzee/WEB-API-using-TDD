using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace WEB_API_using_TDD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            return Ok("Ok");
        }
    }
}
