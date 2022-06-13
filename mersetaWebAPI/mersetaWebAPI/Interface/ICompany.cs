using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ICompany
    {
        public Response<List<Company>> GetAllCompanies();
    }
}
