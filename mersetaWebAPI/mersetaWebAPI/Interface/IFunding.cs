using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface IFunding
    {
        public Response<Funding> GetFunding(int id);
    }
}
