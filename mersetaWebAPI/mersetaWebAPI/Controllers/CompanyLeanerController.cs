using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyLeanerController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ICompanyLeaners icompanyLeaners;
        public CompanyLeanerController(mersetaContext MmersetaContext, ICompanyLeaners icompanyLeaners)
        {
            this.MmersetaContext = MmersetaContext;
            this.icompanyLeaners = icompanyLeaners;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetAllCompanyLearners(int id)
        {
            var companyleaners = icompanyLeaners.GetAllCompanyLearners(id);
            if (companyleaners.Succeeded)
            {
                return Ok(companyleaners.Data);
            }
            return NotFound("User not found");
        }
    }
}
