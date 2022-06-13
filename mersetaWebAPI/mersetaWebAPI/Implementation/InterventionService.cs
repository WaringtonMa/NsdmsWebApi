using mersetaWebAPI.Data;
using mersetaWebAPI.Interface;
using mersetaWebAPI.Models;
using mersetaWebAPI.Wrappers;

namespace mersetaWebAPI.Implementation
{
    public class InterventionService : IIntervention
    {
        private readonly mersetaContext MmersetaContext;

        public InterventionService(mersetaContext MmersetaContext)
        {
            this.MmersetaContext = MmersetaContext;
        }
        public Response<InterventionType> GetAllIntervetions(int id)
        {
            InterventionType intervetion = new InterventionType();
            var intervar = MmersetaContext.InterventionTypes.Where(x => x.Id == id).ToList();

            intervetion = intervar[0];

            if (intervetion != null)
            {
                return new Response<InterventionType>(intervetion);
            }
            return new Response<InterventionType>(intervetion);
        }
    }
}
