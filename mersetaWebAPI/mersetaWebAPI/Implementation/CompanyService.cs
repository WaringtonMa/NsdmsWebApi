using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mersetaWebAPI.Implementation
{
    public class CompanyService : ICompany
    {
        private readonly mersetaContext MmersetaContext;

        public CompanyService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<List<Company>> GetAllCompanies()
        {
            List<Company> company = new List<Company>();
            company.AddRange(MmersetaContext.Companies.Take(2000).ToList());

            if (company != null)
            {
                return new Response<List<Company>>(company);
            }
            return new Response<List<Company>>(company);
        }
    }
}
