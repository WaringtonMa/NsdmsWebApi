using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SaqaQualificationController :  Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ISaqua saqua;
        public SaqaQualificationController(mersetaContext MmersetaContext, ISaqua saqua)
        {
            this.MmersetaContext = MmersetaContext;
            this.saqua = saqua;
        }

        [HttpGet]
        public async Task<ActionResult> GetSaqaqualification(int id)
        {
            var saq = saqua.GetSaqaqualification(id);
            if (saq.Succeeded)
            {
                return Ok(saq.Data);
            }
            return NotFound("User not found");
        }
    }
}
