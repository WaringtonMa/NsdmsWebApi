using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingProviderController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ITrainingProvider trainingProvider;
        public TrainingProviderController(mersetaContext MmersetaContext, ITrainingProvider trainingProvider)
        {
            this.MmersetaContext = MmersetaContext;
            this.trainingProvider = trainingProvider;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetTrainingProvider(int id)
        {
            var train = trainingProvider.GetTrainingProvider(id);
            if (train.Succeeded)
            {
                return Ok(train.Data);
            }
            return NotFound("User not found");
        }
    }
}
