using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ICompanyLeaners
    {
        public Response<List<User>> GetAllCompanyLearners(int id);
    }
}
