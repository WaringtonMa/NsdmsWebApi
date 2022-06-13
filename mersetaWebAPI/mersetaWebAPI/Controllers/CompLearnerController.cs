using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompLearnerController : Controller 
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ICompLearner compLeaner;
        public CompLearnerController(mersetaContext MmersetaContext, ICompLearner compLeaner)
        {
            this.MmersetaContext = MmersetaContext;
            this.compLeaner = compLeaner;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetSingleCompLearner(int userid, int companyid)
        {
            var comp = compLeaner.GetSingCompLearner(userid, companyid);
            if (comp.Succeeded)
            {
                return Ok(comp.Data);
            }
            return NotFound("User not found");
        
        }
    }
}
