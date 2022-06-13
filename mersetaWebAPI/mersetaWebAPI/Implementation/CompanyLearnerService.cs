using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class CompanyLearnerService : ICompanyLeaners
    {
        private readonly mersetaContext MmersetaContext;
        
        public CompanyLearnerService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<List<User>> GetAllCompanyLearners(int id)
        {
            List<CompanyLearner> company = new List<CompanyLearner>();
            List<User> users = new List<User>();
            var employee = MmersetaContext.CompanyLearners
                     .Where(x => x.CompanyId == id)
                    .Select(x => new { x.Id, x.CreateDate,x.CompanyId,x.UserId }).Take(10).ToList();
           

            foreach(var emp in employee)
            {
                company.Add(new CompanyLearner { Id = emp.Id, CreateDate = emp.CreateDate, CompanyId = emp.CompanyId, UserId = emp.UserId });
            }

            foreach(CompanyLearner camp in company)
            {
                var userfetch = (MmersetaContext.Users
                    .Where(x => x.Id == camp.UserId)).ToList();
                users.Add(userfetch[0]);
            }
             
            if (company != null)
            {
                return new Response<List<User>>(users);
            }
            return new Response<List<User>>(users);

        }
    }
}
