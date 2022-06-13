using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ICompLearner
    {
        public Response<CompanyLearner> GetSingCompLearner(int userid,int companyid);
    }
}
