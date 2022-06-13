using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TownController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ITowns itown;
        public TownController(mersetaContext MmersetaContext, ITowns itown)
        {
            this.MmersetaContext = MmersetaContext;
                this.itown = itown;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetAllTowns()
        {
            var town = itown.GetAllTowns();
            if (town.Succeeded)
            {
                return Ok(town.Data);
            }
            return NotFound("User not found");
        }
    }
}
