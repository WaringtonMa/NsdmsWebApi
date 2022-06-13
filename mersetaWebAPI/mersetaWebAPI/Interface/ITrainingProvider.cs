using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Interface
{
    public interface ITrainingProvider
    {
        public Response<TrainingProviderApplication> GetTrainingProvider(int id);
    }
}
