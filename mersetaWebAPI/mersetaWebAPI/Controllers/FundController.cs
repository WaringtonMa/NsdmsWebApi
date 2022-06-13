using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FundController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private IFunding funding;
        public FundController(mersetaContext MmersetaContext, IFunding funding)
        {
            this.MmersetaContext = MmersetaContext;
            this.funding = funding;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetFunding(int id)
        {
            var funds = funding.GetFunding(id);
            if (funds.Succeeded)
            {
                return Ok(funds.Data);
            }
            return NotFound("User not found");
        }
    }
}
