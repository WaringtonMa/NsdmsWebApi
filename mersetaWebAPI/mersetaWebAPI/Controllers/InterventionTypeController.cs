using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InterventionTypeController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private IIntervention intervention;
        public InterventionTypeController(mersetaContext MmersetaContext, IIntervention intervention)
        {
            this.MmersetaContext = MmersetaContext;
            this.intervention = intervention;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetAllInterventionType(int id)
        {
            var intervantion = intervention.GetAllIntervetions(id);
            if (intervantion.Succeeded)
            {
                return Ok(intervantion.Data);
            }
            return NotFound("User not found");

        }
    }
}
