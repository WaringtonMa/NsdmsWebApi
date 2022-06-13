using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class TrainingProviderService : ITrainingProvider
    {
        private readonly mersetaContext MmersetaContext;

        public TrainingProviderService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }

        public Response<TrainingProviderApplication> GetTrainingProvider(int id)
        {
            TrainingProviderApplication train = new TrainingProviderApplication();
            var trainvar = MmersetaContext.TrainingProviderApplications.Where(x => x.Id == id).ToList();
            train = trainvar[0];
            if (train != null)
            {
                return new Response<TrainingProviderApplication>(train);
            }
            return new Response<TrainingProviderApplication>(train);
        }
    }
}
