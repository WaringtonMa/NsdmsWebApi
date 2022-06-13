using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface IIntervention
    {
        public Response<InterventionType> GetAllIntervetions(int id);
    }
}
