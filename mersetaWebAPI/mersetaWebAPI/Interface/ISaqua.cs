using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ISaqua
    {
        public Response<SaqaQualification> GetSaqaqualification(int id);
    }
}
