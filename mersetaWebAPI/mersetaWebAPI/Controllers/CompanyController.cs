using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly mersetaContext MmersetaContext;
        // MySqlConnection conn = new MySqlConnection("server=156.38.134.211;user id=merseta;password=M3rseta@345;port=3306;database=merseta;T");
        private ICompany icompany;
        public CompanyController(mersetaContext MmersetaContext, ICompany icompany)
        {
            this.MmersetaContext = MmersetaContext;
            this.icompany = icompany;
        }

        //get all users
        [HttpGet]
        public async Task<ActionResult> GetAllCompany()
        {
            var company = icompany.GetAllCompanies();
            if (company.Succeeded)
            {
                return Ok(company.Data);
            }
            return NotFound("User not found");
        }
    }
}
