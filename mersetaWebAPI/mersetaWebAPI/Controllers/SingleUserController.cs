using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SingleUserController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ISingleUser singleUser;
        public SingleUserController(mersetaContext MmersetaContext, ISingleUser singleUser)
        {
            this.MmersetaContext = MmersetaContext;
            this.singleUser = singleUser;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetSingleUser(int id)
        {
            var user = singleUser.GetSingleUser(id);
            if (user.Succeeded)
            {
                return Ok(user.Data);
            }
            return NotFound("User not found");
        }
    }
}
