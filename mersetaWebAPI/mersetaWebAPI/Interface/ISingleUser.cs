using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ISingleUser
    {
        public Response<User> GetSingleUser(int id);
    }
}
