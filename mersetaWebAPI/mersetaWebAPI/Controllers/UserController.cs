using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private IUsers users;
        public UserController(mersetaContext MmersetaContext, IUsers users)
        {
            this.MmersetaContext = MmersetaContext;
            this.users = users;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetAllUSers()
        {
            var user = users.GetAllUsers();
            if (user.Succeeded)
            {
                return Ok(user.Data);
            }
            return NotFound("User not found");
        }
    }
}
