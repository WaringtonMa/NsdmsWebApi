using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ITowns
    {
        public Response<List<Town>> GetAllTowns();
       
    }
}
